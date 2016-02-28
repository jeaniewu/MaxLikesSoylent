using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ongoingUI : MonoBehaviour {

	Text textYourScore;
	int currentScore;

	void Start ()
	{
		textYourScore = GetComponent<Text> ();
		currentScore = 0;
		textYourScore.text = "Your Score: " + GetComponent<LevelManager>().GetScore ().ToString ();
		//GUI.Label (textArea, "Current Score :" + currentScore.ToString());

	}

	void Update ()
	{
		

		if ((GetComponent<LevelManager> ().GetScore ()) != currentScore) {
			currentScore = GetComponent<LevelManager> ().GetScore ();
			textYourScore.text = "Your Score: " + currentScore.ToString ();
		}
	}
}
