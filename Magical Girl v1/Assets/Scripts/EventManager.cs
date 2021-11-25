using Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EventManager : MonoBehaviour
{
    public delegate void ReceiveAttack(int damage);
    public static event ReceiveAttack Attack;

    public delegate void ReceiveMQDeath(Enums.MQType MQType);
    public static event ReceiveMQDeath MQDeath;

    public delegate void ReceivePowerupExtintion(Enums.PUType PUType);
    public static event ReceivePowerupExtintion PowerupExtintion;

    public delegate void ReceiveMeasurement();
    public static event ReceiveMeasurement Measure;

    public delegate void OnLand();
    public static event OnLand Land;

    public delegate void OnCrouch(bool wasCrouching);
    public static event OnCrouch Crouch;

    public static void FireMeasurementEvent()
    {
        Measure?.Invoke();
    }

    internal static void FireAttackEvent(int damage)
    {
        Attack?.Invoke(damage);
    }

    internal static void FireMQDeathEvent(Enums.MQType MQType)
    {
        MQDeath?.Invoke(MQType);
    }

    internal static void FirePowerupExtinction(PUType PUType)
    {
        PowerupExtintion?.Invoke(PUType);

    }
    internal static void FireOnLand()
    {
        Land?.Invoke();

    }
    internal static void FireOnCrouch(bool wasCrouching)
    {
        Crouch?.Invoke(wasCrouching);

    }
}
