using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EventManager : MonoBehaviour
{
    public delegate void ReceiveAttack(int damage);
    public static event ReceiveAttack Attack;

    public delegate void ReceiveMeasurement();
    public static event ReceiveMeasurement Measure;

    public static void FireMeasurementEvent()
    {
        Debug.Log("Measuring");
        Measure?.Invoke();
    }

    internal static void FireAttackEvent(int damage)
    {
        Attack?.Invoke(damage);
    }
}
