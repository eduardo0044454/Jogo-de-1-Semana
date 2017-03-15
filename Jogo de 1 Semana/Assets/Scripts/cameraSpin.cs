using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSpin : MonoBehaviour
{
    public float spinSpeed;
    public GameObject teta;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        float xAxis = Input.GetAxis("Horizontal");

        if (xAxis < 0)
        {
            transform.Rotate(Vector3.forward * spinSpeed * -xAxis);
        }

        if (xAxis > 0)
        {
            transform.Rotate(Vector3.forward * spinSpeed * -xAxis);
        }
    }
}
