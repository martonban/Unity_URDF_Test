using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointController : MonoBehaviour
{
    [SerializeField] private float speed = 500.0f;
    
    private ArticulationBody articulation;


    void Start() 
    {
        articulation = GetComponent<ArticulationBody>();
    }

    void Update() 
    {
        Rotate(30f);
    }


    private void Rotate(float angle) {
        var drive = articulation.xDrive;
        drive.target = angle;
        articulation.xDrive = drive;
    }

}

