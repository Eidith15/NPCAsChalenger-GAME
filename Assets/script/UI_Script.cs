using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI_Script : MonoBehaviour {

	public static int coin;

	// Use this for initialization
	void Start () {
		coin = 0;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.Find ("TextMoney").GetComponent<Text> ().text = coin.ToString ();	
	}

	public void addCoin(){
		coin++;
	}

	public void beli(int i){
		switch (i) {
			case 1:
				GameObject.Find ("TempatKerjaPemain").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("crops");
				GM.checkFarm = true;
				UI_Script.coin -= 10;
				break;
			case 2:
				GameObject.Find ("TempatKerjaPemain").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("fish");
				GM.checkEmper = true;
				UI_Script.coin -= 50;
				break;
			case 3:
				GameObject.Find ("TempatKerjaPemain").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("fruit");
				GM.checkGerai = true;
				UI_Script.coin -= 100;
				break;
			default:
				break;
		}
	}

}
