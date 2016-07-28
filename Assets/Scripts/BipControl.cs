using UnityEngine;
using System.Collections;

public class BipControl : MonoBehaviour {

    Vector3 rotation;
    BipManager spawnerScript;
    // Use this for initialization
    void Start () {
        rotation = new Vector3(15, 180, 50);

        spawnerScript = GameObject.Find("Bips").GetComponent<BipManager>();
        spawnerScript.addBip(gameObject);
    }
    
    // Update is called once per frame
    void Update () {
        transform.Rotate(rotation * Time.deltaTime);
    }

}
