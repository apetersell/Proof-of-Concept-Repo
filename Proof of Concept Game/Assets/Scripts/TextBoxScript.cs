using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxScript : MonoBehaviour {
	
	private string nada;
	public int ownerNum;
	Image img; 
	Text txt;
	GameObject dialogueHolder;
	DetermineTextDisplay dtd;
	StringsToDisplay s2d;
	public GameObject currentAScene;


	// Use this for initialization

	void Start () {
		img = GetComponent<Image> ();
		txt = GetComponentInChildren<Text> ();
		nada = "";
		dialogueHolder = GameObject.Find ("Dialogue Holder");
		dtd = dialogueHolder.GetComponent<DetermineTextDisplay> ();
	}
	
	// Update is called once per frame
	void Update () {

		currentAScene = dtd.currentAScene;
		s2d = currentAScene.GetComponent<StringsToDisplay> (); 
		determineBox ();

	}

	public void determineBox ()
	{
		if (ownerNum == 0) 
		{
			img.color = dtd.vanished;
			txt.text = nada;
		}

		if (ownerNum == 1) 
		{
			img.color = dtd.player1;
		}

		if (ownerNum == 2) 
		{
			img.color = dtd.player2;
		}

		if (ownerNum == 3) 
		{
			img.color = dtd.introOutro;
		}
	}

	public void determineText (int sentNum)
	{
		txt.text = s2d.thingsTosay [sentNum];

	}
}
