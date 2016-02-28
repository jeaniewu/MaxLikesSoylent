using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard : MonoBehaviour
{
	Text textYourScore;

	void Start ()
	{
		textYourScore = GetComponent<Text> ();
		textYourScore.text = "Your Score: " + (LevelManager.GetScore ().ToString ());
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.Return)) {
			SceneManager.LoadScene ("Main");
		}
	}
}
