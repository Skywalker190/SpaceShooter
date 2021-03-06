﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
	public float health = 150;

	void OnTriggerEnter2D (Collider2D collider){
		Projectile missle = collider.gameObject.GetComponent<Projectile> ();
		if (missle) {
			health -= missle.GetDamage ();
			missle.Hit ();
			if (health <= 0) {
				Destroy (gameObject);
			}

		}
	}
}
