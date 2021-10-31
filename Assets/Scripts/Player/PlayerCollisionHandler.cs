using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] private GameObject _touchParticle;
    private PlayerMovement _movement;


    private void Start()
    {
        _movement = GetComponent<PlayerMovement>();
    }

    private void InstantiateTouchParticle()
    {
        Vector2 position = new Vector2(transform.position.x, transform.position.y - 0.5f);
        Instantiate(_touchParticle, position, Quaternion.identity);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Platform platform))
        {
            if (_movement.GetVelocity().y <= 0)
            {
                platform.Hit(1);
                InstantiateTouchParticle();
                _movement.Jump();
                GetComponent<Animator>().SetTrigger("jump");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Coin coin))
        {
            coin.PickUp();
            GetComponent<WalletHandler>().AddCoin();
        }
    }
}
