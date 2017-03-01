using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateText : MonoBehaviour {

	public int playersTurn;
	private string aButton;
	private string bButton;
	private string xButton;
	private string yButton;
	public bool firstChoice = true;
	GameObject dialogueHolder;
	DetermineTextDisplay dtd;
	StringsToDisplay s2d;
	public GameObject currentAScene;
	public GameObject generatedText; 
	TextBoxScript tbs;

	// Use this for initialization
	void Start () {
		dialogueHolder = GameObject.Find ("Dialogue Holder");
		dtd = dialogueHolder.GetComponent<DetermineTextDisplay> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		generatedText = dtd.slot0;
		tbs = generatedText.GetComponent<TextBoxScript> ();
		currentAScene = dtd.currentAScene; 
		turnControls ();
		select ();
	}

	void turnControls ()
	{
		aButton = "A Button_P" + playersTurn;
		bButton = "B Button_P" + playersTurn;
		xButton = "X Button_P" + playersTurn;
		yButton = "Y Button_P" + playersTurn;
	}

	void select ()
	{
		if (dtd.aSceneNumber == 0) 
		{

			if (firstChoice == true) 
			{

				if (Input.GetButtonDown (aButton)) 
				{
					tbs.determineText (2);
					shiftText ();
					playersTurn = 2;

				}

				if (Input.GetButtonDown (bButton)) 
				{
					tbs.determineText (6);
					shiftText ();
					playersTurn = 2;

				}

				if (Input.GetButtonDown (xButton)) 
				{
					tbs.determineText (10);
					shiftText ();
					playersTurn = 2;
				}

				if (Input.GetButtonDown (yButton)) 
				{
					tbs.determineText (14);
					shiftText ();
					playersTurn = 2;
				}
		
			}
		}
	}

	void shiftText ()
	{
		firstChoice = false; 
		tbs.ownerNum = playersTurn;
		dtd.slot0 = dtd.slot1;
		dtd.slot1 = dtd.slot2;
		dtd.slot2 = dtd.slot3;
		dtd.slot3 = dtd.slot1;
	}
		
}
