using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using UnityEngine.UI; 

public class DialogueVisuals : MonoBehaviour {

	public Sprite ponytailNeutral; 
	public Sprite ponytailAngry;
	public Sprite ponytailEyeRoll;
	public Sprite ponytailHappy;
	public Sprite ponytailKnifeHeart;
	public Sprite ponytailSulk;
	public Sprite pigtailNeutral;
	public Sprite pigtailAngry;
	public Sprite pigtailEyeRoll;
	public Sprite pigtailHappy;
	public Sprite pigtailKnifeHeart; 
	public Sprite pigtailSulk;
	GameObject ponytail; 
	GameObject pigtail; 
	SpriteRenderer ponysr;
	SpriteRenderer pigsr;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

		ponytail = GameObject.Find ("PonyTail");
		ponysr = ponytail.GetComponent<SpriteRenderer> ();
		pigtail = GameObject.Find ("PigTail");
		pigsr = pigtail.GetComponent<SpriteRenderer> ();	
		
	}

	public void changeExpression (int playerNum, string emotion)
	{
		if (playerNum == 1) 
		{
			if (emotion == "Neutral")  
			{
				ponysr.sprite = ponytailNeutral;  
			}

			if (emotion == "Angry") 
			{
				ponysr.sprite = ponytailAngry;
			}

			if (emotion == "EyeRoll") 
			{
				ponysr.sprite = ponytailEyeRoll;  
			}

			if (emotion == "Happy") 
			{
				ponysr.sprite = ponytailHappy; 
			}

			if (emotion == "KnifeHeart") 
			{
				ponysr.sprite = ponytailKnifeHeart; 
			}

			if (emotion == "Sulk") 
			{
				ponysr.sprite = ponytailSulk; 
			}

		}

		if (playerNum == 2) 
		{
			if (emotion == "Neutral") 
			{
				pigsr.sprite = pigtailNeutral;  
			}

			if (emotion == "Angry") 
			{
				pigsr.sprite = pigtailAngry;
			}

			if (emotion == "EyeRoll") 
			{
				pigsr.sprite = pigtailEyeRoll;  
			}

			if (emotion == "Happy") 
			{
				pigsr.sprite = pigtailHappy; 
			}

			if (emotion == "KnifeHeart") 
			{
				pigsr.sprite = pigtailKnifeHeart; 
			}

			if (emotion == "Sulk") 
			{
				pigsr.sprite = pigtailSulk; 
			}

		}
	}

}
