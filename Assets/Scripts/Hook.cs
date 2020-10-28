using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
//[RequireComponent(typeof(HingeJoint))]
public class Hook : MonoBehaviour
{
    private static Rigidbody _rigidbody;
    private static ConfigurableJoint _joint;
    private static SoftJointLimit _angularZ;

    [SerializeField] private float _rotateZLimit = 30;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _joint = GetComponent<ConfigurableJoint>();

        _angularZ = _joint.angularZLimit;
        _angularZ.limit = _rotateZLimit;
        _joint.angularZLimit = _angularZ;

        transform.Rotate(new Vector3(0, 0, 90f));
    }

    void Update()
    {
    }

    private void FixedUpdate()
    {
    }

    private void JointControl()
    {

    }
}