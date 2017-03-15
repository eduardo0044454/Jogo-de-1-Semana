using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float tiltSpeed;
    public float jumpSpeed;
    private int count; 
    public Transform ball;

	// Use this for initialization
	void Start ()
    {
        count = 2;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float xAxis = Input.GetAxis("Horizontal");

        if (xAxis >= 1)
        {
            ball.transform.Rotate(Vector3.forward * 2 * -xAxis);
            transform.Translate(Vector3.right * (xAxis * tiltSpeed));
        }

        if (xAxis <= 1)
        {
            ball.transform.Rotate(Vector3.forward * 2 * -xAxis);
            transform.Translate(Vector3.right * (xAxis * tiltSpeed));
        }

        if (Input.GetKeyDown(KeyCode.Space) && count > 0)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            count--;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "plataform")
        {
            count = 2;
        }
    }
}
