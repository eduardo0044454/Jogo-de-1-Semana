using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformSpawn : MonoBehaviour
{
    public GameObject plataformSystem;

    public GameObject plataform00;
    public GameObject plataform01;
    public GameObject plataform02;
    private int randomValue;
    private int randomMin = 1;
    private int randomMax = 3;

    // Use this for initialization
    void Start ()
    {
        randomValue = Random.Range(1, 4);

        if (randomValue == 1)
        {
            plataform00.SetActive(false);
            plataform01.SetActive(true);
            plataform02.SetActive(true);
        }
        else if (randomValue == 2)
        {
            plataform00.SetActive(true);
            plataform01.SetActive(false);
            plataform02.SetActive(true);
        }
        else if (randomValue == 3)
        {
            plataform00.SetActive(true);
            plataform01.SetActive(true);
            plataform02.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            
        }
    }
}