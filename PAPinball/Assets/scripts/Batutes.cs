using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batutes : MonoBehaviour
{
    [SerializeField] private float _strength;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            
            Vector3 ballOldDirection = transform.position - collision.gameObject.transform.position;
            float dist = ballOldDirection.magnitude;
            Vector3 ballNewDirection = ballOldDirection / dist;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(ballNewDirection.x * _strength, ballNewDirection.y * _strength, ballNewDirection.z * _strength), ForceMode.Impulse);
        }
    }
}   
