using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RotationDirection { None = 0, Positive = 1, Negative = -1 };

public class JointController : MonoBehaviour
{
    // Speed of a joint
    [SerializeField] private float speed = 1000.0f;

    // Enum negative/none/positive
    private RotationDirection rotationState = RotationDirection.None;

    // The joint's part
    private ArticulationBody articulation;


    void Start() 
    {
        // Get the component
        articulation = GetComponent<ArticulationBody>();
    }

    void Update() 
    {
        // Rotation
        if (rotationState != RotationDirection.None) {
            float rotationChange = (float)rotationState * speed * Time.deltaTime;
            float rotationGoal = CurrentPrimaryAxisRotation() + rotationChange;
            RotateToAngle(rotationGoal);
            StopRotation();
        }
    }


    float CurrentPrimaryAxisRotation() {
        float currentRotationRads = articulation.jointPosition[0];
        float currentRotation = Mathf.Rad2Deg * currentRotationRads;
        return currentRotation;
    }

    private void RotateToAngle(float angle) {
        var drive = articulation.xDrive;
        drive.target = angle;
        articulation.xDrive = drive;
    }

    public void SetRotation(RotationDirection rotationState) {
        this.rotationState = rotationState;
    }

    public void StopRotation() { 
        this.rotationState = RotationDirection.None;
    }

}

