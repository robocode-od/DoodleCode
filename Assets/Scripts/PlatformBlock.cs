using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBlock : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void Bounce(Vector2 force, Vector2 position)
    {
        _rigidbody.isKinematic = false;
        _rigidbody.gravityScale = 1;
        _rigidbody.AddForceAtPosition(force, position, ForceMode2D.Impulse);
    }
}
