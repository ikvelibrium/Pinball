using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField] private SpringJoint _springJoint;
    private bool _spaceStiilPressed;

   
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && _springJoint.minDistance < 5)
        {
           
            _spaceStiilPressed = true;
            if (_spaceStiilPressed == true)
            {
                
                _springJoint.minDistance += 0.2f;
            }
           
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
           
            _spaceStiilPressed = false;
            _springJoint.minDistance = 0;   
        }
        
    }
}
