using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField] private Vector2 _multiplierRange;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            ApplyImpulse(player.GetComponent<PlayerMovement>());
        }
    }

    public void ApplyImpulse(PlayerMovement target)
    {
        _animator.SetTrigger("bounce");
        target.Jump(Random.Range(_multiplierRange.x, _multiplierRange.y));
    }
}


