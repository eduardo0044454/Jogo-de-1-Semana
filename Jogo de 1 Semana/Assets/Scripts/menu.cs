using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour 
{
	public GameObject menuCanvas;
	public GameObject instructionsCanvas;
	public GameObject creditsCanvas;

	// Use this for initialization
	void Start () 
	{
		menuCanvas.SetActive (true);
		instructionsCanvas.SetActive (false);
		creditsCanvas.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
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
