using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour {

	public GameObject myBullet;
	public GameObject myTurret;
	public AudioClip myExplosion;
	public GameObject myImmortal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis ("Horizontal")!=0) {
			//Debug.Log (Input.GetAxis ("Horizontal"));
			gameObject.transform.Translate (Input.GetAxis ("Horizontal") * Vector3.right * Time.deltaTime * 5f);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (myBullet, this.gameObject.transform.position,Quaternion.identity);
		}

		if (Input.GetKeyDown (KeyCode.V)) {
			Instantiate (myTurret, this.gameObject.transform.position,Quaternion.identity);
		}

		if (Input.GetKeyDown (KeyCode.I)) {
			Instantiate (myImmortal, this.gameObject.transform.position,Quaternion.identity);
			Destroy (this.gameObject);
		}

	}
}
