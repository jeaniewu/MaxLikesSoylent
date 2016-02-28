using UnityEngine;
using System.Collections;

public class GhostManager : MonoBehaviour {

	public GameObject ghost;
	public GameObject player;
	public Vector3 playerPos;

	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < 3; i++) {
//			Instantiate(Resources.Load("Ghost"), new Vector3(i * 2.0F, 0, 0), Quaternion.identity);

			Vector3 pos = RandomCircle (playerPos, 10);
			Quaternion rot = Quaternion.FromToRotation(Vector3.forward, playerPos-pos);
			Instantiate (Resources.Load ("Ghost"), pos, rot);
		}
	}

	Vector3 RandomCircle(Vector3 center, float radius) { 

		// create random angle between 0 to 360 degrees 
		float ang = Random.value * 360; 

		Vector3 pos;

		pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad); 
		pos.y = center.y; // + radius * Mathf.Cos(ang * Mathf.Deg2Rad); 
		pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad); 
		return pos;
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
