using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
{
	Text scoreboard;

	void Start ()
	{
		scoreboard = GetComponent<Text> ();
	}

	void Update ()
	{
		scoreboard.text = "Your Score: " + ScoreManager.GetScore ().ToString () + "\n";
		scoreboard.text += "High Score: " + ScoreManager.GetHighScore ().ToString ();

		if (Input.GetKey (KeyCode.F)) {
			SceneManager.LoadScene ("Main");
			ScoreManager.ResetScore ();
		}
	}
}
