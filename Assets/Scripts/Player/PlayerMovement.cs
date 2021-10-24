using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _sideSpeed = 5f;
    [SerializeField] private float _jumpStrenght = 10f;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpStrenght);
    }
    public void Jump(float multiplier)
    {
        _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpStrenght * multiplier);
    }

    public void Move(Vector2 direction)
    {
        transform.Translate(direction * _sideSpeed * Time.deltaTime);
    }

    public Vector2 GetVelocity()
    {
        return _rigidbody.velocity;
    }
}
