using UnityEngine;
using System.Collections;

public class DeleteOnCollision : MonoBehaviour {

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    void OnCollisionEnter(Collision other)
    {
        other.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
