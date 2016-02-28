using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

	public static int score = 0;
	public static int level = 1;
	public static bool gameover = false;
	public int levelone = 0;
	public int leveltwo = 30;
	public int levelthree = 50;


	public static int GetScore() {
		return score;
	}

	public static void AddScore (int x) {
		score += x;
		if (score < levelone) {
			level = 1;
		}
		if (score > leveltwo) {
			level = 2;
		}
		if (score > levelthree) {
			level = 3;
		}
	}

	public static void ItsGameOver () {
		gameover = true;
	}
}
