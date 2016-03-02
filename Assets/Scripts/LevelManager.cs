using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public bool gameOver;

	public int score;
	public int ghostCount;
	public int kills;

	// Score thresholds for each level.
	public static int l1 = 0;
	public static int l2 = 30;
	public static int l3 = 50;


	void Start(){
		gameOver = false;
		score = 0;
		ghostCount = 1;
		kills = 0;
		GetComponent<GhostManager> ().generateGhosts (ghostCount);
	}

	public int GetScore ()
	{
		return score;
	}

	public int getGhostCount ()
	{
		return ghostCount;
	}

	public void incKills () {
		kills++;
	}

	public void addScore (int x)
	{
		score += x;
//		if (score >= l2) {
//			ghostCount = 2;
//
//		}
//		if (score >= l3) {
//			ghostCount = 3;
//		}
	}

	public void endGame ()
	{
		gameOver = true;
	}

	void Update ()
	{
		if (kills == ghostCount) {
			ghostCount++;
			kills = 0;
			GetComponent<GhostManager> ().generateGhosts (ghostCount);
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
