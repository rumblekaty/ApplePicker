using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //for uGUI to work

public class HighScore : MonoBehaviour {

	static public int score = 1000;

	void Awake() {
		if (PlayerPrefs.HasKey("HighScore")){
			score = PlayerPrefs.GetInt ("HighScore");
		}

		PlayerPrefs.SetInt ("HighScore", score);
	}

	
	// Update is called once per frame
	void Update () {
		Text gt = this.GetComponent<Text> ();
		gt.text = "High Score: " + score;

		if(score > PlayerPrefs.GetInt("HighScore")){
			PlayerPrefs.SetInt ("HighScore", score);
		}
		
	}
}
