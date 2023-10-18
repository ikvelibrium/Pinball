using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBonus : MonoBehaviour
{
    [SerializeField] private float _scoreToPlus;

    private ScoreSyst _scoreSyst;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("fdf");
            _scoreSyst = collision.gameObject.GetComponent<ScoreSyst>();
            _scoreSyst.PlusScore(_scoreToPlus);
            Destroy(gameObject);
        }
    }
}
