using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setMaterial : MonoBehaviour 
{
	public Sprite alborghetti;
	public Sprite gordox;
	public Sprite lasier;
	public Sprite naosei;
	public Sprite pele;
	public Sprite sadfrog;
	private int randomTextureValue;

	// Use this for initialization
	void Start () 
	{
		randomTextureValue = Random.Range (1, 7);

		if (randomTextureValue == 1) 
		{
			gameObject.GetComponent<SpriteRenderer> ().sprite = alborghetti;
		}

		if (randomTextureValue == 2) 
		{
			gameObject.GetComponent<SpriteRenderer> ().sprite = gordox;
		}

		if (randomTextureValue == 3) 
		{
			gameObject.GetComponent<SpriteRenderer> ().sprite = lasier;
		}

		if (randomTextureValue == 4) 
		{
			gameObject.GetComponent<SpriteRenderer> ().sprite = naosei;
		}

		if (randomTextureValue == 5) 
		{
			gameObject.GetComponent<SpriteRenderer> ().sprite = pele;
		}

		if (randomTextureValue == 6) 
		{
			gameObject.GetComponent<SpriteRenderer> ().sprite = sadfrog;
		}
	}
}
