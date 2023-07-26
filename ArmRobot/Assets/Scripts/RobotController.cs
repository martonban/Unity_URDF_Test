using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    [SerializeField] private List<JointController> joints = new List<JointController>();

    void Update() {

        if (Input.GetKeyDown(KeyCode.W)) {
            for (int i = 0; i < joints.Count; i++) {
                joints[i].SetRotation(RotationDirection.Positive);
            }
        }
    }
}
