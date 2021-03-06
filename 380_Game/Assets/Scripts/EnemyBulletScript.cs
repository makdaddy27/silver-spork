﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour {
	[SerializeField]
	private int damage = 5;

	void OnBecameInvisible(){
		Destroy(this.gameObject);
	}
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Floor") {
			Destroy (this.gameObject);
		}
		if (collision.gameObject.tag == "Wall") {
			Destroy (this.gameObject);
		}
		if (collision.gameObject.tag == "Player") {
			Destroy (this.gameObject);
			collision.gameObject.SendMessage ("applyDamage", damage);
		}
		if (collision.gameObject.tag == "Bullet")
			Destroy (this.gameObject);
	}
}