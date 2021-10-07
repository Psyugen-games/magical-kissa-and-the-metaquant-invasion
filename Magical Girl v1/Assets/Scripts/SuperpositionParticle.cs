using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperpositionParticle : MonoBehaviour
{
    struct Measurement
    {
        public Vector2 position;
        public int particle;
        public int n;
        public Single probability;
        public void IncreaseN(int total)
        {
            n++;
            probability = n / total * 1.0f;
        }
    }

    private static readonly Enums.MQType type = Enums.MQType.SUPERPOSITION_PARTICLE;

    [Header("Required Objects")]
    [SerializeField]
    private Transform rotationCenter;
    [SerializeField]
    private GameObject particle1;
    [SerializeField]
    private GameObject particle2;
    [SerializeField]
    private ParticleSystem wave;

    [Header("Character Interaction Settings")]
    [SerializeField]
    private int totalMeasurementsNedded;

    [Header("Health Settings")]
    [SerializeField]
    private int fullHealth;
    [Header("Movement Settings")]
    [SerializeField]
    [Tooltip("Maximum length of the hellipse.")]
    private float a;
    [SerializeField]
    [Tooltip("Maximum height of the hellipse.")]
    private float b;
    [SerializeField]
    [Tooltip("Speed of particle1.")]
    private float angularSpeed1;
    [SerializeField]
    [Tooltip("Speed of particle2.")]
    private float angularSpeed2;

    [SerializeField]
    [Tooltip("Handles the frequency with which the two states visually alternate.")]
    private float frequency = 10.0f;
    [SerializeField]
    private float restartMovement = 200.0f;

    private int totalMeasurementsDone = 0, health;
    private float alpha, beta, X1, Y1, X2, Y2, timePassed;
    private List<Measurement> measurements = new List<Measurement>();

    private AnimationCurve cumulativeProbability = new AnimationCurve();

    public int GetRandomItem(int noOfItems)
    {
        return noOfItems * (int)cumulativeProbability.Evaluate(UnityEngine.Random.value);
    }

    // Start is called before the first frame update
    void Start()
    {
        alpha = 0.0f;
        beta = 180.0f;
        timePassed = 0.0f;
        wave.Pause();

        particle1.SetActive(true);
        particle2.SetActive(false);

        EventManager.Attack += ReceiveAttack;
        EventManager.Measure += ReceiveMeasurement;

    }

    // Update is called once per frame
    void Update()
    {
        if (totalMeasurementsDone < totalMeasurementsNedded)
        {
            AlternateParticle();
            DoMovement();
        }
        else
        {
            TimeoutMovement();
        }
    }

    private void TimeoutMovement()
    {
        timePassed += Time.deltaTime;

        if (timePassed >= restartMovement)
        {
            totalMeasurementsDone = 0;
            health += health+2 <= fullHealth ? 2 : 0;
        }
    }

    private void AlternateParticle()
    {
        timePassed += Time.deltaTime;

        if (timePassed >= frequency)
        {
            timePassed = 0.0f;
            particle1.SetActive(!particle1.activeSelf);
            particle2.SetActive(!particle2.activeSelf);
        }
    }

    private void DoMovement()
    {
        alpha += Time.deltaTime * angularSpeed1;
        beta -= Time.deltaTime * angularSpeed2;

        if (alpha >= 360.0f)
            alpha = 0.0f;

        if (beta <= 0.0f)
            beta = 360.0f;

        X1 = rotationCenter.position.x + a * Mathf.Cos(alpha);
        Y1 = rotationCenter.position.y + b * Mathf.Sin(alpha);

        X2 = rotationCenter.position.x + a * Mathf.Cos(beta);
        Y2 = rotationCenter.position.y + b * Mathf.Sin(beta);

        particle1.transform.position = new Vector2(X1, Y1);
        particle2.transform.position = new Vector2(X2, Y2);

        //questo potrebbe essere uno script in una classe madre per gestire condizioni di movimento
        if (ParticlesOverlap())
        {
            EmitWave();
        }
    }

    private void EmitWave()
    {
        wave.transform.position = particle1.transform.position;
        wave.Play();
    }

    private bool ParticlesOverlap()
    {
       return Mathf.Floor(X1) == Mathf.Floor(X2) && Mathf.Floor(Y1) == Mathf.Floor(Y2);
    }

    private void ReceiveAttack(int damage)
    {
        if (totalMeasurementsDone == totalMeasurementsNedded)
        {
            health -= damage;

            if (health <= 0)
            {
                EventManager.FireMQDeathEvent(type);
                Destroy(gameObject);
            }
        }
    }

    private void ReceiveMeasurement()
    {
        Debug.Log("Receiving Measurement");
        if (totalMeasurementsDone < totalMeasurementsNedded && ParticlesOverlap())
        {
            Measure();
        }

        if (totalMeasurementsNedded == totalMeasurementsDone)
        {
            MeasurementsSucceeded();
        }
    }

    private void Measure()
    {
        totalMeasurementsDone++;

        Measurement nm;
        nm.particle = particle1.activeSelf ? 1 : 2;
        Vector2 pos = particle1.activeSelf ? particle1.transform.position : particle2.transform.position;
        nm.position = new Vector2(Mathf.Floor(pos.x), Mathf.Floor(pos.y));
        nm.n = 1;
        nm.probability = nm.n / totalMeasurementsDone;

        bool found = false;
        for (int i = 0; i < measurements.Count; i++)
        {
            if (measurements[i].position.Equals(nm.position) && nm.particle.Equals(measurements[i].particle))
            {
                measurements[i].IncreaseN(totalMeasurementsDone);
                found = true;
                break;
            }
        }

        if (!found)
            measurements.Add(nm);
    }

    private void MeasurementsSucceeded()
    {
        float pr = 0.0f;
        for (int i = 0; i < measurements.Count; i++)
        {
            pr += measurements[i].n / measurements.Count * 1.0f;
            cumulativeProbability.AddKey(pr, i);
        }

        int idx = GetRandomItem(measurements.Count);

        particle1.SetActive(measurements[idx].particle == 1);
        particle2.SetActive(measurements[idx].particle == 2);
        particle1.transform.position = measurements[idx].position;
        particle2.transform.position = measurements[idx].position;
        timePassed = 0;
    }
}
