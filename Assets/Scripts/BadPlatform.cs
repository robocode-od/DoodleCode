using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadPlatform : Platform
{
    [SerializeField] private int _maxHealth = 1;

    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    private void Update()
    {
        if(_currentHealth <= 0)
        {
            Break();
        }
    }

    private void Break()
    {
        Destroy(gameObject);
    }

    public override void Hit(int damage)
    {
        _currentHealth -= damage;
    }
}
