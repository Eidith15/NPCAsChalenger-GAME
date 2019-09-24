using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NPC : MonoBehaviour {
	float r = 0;
	int coin = 0;
	bool enemyFarm = false;
	bool enemyEmper = false;
	public static bool enemyGerai = false;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("EnemyMoney",1,.2f);
	}

	void Update(){
		Beli ();
	}

	void EnemyMoney(){
		r = Random.Range (1, 100);
		if (r < 50) 
			coin++;
		if (r > 51)
		if (r == 89)
			coin += 15;
		GameObject.Find ("TextEnemy").GetComponent<Text> ().text = coin.ToString ();
	}


	void Beli(){
		if (!enemyFarm) {
			if(coin > 10){
				GameObject.Find ("TempatKerjaEnemy").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("crops");
				this.enemyFarm = true;
				coin -= 10;	
			}
		}
		if (enemyFarm) {
			if (!enemyEmper) {
				if(coin > 50){
					GameObject.Find ("TempatKerjaEnemy").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("fish");
					this.enemyEmper = true;
					coin -= 50;	
				}
			}
		}

		if (enemyEmper) {
			if(coin > 100){
				GameObject.Find ("TempatKerjaEnemy").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("fruit");
				enemyGerai = true;
				coin -= 100;	
			}
		}
	}
}
