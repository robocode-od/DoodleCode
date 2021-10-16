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
        _rigidbody.AddForce(Vector2.up * _jumpStrenght, ForceMode2D.Impulse);
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
