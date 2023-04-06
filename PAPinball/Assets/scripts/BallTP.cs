using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTP : MonoBehaviour
{
    [SerializeField] private Transform _tpPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            collision.gameObject.transform.position = _tpPoint.position;
        }
    }
}
