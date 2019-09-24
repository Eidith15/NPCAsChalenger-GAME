using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GM : MonoBehaviour {

	public GameObject farm, emper, gerai;

	public static bool checkFarm = false;
	public static bool checkEmper = false;
	public static bool checkGerai = false;

	// Use this for initialization
	void Start () {
	
	}

	void check(){
		if (UI_Script.coin > 10)
			farm.SetActive (true);

		if (UI_Script.coin > 50) {
			if (checkFarm)
				emper.SetActive (true);
		}

		if (UI_Script.coin > 100) {
			if (checkEmper)
				gerai.SetActive (true);
		}
	}

	// Update is called once per frame
	void Update () {
		check ();
		Winner ();
	}

	void Winner(){
		if (checkGerai) {
			GameObject.Find("TextWinner").GetComponent<Text>().text = "Pemain Menang";
			Time.timeScale = 0;
		}

		if(NPC.enemyGerai){
			GameObject.Find ("TextWinner").GetComponent<Text> ().text = "Musuh Menang";
			Time.timeScale = 0;
		}
	}
}
