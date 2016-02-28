using UnityEngine;
using System.Collections;

public class PlayerRayCast : MonoBehaviour {
	public float maxDistance = 100.0f;
	public Vector3 initPos;
	public GameObject player;
	public GameObject ghost;

	public int num = 0;


	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		initPos = player.transform.position;
			
	}

	// Update is called once per frame


	void Update () {


		//		for (int delta_degree = 40; delta_degree < 150; delta_degree ++) {
//			Quaternion q = Quaternion.AngleAxis (delta_degree - 180, Vector3.up);
//			Vector3 d = player.transform.right * maxDistance;
//			RaycastHit[] hits = 
//				Physics.RaycastAll (player.transform.position, q * d, maxDistance);
//			Debug.DrawRay (player.transform.position, q * d, Color.green,0.2f);
//
//			foreach (RaycastHit hit in hits){
//				if (hit.collider != null && hit.collider.CompareTag ("Ghost")) {
//					num += 1;
//					hit.collider.gameObject.GetComponent<Ghost> ().setStaredAt (true);
//				}
//
//			}
//		}









		//		Vector3 dir = player.transform.forward;
//		if (Physics.Raycast (initPos, dir, maxDistance)) {
//	//		setStaredAt (true);
//			hits += 1;
//			Debug.Log ("hit!" + hits);
//
//			}	
//	//	else {
//	//		setStaredAt (false);
//		}
	}
}


