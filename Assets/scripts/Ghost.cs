using UnityEngine;
using System.Collections;


public class Ghost : MonoBehaviour {

	// Use this for initialization

	//var target : Transform; 

	public GameObject target;
	public Transform targetTransform;
	public int movespeed = 2;
	public int rotationspeed = 2;
	public bool staredAt = false;
	public int farRange = 5;
	public int farScore = 1;
	public int mediumRange = 3;
	public int mediumScore = 5;
	public int closeRange = 1;
	public int closeScore = 10;

	public bool isMoving;

	void Start () {
		//initialized x distance from camera(in level manager script);
		//detect main camera (player), update direction.

		target = GameObject.FindWithTag ("Player");
		targetTransform = target.transform;
		transform.LookAt(targetTransform);
		transform.rotation *= Quaternion.Euler(0,180f,0);
		isMoving = true;

//		Vector3 targetAngles = transform.eulerAngles + 180f * Vector3.up; // what the new angles should be
		
//		transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, 1f * Time.deltaTime); 
	}


	// Update is called once per frame
	void Update () {
		

//		//rotate towards player
//		transform.rotation = Quaternion.Slerp (transform.rotation,
//			Quaternion.LookRotation (targetTransform.position - transform.position),
//			rotationspeed * Time.deltaTime);



		//walk forward towards player
		if (!staredAt && isMoving) {
			transform.position -= transform.forward * movespeed * Time.deltaTime;
		}



//		if (Input.GetKey(KeyCode.Return)) {
//			JumpScare();
//		}


	}

	void OnBecameVisible() {
		staredAt = true;
	}

	void OnBecameInvisible() {
		staredAt = false;
	}

	//on trigger/collision, jump scare method
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			JumpScare ();

		}
	}

		

	void OnTriggerExit (Collider other) {
		setStaredAt (false);
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
		Debug.Log("bye");

		isMoving = false;

		transform.LookAt (targetTransform.position);
		transform.rotation *= Quaternion.Euler(0,180f,0);
		//play music

		//GameOver (); -->SceneManager.LoadScene() move to level manager?
		Level.ItsGameOver();

		}
	public void setStaredAt(bool boolean) {
		staredAt = boolean;
	}
}