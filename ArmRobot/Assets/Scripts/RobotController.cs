using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JointNeeded {   
    Base = 0, 
    Shoulder = 1, 
    Elbow = 2,
    Wrist1 = 3,
    Wrist2 = 4,
    Wrist3 = 5,
};

public class RobotController : MonoBehaviour
{
    [SerializeField] private List<JointController> joints = new List<JointController>();
    [SerializeField] private GameObject InputSystem;


    void Update() {
        
    }

    public void RotateJoint(JointNeeded needed, RotationDirection rotation) {

        joints[(int)needed].SetRotation(rotation);
    }


}
