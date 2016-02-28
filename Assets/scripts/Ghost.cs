using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ghost : MonoBehaviour {

	// Use this for initialization

	//var target : Transform; 

	public GameObject target;
	public Transform targetTransform;
	public int movespeed = 2;
	public int rotationspeed = 2;
	public bool staredAt = true;
	public int farRange = 5;
	public int farScore = 1;
	public int mediumRange = 3;
	public int mediumScore = 5;
	public int closeRange = 1;
	public int closeScore = 10;

	void Start () {
		//initialized x distance from camera(in level manager script);
		//detect main camera (player), update direction.

		target = GameObject.FindWithTag ("Player");
		targetTransform = target.transform;


	}


	// Update is called once per frame
	void Update () {


		//rotate towards player
		transform.rotation = Quaternion.Slerp (transform.rotation,
			Quaternion.LookRotation (targetTransform.position - transform.position),
			rotationspeed * Time.deltaTime);

		//walk forward towards player
		if (!staredAt) {
			transform.position += transform.forward * movespeed * Time.deltaTime;
		}



//		if (Input.GetKey(KeyCode.Return)) {
//			JumpScare();
//		}


	}

	//on trigger/collision, jump scare method
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			JumpScare ();
			//Debug.Log("bye");
		}
	}

	void Death () {
			//update level manager score

		float distanceFromPlayer = Vector3.Distance (transform.position, targetTransform.position);

		if ( distanceFromPlayer > farRange) {
		Destroy (gameObject);
		}

		if ((distanceFromPlayer < farRange) && (distanceFromPlayer > mediumRange)) {
		Level.AddScore(farScore);
		Destroy (gameObject);
		}

		if ((distanceFromPlayer < mediumRange) && (distanceFromPlayer > closeRange)) {
			Level.AddScore(mediumScore);
			Destroy (gameObject);
		}

		if (distanceFromPlayer < closeRange) {
			Level.AddScore(closeScore);
			Destroy (gameObject);
		}
	}
		
	void JumpScare() {
		//ghost comes in front of you, music plays
		transform.position = targetTransform.position + targetTransform.forward;
		transform.LookAt (targetTransform.position);
		//play music

		//GameOver (); -->SceneManager.LoadScene() move to level manager?
		Level.ItsGameOver();

		}
	void setStaredAt(bool boolean) {
		staredAt = boolean;
	}
}