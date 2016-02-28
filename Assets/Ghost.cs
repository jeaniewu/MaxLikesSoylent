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
	public int mediumRange = 3;
	public int closeRange = 1;

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

		//within jump scare range? if yes, jump scare animation, and game over true.
		//on collision
		//make sure player has collider
		//if (Vector3.Distance (transform.position, targetTransform.position) < jumpScareRange) {
		//	JumpScare ();

//		OnCollisionEnter ();

	}

//	void OnCollisionEnter (Collision col) {
//		if (collider.gameObject.name == "Player") {
//			JumpScare ();
//		}
//	}

//	void Death () {
//		//update level manager score
//
//		if ((transform.position
//			levelManager.
//			Destroy (gameObject);
//			}
//
//			void JumpScare() {
//				* //ghost comes in front of you, music plays
//				GameOver (); -->SceneManager.LoadScene() move to level manager?
//				*/
//			}
}