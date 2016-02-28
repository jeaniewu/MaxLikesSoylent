using UnityEngine;
using System.Collections;

public class PlayerRayCast : MonoBehaviour {
	public float maxDistance = 100.0f;
	public Vector3 initPos;
	public GameObject player;

	public int hits = 0;


	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		initPos = player.transform.position;
			
	}

	// Update is called once per frame
	void Update () {
		Vector3 dir = player.transform.forward;
		if (Physics.Raycast (initPos, dir, maxDistance)) {
//			setStaredAt (true);
//			hits += 1;
//			Debug.Log ("hit!" + hits);

			}	
		else {
//			setStaredAt (false);
		}
	}
}


