﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float tiltSpeed;
    public float jumpSpeed;
    private int count; 
    public Transform ball;

    public Text playTime;
    private float playTimeValue;

	public AudioSource jumpSound;
	public AudioClip jumpSFX;
	private float lowPitchRange = .95f;
	private float highPitchRange = 1.05f;

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
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            count--;
			playSingle (jumpSFX);
        }

        playTimeValue++;
        playTime.text = "Time: " + playTimeValue;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "plataform")
        {
            count = 2;
        }

		if (collision.gameObject.tag == "end") 
		{
			SceneManager.LoadScene ("gameOver", LoadSceneMode.Single);
		}
    }

	void playSingle(AudioClip clip)
	{
		if (!jumpSound.isPlaying && count >= 0) 
		{
			jumpSound.clip = clip;
			jumpSound.Play ();
			randomizeSfx (jumpSFX);	
		}
	}

	void randomizeSfx(params AudioClip[] clips)
	{
		int randomIndex = Random.Range (0, clips.Length);
		float randomPitch = Random.Range (lowPitchRange, highPitchRange);

		jumpSound.pitch = randomPitch;
		jumpSound.clip = clips [randomIndex];
		jumpSound.Play ();
	}
}
