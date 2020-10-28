using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceAdder : MonoBehaviour
{
    void Start()
    {

    }

    internal static void AddForceToRigidbody(Rigidbody rigidbody, float[] _forceXYZ)
    {
        rigidbody.AddRelativeForce(new Vector3(_forceXYZ[0], _forceXYZ[1], _forceXYZ[2]));
    }

    internal static void AddVelocityFromFloor(Rigidbody hook, float angularBoost)
    {
        var boofer = hook.angularVelocity;
        boofer.z *= angularBoost;
        hook.angularVelocity = boofer;
    }
}
