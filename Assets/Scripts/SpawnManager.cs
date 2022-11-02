using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private CubeMove _cubePrefab;
    [SerializeField] private float _spawnPosX;
    [SerializeField] private float _spawnPosY;
    [SerializeField] private float _spawnPosZ;
    [SerializeField] private float _startDelay;
    [SerializeField] private float _spawnInterval = 2f;

    private void Start()
    {
        _cubePrefab.Speed = 8;
        _cubePrefab.Distance = 20;
        StartCoroutine(SpawnRoutine());
    }

    private void SpawnCube()
    {
        Vector3 spawnPos = new Vector3(_spawnPosX, _spawnPosY, _spawnPosZ);
        Instantiate(_cubePrefab, spawnPos, _cubePrefab.transform.rotation);
    }

    public void SetSpeed(string input)
    {
        if (float.TryParse(input, out var speed))
        {
            _cubePrefab.Speed = speed;
        }
        else Debug.Log("incorrect input");
    }

    public void SetDistance(string input)
    {
        if (float.TryParse(input, out var distance))
        {
            _cubePrefab.Distance = distance;
        }
        else Debug.Log("incorrect input");
    }

    public void SetSpawnInterval(string input)
    {
        if (float.TryParse(input, out var spawnInterval) && spawnInterval > 0)
        {
            _spawnInterval = spawnInterval;
        }
        else Debug.Log("incorrect input");
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnCube();
            yield return new WaitForSeconds(_spawnInterval);
        }
    }


}
