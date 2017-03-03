using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayRunManager : MonoBehaviour {

    public float speed;
    GameObject[] players;
    public float downVelocity;

	// Use this for initialization
	void Start () {

        players = GameObject.FindGameObjectsWithTag("Player");	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "OtherStudent")
        {
            //Debug.Log("Is Touching");
            other.GetComponent<Rigidbody2D>().velocity = new Vector3(0, downVelocity, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
    }
	
	// Update is called once per frame
	void Update () {

        //Camera.main.transform.Translate(Vector3.up * speed * Time.deltaTime);

        Vector3 playerMidpoint = ((players[1].transform.position - players[0].transform.position) * 0.5f) + players[0].transform.position;
        playerMidpoint.z = -10f;
        Camera.main.transform.position = playerMidpoint;
        Camera.main.orthographicSize = Vector3.Distance(players[0].transform.position, players[1].transform.position);
        if(Camera.main.orthographicSize < 2)
        {
            Camera.main.orthographicSize = 2;
        }
        //Debug.Log("Distance Between Players is equal to " + Vector3.Distance(players[0].transform.position, players[1].transform.position));
    }
}
