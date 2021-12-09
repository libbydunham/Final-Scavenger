using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {
	public string control;
	public float pullSpeed, springSpeed;
	public float range;
	protected Quaternion startingPosition;

	void Start() {
		startingPosition = transform.rotation;
	}

	void MoveTowards(Quaternion angle, float speed) {
		var rb = GetComponent<Rigidbody> ();
		rb.MoveRotation(Quaternion.RotateTowards (transform.rotation, angle, Time.deltaTime * speed));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton (control)) {
			MoveTowards (Quaternion.AngleAxis (range, Vector3.up) * startingPosition, pullSpeed);
		} else {
			MoveTowards (startingPosition, springSpeed);
		}
	}
}
