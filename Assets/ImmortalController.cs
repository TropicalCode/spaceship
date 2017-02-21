using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmortalController : MonoBehaviour {

	public GameObject myBullet;
	public GameObject myTurret;
	public GameObject mySpaceship;
	//public AudioClip myExplosion;
	// Use this for initialization
	void Start () {

		StartCoroutine (SpawnBullet (1f));
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

	}

	IEnumerator SpawnBullet(float waitTime) {

		//Instantiate (myBullet, this.gameObject.transform.position, Quaternion.identity);

		//yield return new WaitForSeconds(waitTime);
		//StartCoroutine (SpawnBullet (1f));
		yield return new WaitForSeconds(20f);

		Instantiate (myTurret, this.gameObject.transform.position,Quaternion.identity);
		Instantiate (mySpaceship, this.gameObject.transform.position,Quaternion.identity);
		Destroy (this.gameObject);
	}
}
