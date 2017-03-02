using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStageInputs: MonoBehaviour {

	public int playersTurn = 1; 
	private string aButton;
	private string bButton;
	private string xButton;
	private string yButton;
	public bool A = true; 
	public bool A2;  
	public bool A2Prime;  
	DialogueImplementation di;

	// Use this for initialization
	void Start () {

		di = GetComponent<DialogueImplementation> (); 
		
	}
	
	// Update is called once per frame
	void Update () {
		turnControls ();
		pressA ();
		pressB ();
		pressX ();
		pressY ();

	}

	void turnControls ()
	{
		aButton = "A Button_P" + playersTurn;
		bButton = "B Button_P" + playersTurn;
		xButton = "X Button_P" + playersTurn;
		yButton = "Y Button_P" + playersTurn;
	}

	void pressA ()
	{
		if (Input.GetButtonDown (aButton)) 
		{
			di.SelectOption00 ();
			if (A) 
			{
				POCLibrary.AddLungeToList (playersTurn);
			}
			changeTurn ();
		}

	}

	void pressB ()
	{
		if (Input.GetButtonDown (bButton))  
		{
			di.SelectOption01 ();
			if (A) 
			{
				POCLibrary.AddFireballToList (playersTurn);
			}
			changeTurn ();
		}

	}

	void pressX ()
	{
		if (Input.GetButtonDown (xButton)) 
		{
			di.SelectOption02 ();
			if (A) 
			{
				POCLibrary.AddShieldToList (playersTurn);
			}
			changeTurn ();
		}

	}

	void pressY ()
	{
		if (Input.GetButtonDown (yButton)) 
		{
			di.SelectOption03 ();
			if (A) 
			{
				POCLibrary.AddSingToList (playersTurn);
			}
			changeTurn ();
		}
	}

	void changeTurn ()
	{
		if (playersTurn == 1) 
		{
			playersTurn = 2;
		}

		if (playersTurn == 2) 
		{
			playersTurn = 1;
		}
	}

}