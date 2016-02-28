using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public static bool gameOver = false;

	public static int score = 0;
	public static int level = 1;
	public static int ghostCount = 0;

	// Score thresholds for each level.
	public static int l1 = 0;
	public static int l2 = 30;
	public static int l3 = 50;

	public static int GetScore ()
	{
		return score;
	}

	public static int getGhostCount ()
	{
		return ghostCount;
	}

	public static void AddScore (int x)
	{
		score += x;
		if (score >= l2) {
			level = 2;
		}
		if (score >= l3) {
			level = 3;
		}
	}

	public static void endGame ()
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
