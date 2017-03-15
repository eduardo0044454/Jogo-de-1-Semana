using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawn : MonoBehaviour
{
    public GameObject plataformSystem;
    public GameObject platform00;
    public GameObject platform01;
    public GameObject platform02;
    private int randomValue;
    private float timeLeft;
    private bool newPlatform;

    // Use this for initialization
    void Start ()
    {
        timeLeft = 90f;
        newPlatform = false;
        randomValue = Random.Range(1, 4);

        if (randomValue == 1)
        {
            platform00.SetActive(false);
            platform01.SetActive(true);
            platform02.SetActive(true);
        }
        else if (randomValue == 2)
        {
            platform00.SetActive(true);
            platform01.SetActive(false);
            platform02.SetActive(true);
        }
        else if (randomValue == 3)
        {
            platform00.SetActive(true);
            platform01.SetActive(true);
            platform02.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (newPlatform)
        {
            timeLeft--;
        }

        if (timeLeft <= 0)
        {
            timeLeft = 90f;
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            Instantiate(plataformSystem, new Vector3(transform.position.x, transform.position.y + 6.060433f), Quaternion.identity);
            newPlatform = true;
        }

        if (collision.gameObject.tag == "can")
        {
            Debug.Log("teta");
        }
    }
}