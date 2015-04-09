using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpgradeScript : MonoBehaviour {

	ScoreTextScript scoreText;
	Text text;
	Button button; 

	public int upgradeStat;
	int curCost;


	// Use this for initialization
	void Start () {
		scoreText = GameObject.Find ("ScoreText").GetComponent<ScoreTextScript> ();
		text = transform.Find ("costText").GetComponent<Text> ();
		button = GetComponent<Button> ();
		curCost = formula (upgradeStat);
	}
	
	// Update is called once per frame
	void Update () {
		if (scoreText.canAffordUpgrade (curCost)) {
			button.interactable = true;
		} else 
			button.interactable = false;
		text.text = "Cost: " + curCost;
	}

	int formula(int choice){
		int returnValue = 0;
		float factor = scoreText.getStat (upgradeStat);
		
		if (choice == 1)
			returnValue = 100 * (int)Mathf.Pow (2, factor);
		else if (choice == 2) 
			returnValue = 10 * (int) Mathf.Pow(2, factor);
		return returnValue;
	}

	public void upgrade(){
		switch (upgradeStat) {
		case 1: 
			scoreText.upgradeLumberjacks();
			break;
		case 2:
			scoreText.upgradeClicks();
			break;
		}
		scoreText.payForUpgrades (curCost);
		curCost = formula(upgradeStat);
	}
}
