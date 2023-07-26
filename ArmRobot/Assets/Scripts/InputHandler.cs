using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private RobotController robotController;

    private void Update() {
        if (Input.GetAxis("Base") < 0) {
            robotController.RotateJoint(JointNeeded.Base, RotationDirection.Negative);
        }
        if (Input.GetAxis("Base") > 0) {
            robotController.RotateJoint(JointNeeded.Base, RotationDirection.Positive);
        }
    }
}   
