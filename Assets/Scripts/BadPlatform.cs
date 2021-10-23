using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadPlatform : Platform
{
    [SerializeField] private Vector2 _forceStrenghtRange;
    [SerializeField] private int _maxHealth = 1;

    private int _currentHealth;
    private bool _isBreak = false;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    private void Update()
    {
        if (_currentHealth <= 0 && _isBreak == false)
        {
            _isBreak = true;
            Break();
        }
    }

    public override void Hit(int damage)
    {
        _currentHealth -= damage;
    }

    public void Break()
    {
        PlatformBlock[] platformBlocks = GetComponentsInChildren<PlatformBlock>();

        Vector2 forceVector = new Vector2(Random.Range(_forceStrenghtRange.x, _forceStrenghtRange.y), -1).normalized;

        foreach (var sector in platformBlocks)
        {
            sector.Bounce(forceVector, gameObject.transform.position);
        }
        Destroy(gameObject, 2f);
        FindObjectOfType<PlatformGenerator>().Spawn();
    }
}
