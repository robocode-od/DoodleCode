using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour
{
    private PlayerMovement _movement;
    private Vector2 _direction;

    private void Start()
    {
        _movement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        _movement.Move(_direction);
    }
}
