using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ghost : MonoBehaviour {

	// Use this for initialization

	//var target : Transform; 

	public GameObject target;
	public Transform targetTransform;
	public GameObject levelManager;
	public int movespeed = 2;
	public int rotationspeed = 2;
	//public int jumpScareRange = 1;
	public bool staredAt = false;
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
//		levelManager = GameObject.FindWithTag ("LevelManager");

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


	}

	//on trigger/collision, jump scare method
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			//JumpScare ();
			Debug.Log("bye");
		}
	}

//	void Death () {
			//update level manager score

//		if ((transform.position-target.position) > farRange) {
//		Destroy (GameObject);
//		}
//
//	if ((transform.position-target.position) < farRange && (transform.position) > mediumRange) {
//		levelManager.AddScore(farScore);
//		Destroy(GameObject);
//		}
//
//	if ((transform.position-target.position) > farRange) {
//		levelManager.AddScore(mediumScore);
//		Destroy (GameObject);
//		}
//
//	if ((transform.position-target.position) > farRange) {
//		levelManager.AddScore(closeScore);
//		Destroy (GameObject);
//		}
//	}
//		
//	void JumpScare() {
//		//ghost comes in front of you, music plays
//		target.FaceThisGhost(transform.position);
//		//GameOver (); -->SceneManager.LoadScene() move to level manager?
//		levelManager.ItsGameOver();
//
//		}
}