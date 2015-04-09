using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreTextScript : MonoBehaviour {

	Text text;
	int clicks = 0;
	float lumberjackFactor = 1;
	float clickFactor = 1;
	float t = 0;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime;
		if (t >= 1 / lumberjackFactor) {
			clicks += (int) clickFactor;
			t = 0;
		}
		text.text = "Score: " + clicks;
	}

	public void gainPoint(){
		clicks += (int) clickFactor;
	}

	public void payForUpgrades(int cost){
		if (cost > 0) {
			clicks -= cost;
		}
	}

	public void upgradeLumberjacks(){
		lumberjackFactor++;
	}

	public bool canAffordUpgrade(int cost){
		return clicks >= cost;
	}

	public void upgradeClicks(){
		clickFactor++;
	}

	public float getStat(int choice){
		if (choice == 1) {
			return lumberjackFactor;
		} else if (choice == 2) {
			return clickFactor;
		}
		return 0;
	}
}
