﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.down * Time.deltaTime * 10f);
		if (this.gameObject.transform.position.y <= -15f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
	}
}
