using UnityEngine;
using System.Collections;

public class GhostManager : MonoBehaviour
{
	public Vector3 playerPos;

	void Start ()
	{
		playerPos = GameObject.FindWithTag ("Player").transform.position;
		for (int i = 0; i <= LevelManager.getGhostCount (); i++) {
			Vector3 ghostPos = RandomCircle (playerPos, 25);
			Quaternion ghostRot = Quaternion.FromToRotation (Vector3.forward, playerPos - ghostPos);
			Instantiate (Resources.Load ("Bunny"), ghostPos, ghostRot);
		}
	}

	Vector3 RandomCircle (Vector3 center, float radius)
	{
		float angle = Random.value * 360; 
		Vector3 pos;
		pos.x = center.x + radius * Mathf.Sin (angle * Mathf.Deg2Rad); 
		pos.y = center.y;
		pos.z = center.z + radius * Mathf.Cos (angle * Mathf.Deg2Rad); 
		return pos;
	}
}
