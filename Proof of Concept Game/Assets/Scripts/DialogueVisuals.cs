using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialogueVisuals : MonoBehaviour {

	public Color p1Color;
	public Color p2Color;
	public Color neutral;
	public Sprite ponytailNeutral; 
	public Sprite ponytailAngry;
	public Sprite pontyailEyeRoll;
	public Sprite ponytailHappy;
	public Sprite ponytailKnifeHeart;
	public Sprite ponytailSulk;
	public Sprite pigtailNeutral;
	public Sprite pigtailAngry;
	public Sprite pigtailEyeRoll;
	public Sprite pigtailHappy;
	public Sprite pigtailKnifeHeart; 
	public Sprite pigtailSulk;
	public GameObject ponytail; 
	public GameObject pigTail; 
	SpriteRenderer ponysr;
	SpriteRenderer pigsr; 
	// Use this for initialization
	void Start () {

		ponysr = ponytail.GetComponent<SpriteRenderer> ();
		pigsr = pigTail.GetComponent<SpriteRenderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void changeExpression (int playerNum, string emotion)
	{
		if (playerNum == 1) 
		{
			if (emotion == "Neutral") 
			{

			}

			if (emotion == "Angry") 
			{

			}

			if (emotion == "EyeRoll") 
			{

			}

			if (emotion == "Happy") 
			{

			}

			if (emotion == "KnifeHeart") 
			{

			}

			if (emotion == "Sulk") 
			{

			}

		}
	}
}
