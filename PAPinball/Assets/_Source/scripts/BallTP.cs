using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BallTP : MonoBehaviour
{
    [SerializeField] private Transform _tpPoint;
    [SerializeField] private GameObject _restartPnel;
    [SerializeField] private int _ballsAmount;
    [SerializeField] private TMP_Text _text;
    private void Start()
    {
        _text.text = "Balls left: " + _ballsAmount;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.layer == 6 && _ballsAmount > 0)
        {
            AppMetrica.Instance.ReportEvent("ballTP");
            _ballsAmount--;
            collision.gameObject.transform.position = _tpPoint.position;
        } else if(collision.gameObject.layer == 6 && _ballsAmount <= 0)
        {
            _restartPnel.gameObject.SetActive(true);
        }
        _text.text = "Balls left: " + _ballsAmount;
    }
}
