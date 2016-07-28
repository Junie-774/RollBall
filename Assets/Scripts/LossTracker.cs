using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LossTracker : MonoBehaviour {

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("LOSE");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
