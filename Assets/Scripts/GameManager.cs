using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private float _gameSpeed;
    void Start()
    {
        Time.timeScale = _gameSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = _gameSpeed;
    }
}
