using UnityEngine;
using System.Collections;

public class ClickDetectionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		print ("Detects keydown");
		GameObject.Find ("ScoreText").GetComponent<ScoreTextScript> ().gainPoint ();
	}
}
