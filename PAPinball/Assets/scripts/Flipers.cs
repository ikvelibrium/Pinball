using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipers : MonoBehaviour
{

    [SerializeField] private float _restPosition;
    [SerializeField] private float _pressedPOsition;
    [SerializeField] private float _hitStrenght;
    [SerializeField] private float _flipperDamper;
    HingeJoint hinge;
    public string inputName;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = _hitStrenght;
        spring.damper = _flipperDamper;

        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("a");
            spring.targetPosition = _pressedPOsition;
        }
        else
        {
            //spring.targetPosition = _restPosition;
        }

        hinge.spring = spring;
        hinge.useLimits = true;
    }
}

