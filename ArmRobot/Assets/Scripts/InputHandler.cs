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
        if (Input.GetAxis("Shoulder") < 0) {
            robotController.RotateJoint(JointNeeded.Shoulder, RotationDirection.Negative);
        }
        if (Input.GetAxis("Shoulder") > 0) {
            robotController.RotateJoint(JointNeeded.Shoulder, RotationDirection.Positive);
        }
        if (Input.GetAxis("Elbow") < 0) {
            robotController.RotateJoint(JointNeeded.Elbow, RotationDirection.Negative);
        }
        if (Input.GetAxis("Elbow") > 0) {
            robotController.RotateJoint(JointNeeded.Elbow, RotationDirection.Positive);
        }
        if (Input.GetAxis("Wrist1") < 0) {
            robotController.RotateJoint(JointNeeded.Wrist1, RotationDirection.Negative);
        }
        if (Input.GetAxis("Wrist1") > 0) {
            robotController.RotateJoint(JointNeeded.Wrist1, RotationDirection.Positive);
        }
        if (Input.GetAxis("Wrist2") < 0) {
            robotController.RotateJoint(JointNeeded.Wrist2, RotationDirection.Negative);
        }
        if (Input.GetAxis("Wrist2") > 0) {
            robotController.RotateJoint(JointNeeded.Wrist2, RotationDirection.Positive);
        }
        if (Input.GetAxis("Wrist3") < 0) {
            robotController.RotateJoint(JointNeeded.Wrist3, RotationDirection.Negative);
        }
        if (Input.GetAxis("Wrist3") > 0) {
            robotController.RotateJoint(JointNeeded.Wrist3, RotationDirection.Positive);
        }

    }
}   
