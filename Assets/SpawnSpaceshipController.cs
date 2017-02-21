using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpaceshipController : MonoBehaviour {
	public GameObject mySpaceship;
	public GameObject myTurret;
	public AudioClip myExplosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			Instantiate (mySpaceship, this.gameObject.transform.position,Quaternion.identity);
		}
	}
}
