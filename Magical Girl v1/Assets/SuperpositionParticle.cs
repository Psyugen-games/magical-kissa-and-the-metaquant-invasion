using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperpositionParticle : MonoBehaviour
{
    public Transform rotationCenter;
    public GameObject particle1;
    public GameObject particle2;

    public ParticleSystem wave;


    public float a, b, angularSpeed;

    float alpha, beta, X1, Y1, X2, Y2, timePassed;

    public float interval = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        alpha = 0.0f;
        beta = 180.0f;
        timePassed = 0.0f;
        wave.Pause();

        particle1.SetActive(true);
        particle2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed >= interval)
        {
            timePassed = 0.0f;
            particle1.SetActive(!particle1.activeSelf);
            particle2.SetActive(!particle2.activeSelf);
        }

        DoMovement();
    }

    private void DoMovement()
    {
        alpha += Time.deltaTime * angularSpeed;
        beta -= Time.deltaTime * angularSpeed;

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
        if (Mathf.Floor(X1) == Mathf.Floor(X2) && Mathf.Floor(Y1) == Mathf.Floor(Y2))
        {
            EmitWave();
        }
    }

    private void EmitWave()
    {
        wave.transform.position = particle1.transform.position;
        wave.Play();
    }
}
