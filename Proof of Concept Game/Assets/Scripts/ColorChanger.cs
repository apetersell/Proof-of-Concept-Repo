using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour {

	Image img;
	RectTransform rt;
	GameObject textbox;
	public Color p1Color;
	public Color p2Color;
	public Color neutral;
	public Color currentColor; 
	public Vector3 p1ArrowPos; 
	public Vector3 p2ArrowPos; 
	public static int colorNum;
	public bool flipOnSwitch; 
	public bool choiceButtons; 
	GameInfo gi;
	GameObject gameInfo; 

	// Use this for initialization
	void Start () {

		gameInfo = GameObject.Find ("GameInfo"); 
		gi = gameInfo.GetComponent<GameInfo> (); 

		img = GetComponent<Image> ();
		rt = GetComponent<RectTransform> ();

		if (AStageInputs.A) 
		{
			colorNum = 2;
		}
			
	}
	
	// Update is called once per frame
	void Update () {

		arrowDeets ();

		img.color = currentColor;
		if (colorNum == 3)
			{
				currentColor = neutral; 
			}

		if (choiceButtons == true) {
			if (AStageInputs.A) 
			{

				if (colorNum == 1) {
					currentColor = p2Color;
				}

				if (colorNum == 2) {
					currentColor = p1Color;
				}

				if (colorNum == 2 && gi.takenAbilities.Count == 2) 
				{
					currentColor = p2Color; 
				}
			}
				
				
		}

		if (choiceButtons == false) 
		{
			if (colorNum == 1) 
			{
				currentColor = p1Color;
			}
			if (colorNum == 2) 
			{
				currentColor = p2Color;
			}
		}
		
	}

	public static void changeColor (int playerNum)
	{
		colorNum = playerNum; 
	}


	void arrowDeets ()
	{
		if (flipOnSwitch == true) 
		{
			SpriteRenderer sr = GetComponent<SpriteRenderer> ();

			if (colorNum == 1) 
			{
				transform.position = p1ArrowPos;
				sr.color = p1Color; 
				sr.flipX = false;
			}

			if (colorNum == 2) 
			{
				transform.position = p2ArrowPos;
				sr.color = p2Color;
				sr.flipX = true;
			}

			if (colorNum == 3) 
			{
				sr.color = new Color (0, 0, 0, 0);
			}
		}

	}

}
