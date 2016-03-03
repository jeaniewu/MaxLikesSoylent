using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour
{
	public Transform player;
	public float maxDistance = 20.0f;

	void Start ()
	{
		player = GameObject.FindWithTag ("Player").transform;
	}

	void Update ()
	{
		if (Input.GetMouseButtonDown (0) || Input.GetKeyDown (KeyCode.Return)) {
			ShootGhost ();
		}
	}

	void ShootGhost ()
	{
		for (int delta_degree = 60; delta_degree < 130; delta_degree++) {
			Quaternion q = Quaternion.AngleAxis (delta_degree - 180, Vector3.up);
			Vector3 d = player.right * maxDistance;
			RaycastHit hit;

			if (Physics.Raycast (player.position, q * d, out hit, maxDistance, 1 << 8)) {
				Debug.DrawRay (player.position, q * d, Color.green, 0.2f);

				if (hit.collider != null && hit.collider.CompareTag ("Ghost")) {
					Destroy (hit.collider.gameObject);
					ScoreManager.AddScore ((int)hit.distance);
					Debug.Log ((int)hit.distance);
				}
			}
		}
	}
}
