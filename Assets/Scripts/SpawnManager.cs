using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private float _spawnPosX;
    [SerializeField] private float _spawnPosY;
    [SerializeField] private float _spawnPosZ;
    [SerializeField] private float _startDelay;
    [SerializeField] private float _spawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnCube), _startDelay, _spawnInterval);
    }
    private void SpawnCube()
    {
        Vector3 spawnPos = new Vector3(_spawnPosX, _spawnPosY, _spawnPosZ);
        Instantiate(_cubePrefab, spawnPos, _cubePrefab.transform.rotation);
    }
}
