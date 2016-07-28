using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BipManager : MonoBehaviour {

    private int bipsCollected;
    private int numActiveBips = 0;
    public float spawnPeriodSeconds = 3f;
    private float nextSpawnTime = 0f;

    public Text UICountText;

    List<GameObject> bips;
    void Awake()
    {
        bips = new List<GameObject>();
    }
    // Use this for initialization
    void Start () {
        updateCountText();
        bipsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            nextSpawnTime += spawnPeriodSeconds;

            if (bips.Count < 4)
            {
                spawnBip();
            }
        }
    }
    void spawnBip()
    {
        Vector3 newBipPos = new Vector3(Random.Range(-4.8f, 4.8f), Random.Range(1.2f, 2f), Random.Range(-4.8f, 4.8f));
        GameObject newBip = (GameObject)Instantiate(Resources.Load("Prefabs/Bip"), newBipPos, transform.rotation);
        newBip.transform.parent = transform;        
    }

    public void addBip(GameObject bipToAdd)
    {
        if (bipToAdd.Equals(null))
        {
            print("WTF");
        }
        if (bips == null)
        {
            print("DOUBLE WTF");
        }
        bips.Add(bipToAdd);
        numActiveBips++;
    }

    public void updateCountText()
    {
        UICountText.text = "Bips: " + bipsCollected.ToString();
    }

    public void collectBip(GameObject bipToCollect)
    {
        bipsCollected++;
        bips.Remove(bipToCollect);
        bipToCollect.SetActive(false);
        updateCountText();
        numActiveBips--;
        
    }

}
