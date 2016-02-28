using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public bool gameOver;

	public int score;
	public int ghostCount;

	// Score thresholds for each level.
	public static int l1 = 0;
	public static int l2 = 30;
	public static int l3 = 50;


	void Start(){
		gameOver = false;
		score = 0;
		ghostCount = 1;
	}

	public int GetScore ()
	{
		return score;
	}

	public int getGhostCount ()
	{
		return ghostCount;
	}

	public void AddScore (int x)
	{
		score += x;
		if (score >= l2) {
			ghostCount = 2;

		}
		if (score >= l3) {
			ghostCount = 3;
		}
	}

	public void endGame ()
	{
		gameOver = true;
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
