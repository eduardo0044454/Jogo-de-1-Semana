using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void play()
	{
		SceneManager.LoadScene ("toy", LoadSceneMode.Single);
	}

	public void menu()
	{
		SceneManager.LoadScene ("menu", LoadSceneMode.Single);
	}

	public void exit()
	{
		Application.Quit ();
	}
}
