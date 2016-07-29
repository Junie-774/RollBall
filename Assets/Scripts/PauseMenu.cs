using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    bool isEnabled = false;

    // Use this for initialization
    void Start () {
        gameObject.SetActive(false);
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    public void EnterPauseMenu()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
