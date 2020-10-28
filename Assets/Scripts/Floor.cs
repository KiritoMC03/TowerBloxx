using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Utils;

public class Floor : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private bool _isHangs = true;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.isKinematic = true;
    }

    void Update()
    {
        if (_isHangs)
        {
            FloorThrower();
        }
    }

    private void FloorThrower()
    {
        Debug.Log("P!");
        if (CheckKeyDown(KeyCode.P))
        {
            _rigidbody.isKinematic = false;
            _isHangs = false;

            StartCoroutine(IsTreiggerSetter());

        }
    }

    private IEnumerator IsTreiggerSetter()
    {
        yield return new WaitForSeconds(0.5f);
        SetIsTrigger(gameObject, false);
        StopCoroutine(IsTreiggerSetter());
    }
}
