using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSyst : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private float _pointsPerJump;
    private float _score;
    private void Update()
    {
        _text.text = "Score:" + _score;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 8)
        {
            PlusScore(_pointsPerJump);
        }
    }

    public void PlusScore(float score)
    {
        _score += score;
    }

}
