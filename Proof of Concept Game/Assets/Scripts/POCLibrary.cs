using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POCLibrary : MonoBehaviour {


	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void AddShieldToList(int playerNum)
	{
		GameObject gameInfo = GameObject.Find ("GameInfo");
		GameInfo gi = gameInfo.GetComponent<GameInfo> ();
		if (playerNum == 1) 
		{
			gi.player1Abilities.Add (Ability.Type.Shield);
		}

		if (playerNum == 2) 
		{
			gi.player2Abilities.Add (Ability.Type.Shield);
		}

	}

	public static void AddLungeToList(int playerNum)
	{
		GameObject gameInfo = GameObject.Find ("GameInfo");
		GameInfo gi = gameInfo.GetComponent<GameInfo> ();
		if (playerNum == 1) 
		{
			gi.player1Abilities.Add (Ability.Type.Lunge); 
		}

		if (playerNum == 2) 
		{
			gi.player2Abilities.Add (Ability.Type.Lunge);
		}

	}

	public static void AddFireballToList(int playerNum)
	{	
		GameObject gameInfo = GameObject.Find ("GameInfo");
		GameInfo gi = gameInfo.GetComponent<GameInfo> ();
		if (playerNum == 1) 
		{
			gi.player1Abilities.Add(Ability.Type.Fireball);
		}

		if (playerNum == 2) 
		{
			gi.player2Abilities.Add (Ability.Type.Fireball);
		}

	}

	public static void AddSingToList(int playerNum)
	{
		GameObject gameInfo = GameObject.Find ("GameInfo");
		GameInfo gi = gameInfo.GetComponent<GameInfo> ();
		if (playerNum == 1) 
		{
			gi.player1Abilities.Add (Ability.Type.Sing);
		}

		if (playerNum == 2) 
		{
			gi.player2Abilities.Add (Ability.Type.Sing);
		}

	}
}
