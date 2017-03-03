using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStageInputs: MonoBehaviour {

	public int playersTurn = 1; 
	public int lastPlayersTurn;
	private string aButton;
	private string bButton;
	private string xButton;
	private string yButton;
	public static bool A = true; 
	public static bool A2;  
	public static bool A2Prime;  
	public static bool canSelect; 
	DialogueImplementation di;
	GameObject gameInfo; 
	GameObject textbox;
	GameInfo gi;
	DialogueVisuals dv;

	// Use this for initialization
	void Start () {

		di = GetComponent<DialogueImplementation> (); 
		gameInfo = GameObject.Find ("GameInfo");
		gi = gameInfo.GetComponent<GameInfo> ();
		textbox = GameObject.Find ("TextBox");
		dv = textbox.GetComponent<DialogueVisuals> ();
		
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
		if (playersTurn < 3) {
			aButton = "A Button_P" + playersTurn;
			bButton = "B Button_P" + playersTurn;
			xButton = "X Button_P" + playersTurn;
			yButton = "Y Button_P" + playersTurn;
		} else 
		{
			aButton = "A Button_P" + lastPlayersTurn;
			bButton = "B Button_P" + lastPlayersTurn;
			xButton = "X Button_P" + lastPlayersTurn;
			yButton = "Y Button_P" + lastPlayersTurn;
		}
	}

	void pressA ()
	{
		if (Input.GetButtonDown (aButton)) 
		{
			if (A) {
				if (gi.takenAbilities.Count < 2) {
					if (!gi.takenAbilities.Contains (Ability.Type.Lunge)) {
						di.SelectOption00 ();
						{
							POCLibrary.AddLungeToList (playersTurn);
							ColorChanger.changeColor (playersTurn);
						}
					}

					if (playersTurn == 1) {
						dv.changeExpression (1, "Happy");
						dv.changeExpression (2, "Angry");
					}

					if (playersTurn == 2) {
						if (gi.takenAbilities.Contains (Ability.Type.Fireball)) {
							dv.changeExpression (1, "Angry");
							dv.changeExpression (2, "KnifeHeart");
						}

						if (gi.takenAbilities.Contains (Ability.Type.Shield)) {
							dv.changeExpression (1, "EyeRoll");
							dv.changeExpression (2, "Happy");
						}

						if (gi.takenAbilities.Contains (Ability.Type.Sing)) {
							dv.changeExpression (1, "Sulk");
							dv.changeExpression (2, "Happy");
						}
					}
				} 
				else 
				{
					di.SelectOption00 ();
					ColorChanger.changeColor (playersTurn);
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
						ColorChanger.changeColor (playersTurn);
					}
				}

				if (playersTurn == 1) 
				{
					dv.changeExpression (1, "KnifeHeart");
					dv.changeExpression (2, "Sulk");
				}

				if (playersTurn == 2) 
				{
					if (gi.takenAbilities.Contains (Ability.Type.Lunge)) 
					{
						dv.changeExpression (1, "Angry");
						dv.changeExpression (2, "KnifeHeart");
					}

					if (gi.takenAbilities.Contains (Ability.Type.Shield)) 
					{
						dv.changeExpression (1, "EyeRoll");
						dv.changeExpression (2, "Happy");
					}

					if (gi.takenAbilities.Contains (Ability.Type.Sing)) 
					{
						dv.changeExpression (1, "Sulk");
						dv.changeExpression (2, "Happy");
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
						ColorChanger.changeColor (playersTurn);
					}
				}

				if (playersTurn == 1) 
				{
					dv.changeExpression (1, "EyeRoll");
					dv.changeExpression (2, "Angry");
				}

				if (playersTurn == 2) 
				{
					if (gi.takenAbilities.Contains (Ability.Type.Lunge)) 
					{
						dv.changeExpression (1, "Angry");
						dv.changeExpression (2, "KnifeHeart");
					}

					if (gi.takenAbilities.Contains (Ability.Type.Fireball)) 
					{
						dv.changeExpression (1, "EyeRoll");
						dv.changeExpression (2, "Happy");
					}

					if (gi.takenAbilities.Contains (Ability.Type.Sing)) 
					{
						dv.changeExpression (1, "Sulk");
						dv.changeExpression (2, "Happy");
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
						ColorChanger.changeColor (playersTurn);
					}
				}

				if (playersTurn == 1) 
				{
					dv.changeExpression (1, "KnifeHeart");
					dv.changeExpression (2, "EyeRoll");
				}

				if (playersTurn == 2) 
				{
					if (gi.takenAbilities.Contains (Ability.Type.Lunge)) 
					{
						dv.changeExpression (1, "Angry");
						dv.changeExpression (2, "KnifeHeart");
					}

					if (gi.takenAbilities.Contains (Ability.Type.Fireball)) 
					{
						dv.changeExpression (1, "EyeRoll");
						dv.changeExpression (2, "Happy");
					}

					if (gi.takenAbilities.Contains (Ability.Type.Shield)) 
					{
						dv.changeExpression (1, "Sulk");
						dv.changeExpression (2, "Happy");
					}
				}
			}
		}
	}

	void changeTurn ()
	{
		if (A) 
		{
			if (playersTurn == 1 && gi.player1Abilities.Count > 0) 
			{
				playersTurn = 2;
			}

			if (playersTurn == 2 && gi.takenAbilities.Count == 2)
			{
				playersTurn = 3;
				lastPlayersTurn = 2;
			}
		}
	}

	void limitSelect ()
	{
		if (di.optionButtons [0].activeSelf == false) 
		{
			canSelect = false;
		}

		if (di.optionButtons [0].activeSelf == true) 
		{
			canSelect = true;
		}
	}

}