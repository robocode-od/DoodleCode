using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private Platform _platformPrefab;
    [SerializeField] private int _platformAmount;
    [SerializeField] private Vector2 _verticalSpawnRange;
    [SerializeField] private Vector2 _horizontalSpawnRange;

    private Vector2 _spawnPoint;

    private void Start()
    {
        _spawnPoint = transform.position;
        for (int i = 0; i < _platformAmount; ++i)
        {
            _spawnPoint.y += Random.Range(_verticalSpawnRange.x, _verticalSpawnRange.y);
            _spawnPoint.x = Random.Range(_horizontalSpawnRange.x, _horizontalSpawnRange.y);
            Instantiate(_platformPrefab, _spawnPoint, Quaternion.identity);
        }
    }
}
