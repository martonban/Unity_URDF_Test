using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private RobotController robotController;

    private Dictionary<string, (JointNeeded joint, RotationDirection direction)> axisToJointMap;

    private void Start() {
        axisToJointMap = new Dictionary<string, (JointNeeded, RotationDirection)>
        {
            { "Base", (JointNeeded.Base, RotationDirection.None) },
            { "Shoulder", (JointNeeded.Shoulder, RotationDirection.None) },
            { "Elbow", (JointNeeded.Elbow, RotationDirection.None) },
            { "Wrist1", (JointNeeded.Wrist1, RotationDirection.None) },
            { "Wrist2", (JointNeeded.Wrist2, RotationDirection.None) },
            { "Wrist3", (JointNeeded.Wrist3, RotationDirection.None) },
        };
    }

    private void Update() {
        foreach (var axisPair in axisToJointMap) {
            float axisValue = Input.GetAxis(axisPair.Key);

            if (axisValue < 0) {
                robotController.RotateJoint(axisPair.Value.joint, RotationDirection.Negative);
            } else if (axisValue > 0) {
                robotController.RotateJoint(axisPair.Value.joint, RotationDirection.Positive);
            }
        }
    }
}   
