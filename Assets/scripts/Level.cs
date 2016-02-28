using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

	public int score;
	public bool gameover = false;

	// Use this for initialization
	void Start () {
		//initialize random generate ghost
		//initialize score
		//initialize level
	}

	// Update is called once per frame
	void Update () {

		//if score is howmany, increase level
		//generate more ghosts according to the level
		//if gameover, change scene

	}

	void AddScore (int x) {
		score += x;
	}

	void ItsGameOver () {
		gameover = true;
	}
}
