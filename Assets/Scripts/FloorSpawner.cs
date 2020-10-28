using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _floor;
    [SerializeField] private GameObject _hook;
    private Rigidbody _hookRigidbody;

    [SerializeField] private float _forceToX = 0;
    [SerializeField] private float _forceToY = 0;
    [SerializeField] private float _forceToZ = 0;
    [SerializeField] private float _angularVelocityToFloor = 2f;

    private Vector3 _spawnPosition;

    void Start()
    {
        _hookRigidbody = _hook.GetComponent<Rigidbody>();
        _spawnPosition = new Vector3(0, -4f, 0f);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnFloor();
        }
    }

    private void SpawnFloor()
    {
        var _newFloor = Instantiate(_floor, _hook.transform);
        _newFloor.transform.localPosition = _spawnPosition;
        _newFloor.GetComponent<Rigidbody>().isKinematic = true;

        ForceAdder.AddForceToRigidbody(_hookRigidbody, new float[] { _forceToX, _forceToY, _forceToZ });
        ForceAdder.AddVelocityFromFloor(_hookRigidbody, _angularVelocityToFloor);
    }
}
