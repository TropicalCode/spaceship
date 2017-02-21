using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour {

	// Use this for initialization
	public GameObject myBullet;
	public AudioClip myExplosion;
	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnBullet (1f));
	}

	// Update is called once per frame
	void Update () {
		//Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);
	}

	IEnumerator SpawnBullet(float waitTime) {

		Instantiate (myBullet, this.gameObject.transform.position, Quaternion.identity);

		yield return new WaitForSeconds(waitTime);
		StartCoroutine (SpawnBullet (1f));
		yield return new WaitForSeconds(10f);
		Destroy (this.gameObject);
	}

}
