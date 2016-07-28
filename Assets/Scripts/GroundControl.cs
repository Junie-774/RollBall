using UnityEngine;
using System.Collections;

public class GroundControl : MonoBehaviour {

    private float xRotGoal = 20;
    private bool xRotGoalReached = false;

    private float zRotGoal = 20;
    private bool zRotGoalReached = false;


    private const float ROT_TOLERANCE = 1f;
    private const float DEFAULT_ROT_SPEED = 10f;

    // Use this for initialization
    void Start () {
    
    }

    // Update is called once per frame
    void FixedUpdate() {
        float currentXRot = transform.rotation.eulerAngles.x;
        float currentZRot = transform.rotation.eulerAngles.z;

        Vector3 rotateSpeed = new Vector3();


        xRotGoalReached = (Mathf.Abs(currentXRot - xRotGoal) < ROT_TOLERANCE);
        zRotGoalReached = (Mathf.Abs(currentZRot - zRotGoal) < ROT_TOLERANCE);

        if (xRotGoalReached)
        {
            if (Mathf.Abs(currentXRot - 20) < ROT_TOLERANCE)
            {
                xRotGoal = 340;
            }
            else if (Mathf.Abs(currentXRot - 340) < ROT_TOLERANCE)
            {
                xRotGoal = 20;
            }
        }

        if (zRotGoalReached)
        {
            if (Mathf.Abs(currentZRot - 20) < ROT_TOLERANCE)
            {
                zRotGoal = 340;
            }
            else if (Mathf.Abs(currentZRot - 340) < ROT_TOLERANCE)
            {
                zRotGoal = 20;
            }
        }

        if (xRotGoal == 20)
        {
            rotateSpeed.x = DEFAULT_ROT_SPEED;
        }
        else if (xRotGoal == 340)
        {
            rotateSpeed.x = -DEFAULT_ROT_SPEED;
        }

        if (zRotGoal == 20)
        {
            rotateSpeed.z = 20;
        }
        else if (zRotGoal == 340)
        {
            rotateSpeed.z = -20;
        }

        transform.Rotate(rotateSpeed * Time.deltaTime);
    }
}
