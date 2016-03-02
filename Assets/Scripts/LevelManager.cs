using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public bool gameOver;

	public int score;
	public int ghostCount;
	public int kills;

	void Start(){
		gameOver = false;
		ghostCount = 3;
		kills = 0;
		GetComponent<GhostManager> ().generateGhosts (ghostCount);
	}

	public int getGhostCount ()
	{
		return ghostCount;
	}

	public void incKills () {
		kills++;
	}
		
	public void endGame ()
	{
		gameOver = true;
	}

	void Update ()
	{
		if (kills >= ghostCount) {
			ghostCount++;
			kills = 0;
			GetComponent<GhostManager> ().generateGhosts (ghostCount);
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
