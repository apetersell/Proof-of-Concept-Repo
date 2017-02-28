using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateText : MonoBehaviour {

	public int playersTurn;
	private string aButton;
	private string bButton;
	private string xButton;
	private string yButton;
	public KeyCode testButton;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		turnControls ();
		test ();
	}

	void turnControls ()
	{
		aButton = "A Button_P" + playersTurn;
		bButton = "B Button_P" + playersTurn;
		xButton = "X Button_P" + playersTurn;
		yButton = "Y Button_P" + playersTurn;
	}

	void test ()
	{
		if (Input.GetButtonDown (aButton))
		{
			Debug.Log ("A Button, Player" + playersTurn);
		}

		if (Input.GetButtonDown (bButton))
		{
			Debug.Log ("B Button, Player" + playersTurn);
		}

		if (Input.GetButtonDown (xButton))
		{
			Debug.Log ("X Button, Player" + playersTurn);
		}

		if (Input.GetButtonDown (yButton))
		{
			Debug.Log ("Y Button, Player" + playersTurn);
		}
	}
}
