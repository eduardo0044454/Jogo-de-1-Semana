using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour 
{
	public GameObject menuCanvas;
	public GameObject instructionsCanvas;
	public GameObject creditsCanvas;
    public GameObject cursor;
    private int setPos;
    private Vector3 playPos;
    private Vector3 instructionsPos;
    private Vector3 creditsPos;
    private Vector3 exitPos;

    // Use this for initialization
    void Start () 
	{
        Debug.Log(setPos);
        playPos = new Vector3(transform.position.x, -236.46f, transform.position.z);
        instructionsPos = new Vector3(transform.position.x, -238.13f, transform.position.z);
        creditsPos = new Vector3(transform.position.x, -239.73f, transform.position.z);
        exitPos = new Vector3(transform.position.x, -241.4f, transform.position.z);

        menuCanvas.SetActive (true);
		instructionsCanvas.SetActive (false);
		creditsCanvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            setPos--;
            Debug.Log(setPos);
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            setPos++;
            Debug.Log(setPos);
        }

        if (setPos <= 1)
        {
            setPos = 1;
        }

        if (setPos >= 3)
        {
            setPos = 2;
        }

        if (setPos == 0)
        {
            cursor.transform.position = playPos;
        }

        else if (setPos == 1)
        {
            cursor.transform.position = instructionsPos;
        }

        else if (setPos == 2)
        {
            cursor.transform.position = creditsPos;
        }

        else if (setPos == 3)
        {
            cursor.transform.position = exitPos;
        }

        if (setPos == 0 && Input.GetKeyDown(KeyCode.Return))
        {
            play();
        }

        else if (setPos == 1 && Input.GetKeyDown(KeyCode.Return))
        {
            instructions();
        }

        else if (setPos == 2 && Input.GetKeyDown(KeyCode.Return))
        {
            credits();
        }

        else if (setPos == 3 && Input.GetKeyDown(KeyCode.Return))
        {
            exit();
        }
    }

	public void play()
	{
		SceneManager.LoadScene ("toy", LoadSceneMode.Single);
	}

	public void instructions()
	{
		menuCanvas.SetActive (false);
		instructionsCanvas.SetActive (true);
		creditsCanvas.SetActive (false);
	}

	public void credits()
	{
		menuCanvas.SetActive (false);
		instructionsCanvas.SetActive (false);
		creditsCanvas.SetActive (true);
	}

	public void exit()
	{
		Application.Quit();
	}

	public void backMenu()
	{
		menuCanvas.SetActive (true);
		instructionsCanvas.SetActive (false);
		creditsCanvas.SetActive (false);
	}
}
