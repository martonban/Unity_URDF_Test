using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
    [SerializeField] private RobotController robotController;

    private Dictionary<string, (JointNeeded joint, RotationDirection direction)> axisToJointMap;
    private Dictionary<KeyCode, int> keyMappingToJoint;

    [SerializeField] private int selectedJoint;


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

        keyMappingToJoint = new Dictionary<KeyCode, int>
        {
            { KeyCode.Alpha1, 0 },
            { KeyCode.Alpha2, 1 },
            { KeyCode.Alpha3, 2 },
            { KeyCode.Alpha4, 3 },
            { KeyCode.Alpha5, 4 },
            { KeyCode.Alpha6, 5 }
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

        foreach (var keyPair in keyMappingToJoint) {
            if (Input.GetKey(keyPair.Key)) {
                selectedJoint = keyPair.Value;
                break;
            }
        }

        // Decrease Speed
        if (Input.GetKey(KeyCode.Alpha8)) {
            robotController.JointSpeedChange(selectedJoint, -1.0f);
        }

        // Increase Speed
        if (Input.GetKey(KeyCode.Alpha9)) {
            robotController.JointSpeedChange(selectedJoint, 1.0f);
        }


    }

}