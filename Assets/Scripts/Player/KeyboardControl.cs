using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour
{
    private PlayerMovement _movement;
    private float direction;

    private void Start()
    {
        _movement = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        _movement.Move(new Vector2(direction, 0));
    }
}
