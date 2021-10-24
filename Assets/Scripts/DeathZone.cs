using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Platform platform))
        {
            FindObjectOfType<PlatformGenerator>().Replace(platform.gameObject);
        }
    }
}
