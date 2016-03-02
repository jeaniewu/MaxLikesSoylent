using UnityEngine;
using System.Collections;

public class Global {

	private static int highScore;
	private static int score;

	public static void UpdateHighScore () {
		if (score > highScore) {
			highScore = score;
		}
	}

	public static void AddScore (int x) {
		score += x;
	}

	public static void ResetScore() {
		score = 0;
	}

	public static int GetHighScore() {
		return highScore;
	}

	public static int GetScore() {
		return score;
	}
}
