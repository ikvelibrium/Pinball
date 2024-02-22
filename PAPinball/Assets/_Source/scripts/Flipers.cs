using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipers : MonoBehaviour
{

    [SerializeField] private KeyCode key;
    [SerializeField] private float _onPressedPosition = 45f;

    private float _startPosition = 0f;
    private float _strenght = 10000f;
    private float _damper = 150f;
    private HingeJoint _hinge;

    void Start()
    {
        _hinge = GetComponent<HingeJoint>();
        _hinge.useSpring = true;
        AppMetrica.Instance.ReportEvent("1");
        AppMetrica.Instance.ReportEvent("2");
        AppMetrica.Instance.ReportEvent("3");
        AppMetrica.Instance.ReportEvent("4");
        AppMetrica.Instance.ReportEvent("5");
    }

    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = _strenght;
        spring.damper = _damper;

        if (Input.GetKey(key))
        {
            spring.targetPosition = _onPressedPosition;
        }
        else
        {
            spring.targetPosition = _startPosition;
        }

        _hinge.spring = spring;
        _hinge.useLimits = true;
    }
}

