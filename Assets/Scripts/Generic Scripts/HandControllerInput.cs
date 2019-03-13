using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HandControllerInput
{
    public HandControllerType hand = HandControllerType.Unknown;

    [Range(-1f, 1f)]
    public float roll, pitch, yaw;

    [Range(-1f, 1f)]
    public float forward, right, up;

    [Range(0, 1f)]
    public float point, grasp;

    [Range(-1f, 1f)]
    public float primary, secondary;

    public bool thumb;
}
