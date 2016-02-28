using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour {
	public GameObject player;
	public float maxDistance = 20.0f;
	public bool keydown = false;
	// Use this for initialization
	void Start () {

		player = GameObject.FindWithTag ("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
	 

		if (Input.GetKeyDown (KeyCode.F)) {

		for (int delta_degree = 60; delta_degree < 130; delta_degree++) {
			Quaternion q = Quaternion.AngleAxis (delta_degree - 180, Vector3.up);
			Vector3 d = player.transform.right * maxDistance;

			RaycastHit hit;
			if (Physics.Raycast (player.transform.position, q * d,out hit, maxDistance, 1 << 8)){
				Debug.DrawRay (player.transform.position, q * d, Color.green, 0.2f);

				if (hit.collider != null && hit.collider.CompareTag ("Ghost")) {
					Debug.Log (hit.collider.name);
					Destroy (hit.collider.gameObject);
						break;
					Debug.Log ("F was pressed!");
				}
			}
		}
	}
}
}
