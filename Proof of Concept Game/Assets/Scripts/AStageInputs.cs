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
	public bool canSelect; 
	DialogueImplementation di;
	GameObject gameInfo; 
	GameInfo gi;

	// Use this for initialization
	void Start () {

		di = GetComponent<DialogueImplementation> (); 
		gameInfo = GameObject.Find ("GameInfo");
		gi = gameInfo.GetComponent<GameInfo> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		turnControls ();

		if (canSelect == true) 
		{
			pressA ();
			pressB ();
			pressX ();
			pressY (); 
		}
		changeTurn ();
		limitSelect ();

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
			if (A) 
			{
				if (!gi.takenAbilities.Contains (Ability.Type.Lunge)) 
				{
					di.SelectOption00 ();
					{
						POCLibrary.AddLungeToList (playersTurn);  
					}
				}
			}
		}
	}

	void pressB ()
	{
		if (Input.GetButtonDown (bButton)) 
		{
			if (A) 
			{
				if (!gi.takenAbilities.Contains (Ability.Type.Fireball)) 
				{
					di.SelectOption01 ();
					{
						POCLibrary.AddFireballToList (playersTurn);  
					}
				}
			}
		}
	}

	void pressX ()
	{
		if (Input.GetButtonDown (xButton)) 
		{
			if (A) 
			{
				if (!gi.takenAbilities.Contains (Ability.Type.Shield)) 
				{
					di.SelectOption02 ();
					{
						POCLibrary.AddShieldToList (playersTurn);  
					}
				}
			}
		}
	}

	void pressY ()
	{
		if (Input.GetButtonDown (yButton)) 
		{
			if (A) 
			{
				if (!gi.takenAbilities.Contains (Ability.Type.Sing)) 
				{
					di.SelectOption03 ();
					{
						POCLibrary.AddSingToList (playersTurn);  
					}
				}
			}
		}
	}

	void changeTurn ()
	{
		if (playersTurn == 1 && gi.player1Abilities.Count > 0) 
		{
			playersTurn = 2;
		}
	}

	void limitSelect ()
	{
		if (di.optionButtons [1].activeSelf == false) 
		{
			canSelect = false;
		}

		if (di.optionButtons [1].activeSelf == true) 
		{
			canSelect = true;
		}
	}

}