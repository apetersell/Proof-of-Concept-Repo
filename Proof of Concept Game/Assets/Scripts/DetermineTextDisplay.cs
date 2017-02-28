using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetermineTextDisplay : MonoBehaviour {


	public GameObject slot0;
	public GameObject slot1;
	public GameObject slot2;
	public GameObject slot3;
	public Color player1;
	public Color player2;
	public Color introOutro;
	public Color vanished;
	public int aSceneNumber; 
	public GameObject [] aScenes;
	public GameObject currentAScene;
	StringsToDisplay s2d;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		determineScene ();
	}

	void determineScene ()
	{
		currentAScene = aScenes [aSceneNumber]; 
		s2d = currentAScene.GetComponent<StringsToDisplay> ();
	}
}
