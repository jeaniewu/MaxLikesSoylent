using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ghost : MonoBehaviour
{
	public Transform player;

	public bool staredAt = false;
	public bool isMoving;
	public int moveSpeed = 4;


	public int farRange = 5;
	public int farScore = 1;
	public int mediumRange = 3;
	public int mediumScore = 5;
	public int closeRange = 1;
	public int closeScore = 10;

	public GameObject gameManager;

	void Start ()
	{
		player = GameObject.FindWithTag ("Player").transform;
		gameManager = GameObject.FindWithTag ("GameManager");

		if (gameManager.GetComponent<LevelManager> ().getGhostCount () % 2 == 0) {
			moveSpeed+=2;
		}
		// Face the player and rotate 180 degrees because the model is fucked up. 
		transform.LookAt (player);
		transform.rotation *= Quaternion.Euler (0, 180f, 0);

		isMoving = true;
	}

	void Update ()
	{
		// Keep moving towards the player when not being looked at.
		// Done by decrementing the position because the model is fucked up.
		if (!staredAt && isMoving) {
			transform.position -= transform.forward * moveSpeed * Time.deltaTime;
		}
	}

	void OnBecameVisible ()
	{
		staredAt = true;
	}

	void OnBecameInvisible ()
	{
		staredAt = false;
	}

	void OnTriggerEnter (Collider other)
	{
		// Scare the player on collide.
		if (other.gameObject.tag == "Player") {
			JumpScare ();
		}
	}

	void JumpScare ()
	{
		// Jump right in front of the player.
		transform.position = player.position + player.forward;

		// Reorientate to face the player again. 
		transform.LookAt (player.position);
		transform.rotation *= Quaternion.Euler (0, 180f, 0);

		// Stay in front of the player.
		isMoving = false;

		Invoke ("gameOver", 2f);
	}


	void gameOver(){
		SceneManager.LoadScene ("Finish");
	}


	//	void Death ()
	//	{
	//		float distanceFromPlayer = Vector3.Distance (transform.position, player.position);
	//
	//		if (distanceFromPlayer > farRange) {
	//			Destroy (gameObject);
	//		}
	//			
	//		if ((distanceFromPlayer < farRange) && (distanceFromPlayer > mediumRange)) {
	//			Level.AddScore (farScore);
	//			Destroy (gameObject);
	//		}
	//
	//		if ((distanceFromPlayer < mediumRange) && (distanceFromPlayer > closeRange)) {
	//			Level.AddScore (mediumScore);
	//			Destroy (gameObject);
	//		}
	//
	//		if (distanceFromPlayer < closeRange) {
	//			Level.AddScore (closeScore);
	//			Destroy (gameObject);
	//		}
	//	}
}
