using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Player _target;

    private void Update()
    {
        if (_target.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(0, _target.transform.position.y, -10);
        }

    }
}
