using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject[] customer;
	public GameObject[] waypoint;

	public int count=3;
	int sc;
	public float delay = 3;
	bool spawn = true;	
	// Use this for initialization	
	void Start () {		
		sc = 0;		
		StartCoroutine (Spawn());	
	}	

	IEnumerator Spawn() {		
		while(spawn){
			sc++;			
			yield return new WaitForSeconds(delay);			
			GameObject go = Instantiate (customer[Random.Range(0,customer.Length-1)]) as GameObject;
			go.transform.parent = transform;
			go.GetComponent<Customer> ().waypoint = waypoint [Random.Range (0, waypoint.Length - 1)];
			go.transform.position = transform.position;			
			if (sc >= count)				
				spawn = false;		
		}	
	}
}
