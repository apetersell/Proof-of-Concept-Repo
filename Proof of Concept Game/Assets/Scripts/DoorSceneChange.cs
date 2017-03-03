using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Who won?!");
        if (other.GetComponent<PlayerController>().playerNum == 1)
        {
            Debug.Log("Player1 Won!");
            SceneManager.LoadScene("A2 Stage");
        }

        if (other.GetComponent<PlayerController>().playerNum == 2)
        {
            Debug.Log("Player2 Won!");
            SceneManager.LoadScene("A2Prime Stage");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
