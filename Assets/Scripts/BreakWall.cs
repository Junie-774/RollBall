using UnityEngine;
using System.Collections;

public class BreakWall : MonoBehaviour {

    Rigidbody body;
    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player")) {
            transform.parent = null;
            body.useGravity = true;
            body.isKinematic = false;
        }
    }
}
