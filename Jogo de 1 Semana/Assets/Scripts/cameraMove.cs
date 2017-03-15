using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public float camSpeed;
    private float timeLeft;

    // Use this for initialization
    void Start ()
    {
        timeLeft = 60f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (timeLeft >= 0)
        {
            timeLeft--;
        }

        if (timeLeft <= 0)
        {
            transform.Translate(Vector3.up * camSpeed);
        }
    }
}
