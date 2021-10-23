using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out DeathZone death))
        {
            Debug.Log("Hit");
            FindObjectOfType<PlatformGenerator>().Replace(gameObject);
        }
    }

    public virtual void Hit(int damage)
    {
    }
}
