using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    private PlayerMovement _movement;
    private int damage = 1;

    private void Start()
    {
        _movement = GetComponent<PlayerMovement>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Platform platform))
        {
            if (_movement.GetVelocity().y <= 0)
            {
                _movement.Jump();
                platform.Hit(damage);
            }
        }
    }


}
