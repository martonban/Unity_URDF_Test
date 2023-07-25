using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointController : MonoBehaviour
{
    [SerializeField] private float speed = 100.0f;
    
    private ArticulationBody articulation;


    void Start() 
    {
        articulation = GetComponent<ArticulationBody>();
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            float rotationChange =  speed * Time.fixedDeltaTime;
            float rotationGoal = CurrentPrimaryAxisRotation() + rotationChange;
            RotateToAngle(rotationGoal);
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

}

