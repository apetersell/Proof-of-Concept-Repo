using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using UnityEngine.UI; 

public class DialogueVisuals : MonoBehaviour {

	public Color p1Color;
	public Color p2Color;
	public Color neutral;
	public Color currentColor; 
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
	public GameObject aOption;
	public GameObject bOption;
	public GameObject xOption;
	public GameObject yOption;
	public GameObject tail;
	Image aImg;
	Image bImg;
	Image xImg;
	Image yImg;
	Image tbImg;
	Image tailImg;

	// Use this for initialization
	void Start () {

			currentColor = p2Color;
		
	}
	
	// Update is called once per frame
	void Update () {

		ponytail = GameObject.Find ("PonyTail");
		ponysr = ponytail.GetComponent<SpriteRenderer> ();
		pigtail = GameObject.Find ("PigTail");
		pigsr = pigtail.GetComponent<SpriteRenderer> ();
		aOption = GameObject.Find ("A Option");
		aImg = aOption.GetComponent<Image> ();
		bOption = GameObject.Find ("B Option");
		bImg = bOption.GetComponent<Image> ();
		xOption = GameObject.Find ("X Option");
		xImg = xOption.GetComponent<Image> ();
		yOption = GameObject.Find ("Y Option");
		yImg = yOption.GetComponent<Image> ();
		tbImg = GetComponent<Image> ();
		tail = GameObject.Find ("Bubble");
		tailImg = tail.GetComponent<Image> ();


		aImg.color = currentColor; 
		bImg.color = currentColor;
		xImg.color = currentColor;
		yImg.color = currentColor;
		tbImg.color = currentColor;
		tbImg.color = currentColor;
		tailImg.color = currentColor; 
		
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

	public void changeColor (int playerNum)
	{
		if (playerNum == 1) 
		{
			currentColor = p1Color;
		} 

		if (playerNum == 2) 
		{
			currentColor = p2Color;
		}
	}
}
