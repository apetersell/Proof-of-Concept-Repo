﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : Ability {

	protected float baseKnockback;
	protected float knockbackGrowth;
	protected int damage;
	public bool hitPlayer1;
	public bool hitPlayer2;
	public bool isProjectile;

	// Use this for initialization
	void Start () {
		hitPlayer1 = false;
		hitPlayer2 = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	protected virtual void HitPlayer(GameObject player){
        if(player.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerController>().TakeHit(damage, baseKnockback, knockbackGrowth, GetDirectionHit(player));
        }
        if(player.gameObject.tag == "OtherStudent")
        {
            player.GetComponent<SpawnedStudentScript>().TakeHit(damage, baseKnockback, knockbackGrowth, GetDirectionHit(player));
        }

	}

	protected virtual Vector3 GetDirectionHit (GameObject playerHit){
		return Vector3.zero;
	}

	void OnTriggerStay2D(Collider2D collider){
		GameObject collidedObject = collider.gameObject;
		if (collidedObject.tag == "Player") {
			PlayerController pc = collidedObject.GetComponent<PlayerController> ();
			if (pc.playerNum != parentPlayer.GetComponent<PlayerController>().playerNum){
				if ((pc.playerNum == 1) && !hitPlayer1) {
					hitPlayer1 = true;
					if (!pc.isInvulnerable){
						HitPlayer (collidedObject);
					}
				}
				else if ((pc.playerNum == 2) && !hitPlayer2) {
					hitPlayer2 = true;
					if (!pc.isInvulnerable){
						HitPlayer (collidedObject);
					}
				}

			}
		}
        if(collidedObject.tag == "OtherStudent")
        {
            SpawnedStudentScript ss = collidedObject.GetComponent<SpawnedStudentScript>();
            HitPlayer(collidedObject);
        }
	}
}
