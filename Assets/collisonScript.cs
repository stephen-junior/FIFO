﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col) {
		GameObject explosion = Instantiate (Resources.Load ("FlareMobile", typeof(GameObject))) as GameObject;
		explosion.transform.position = transform.position;

		col.gameObject.GetComponent<EnemyObject>().hp -= 1;

		Debug.Log (col.gameObject.GetComponent<EnemyObject>().hp);

		if (col.gameObject.GetComponent<EnemyObject> ().hp <= 0) {
			Destroy (col.gameObject);
			Destroy (explosion, 1.5f);
		} else {
			Destroy (explosion, 0.5f);
		}

		Destroy (gameObject);
	}
}
