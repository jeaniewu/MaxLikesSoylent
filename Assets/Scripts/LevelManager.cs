using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public int score;
	public int ghostCount;
	public int kills;

	void Start ()
	{
		ghostCount = 3;
		kills = 0;
		GetComponent<GhostManager> ().GenerateGhosts (ghostCount);
	}

	public int getGhostCount ()
	{
		return ghostCount;
	}

	public void incKills ()
	{
		kills++;
	}

	void Update ()
	{
		if (kills >= ghostCount) {
			ghostCount++;
			kills = 0;
			GetComponent<GhostManager> ().GenerateGhosts (ghostCount);
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
