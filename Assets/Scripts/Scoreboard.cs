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
		scoreboard.text = "Your Score: " + GetComponentInParent<LevelManager> ().GetScore ().ToString ();
	}

	void Update ()
	{
//		if (Input.GetKey (KeyCode.Return)) {
//			SceneManager.LoadScene ("Main");
//		}
	}
}
