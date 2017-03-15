using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canSpawner : MonoBehaviour
{
    public GameObject canStraight;
    public GameObject canCurve;
    private int randomValue;
    private float timeLeft;
    private bool newCan;

    // Use this for initialization
    void Start ()
    {
        timeLeft = 90f;
        newCan = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (newCan)
        {
            timeLeft--;
        }

        if (timeLeft <= 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            Instantiate(canStraight, new Vector3(transform.position.x, transform.position.y + 18, transform.position.z), Quaternion.identity);
            newCan = true;
            //randomValue = Random.Range(1, 3);
            //if (randomValue == 1)
            //{
            //    Debug.Log("TETA");
            //}

            //if (randomValue == 2)
            //{
            //    Debug.Log("teta");
            //}
        }
    }
}
