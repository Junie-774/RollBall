using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float movementSpeed = 15f;
    public float jumpForce = 10f;

    private Rigidbody playerBody;
    private Vector3 playerMovement;

    private BipManager bipManager;
    public GameObject thing;


    void Start()
    {
        playerMovement = new Vector3(0, 0, 0);
        playerBody = GetComponent<Rigidbody>();
        bipManager = GameObject.Find("Bips").GetComponent<BipManager>();
        transform.parent = transform;
    }

    void Update()
    {
        if (transform.position.y < -100)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void FixedUpdate()
    {
        float thrust = movementSpeed * (playerBody.mass);
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        playerMovement.x = moveHorizontal;
        playerMovement.z = moveVertical;
        playerMovement = thing.transform.TransformDirection(playerMovement);
        playerMovement.y = 0;
        playerBody.AddForce(playerMovement * thrust);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bip"))
        {
            bipManager.collectBip(other.gameObject);
        }
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            if (Input.GetKeyDown("space"))
            {
                playerBody.AddForce(0, jumpForce * 50 * playerBody.mass, 0);
            }
            
        }
    }
}
