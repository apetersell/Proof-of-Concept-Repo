﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lunge : Attack {

	private float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void Init(GameObject player){
		animTrigger = "Lunge";
		cooldown = 1f;
		castDuration = 0.2f;
		baseKnockback = 8;
		knockbackGrowth = 1;
		damage = 2;
		speed = 20;
		isProjectile = false;
		onCastAudio = Resources.Load ("Sounds/Abilities/Lunge") as AudioClip;

		base.Init (player);
		GetComponent<FixedJoint2D> ().connectedBody = player.GetComponent<Rigidbody2D> ();

		float direction = -1 * Mathf.Sign (player.transform.localScale.x);
		player.GetComponent<Rigidbody2D>().velocity = direction * speed * Vector3.right;

		Destroy (gameObject, castDuration);
	}

	protected override Vector3 GetDirectionHit(GameObject playerHit){
		return (playerHit.transform.position - parentPlayer.transform.position).normalized;
	}
}
