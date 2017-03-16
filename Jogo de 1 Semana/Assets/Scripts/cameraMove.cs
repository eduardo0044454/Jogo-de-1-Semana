using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    private float camSpeed;
    private float timeLeft;
    private float timeToSpeedUp;

    // Use this for initialization
    void Start ()
    {
        timeLeft = 120f;
        camSpeed = 0.05f;
        timeToSpeedUp = 180f;
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

        timeToSpeedUp--;
        if (timeToSpeedUp <= 0)
        {
            timeToSpeedUp = 180f;
            camSpeed += 0.01f;
        }

        if (camSpeed >= 0.8f)
        {
            camSpeed = 0.8f;
        }
    }
}
