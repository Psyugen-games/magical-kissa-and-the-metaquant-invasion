using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField]
    private int damage;


    // Start is called before the first frame update
    void Start()
    {
        damage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //left
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

        //right
        if (Input.GetMouseButtonDown(1))
        {
            Measure();
        }
        
    }

    private void Measure()
    {
        EventManager.FireMeasurementEvent();
    }

    private void Attack()
    {
        EventManager.FireAttackEvent(damage);
    }
}
