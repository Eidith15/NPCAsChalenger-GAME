using UnityEngine;
using System.Collections;

public class Customer : MonoBehaviour {

	public GameObject waypoint;
	int belanja = 0;
	GameObject warung;


		

	void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.name == "TempatKerjaPemain") {
			print ("Kena toko pemain");
			warung = col.gameObject;
			belanja = 1;
			StartCoroutine (Belanja());
		}

		if (col.gameObject.name == "TempatKerjaEnemy") {
			print ("Kena toko enemy");
			warung = col.gameObject;
			belanja = 1;
			StartCoroutine (Belanja());
		}

	}

	IEnumerator Belanja(){
		if (belanja == 1) {
			print ("Testing IENUMERATOR");
			yield return new WaitForSeconds (10f);
			belanja = 2;
		}
	}

	void Move(){
		transform.position = Vector3.MoveTowards (transform.position, waypoint.transform.position, Time.deltaTime * 100f);
	}

	void KeToko(){
		transform.position = Vector3.MoveTowards (transform.position, warung.transform.position, Time.deltaTime * 100f);	
	}

	// Update is called once per frame
	void Update () {
		if (belanja == 1) {
			KeToko ();
		} else {
			Move ();
		}

	}
}
