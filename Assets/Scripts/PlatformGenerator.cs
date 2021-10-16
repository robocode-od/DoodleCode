using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    // 1. Нужно добавить объект, который спавнить
    // 2. Выбрать диапfзон позиций

    [SerializeField] private Platform _spawnObject;
    [SerializeField] private int _platformsAmount;
    [SerializeField] private Vector2 _horizontalPositionRange;
    
    [SerializeField] private Vector2 _vecticalPositionRange;

    private Vector2 _spawnPoint;

    private void Start()
    {
        _spawnPoint = transform.position;
        for(int i = 0; i < _platformsAmount; ++i)
        {
            _spawnPoint.x = Random.Range(_horizontalPositionRange.x, _horizontalPositionRange.y);
            _spawnPoint.y += Random.Range(_vecticalPositionRange.x, _vecticalPositionRange.y);
            Instantiate(_spawnObject, _spawnPoint, Quaternion.identity);
        }
    }
}
