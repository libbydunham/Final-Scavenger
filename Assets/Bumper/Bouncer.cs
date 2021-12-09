using UnityEngine;
using System.Collections;

public class Bouncer : MonoBehaviour {
	public float strength = 5;

	void OnCollisionEnter(Collision eventInfo) {
		Rigidbody other = eventInfo.gameObject.GetComponent<Rigidbody> ();
		if (other) {
			Vector3 away = other.transform.position - transform.position;
			other.AddForce (away * strength);
		}
	}
}
