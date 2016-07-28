using UnityEngine;
using System.Collections;

public class PlayerFollower : MonoBehaviour {

    public float mouseSensitivity = 3;
    public GameObject player;

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void LateUpdate () {
        float rotY = Input.GetAxis("Mouse X") * mouseSensitivity;
        float rotX = Input.GetAxis("Mouse Y") * -mouseSensitivity;

        transform.Rotate(rotX, rotY, 0);
        transform.position = player.transform.position;
    }
}
