using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class platformSpawn : MonoBehaviour
{
    public GameObject plataformSystem;
    public GameObject platform00;
    public GameObject platform01;
    public GameObject platform02;
    public GameObject platform03;
    public GameObject platform04;
    public GameObject platform05;
    private int randomValueDown;
    private int randomValueUp;
    private float timeLeft;
    private bool newPlatform;

    // Use this for initialization
    void Start ()
    {
        timeLeft = 180f;
        newPlatform = false;
        randomValueDown = Random.Range(1, 4);
        randomValueUp = Random.Range(1, 4);

        if (randomValueDown == 1)
        {
            platform00.SetActive(false);
            platform01.SetActive(true);
            platform02.SetActive(true);
        }
        else if (randomValueDown == 2)
        {
            platform00.SetActive(true);
            platform01.SetActive(false);
            platform02.SetActive(true);
        }
        else if (randomValueDown == 3)
        {
            platform00.SetActive(true);
            platform01.SetActive(true);
            platform02.SetActive(false);
        }

        if (randomValueUp == 1)
        {
            platform03.SetActive(false);
            platform04.SetActive(true);
            platform05.SetActive(true);
        }
        else if (randomValueDown == 2)
        {
            platform03.SetActive(true);
            platform04.SetActive(false);
            platform05.SetActive(true);
        }
        else if (randomValueDown == 3)
        {
            platform03.SetActive(true);
            platform04.SetActive(true);
            platform05.SetActive(false);
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
            timeLeft = 180f;
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            Instantiate(plataformSystem, new Vector3(transform.position.x, transform.position.y + 12.120866f), Quaternion.identity);
            newPlatform = true;
        }

        if (collision.gameObject.tag == "can")
        {
            Debug.Log("teta");
        }
    }
}