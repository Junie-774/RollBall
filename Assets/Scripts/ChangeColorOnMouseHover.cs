using UnityEngine;
using System.Collections;

public class ChangeColorOnMouseHover : MonoBehaviour {

    public Color defaultColor = Color.black;
    public Color hoverColor = Color.gray;
    Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.material.color = defaultColor;
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    void OnMouseEnter()
    {
        print("Meow");
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = Color.blue;
    }
}
