using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {
	public string control;
	public Vector3 range;
	public float pullSpeed, springSpeed;
	protected Vector3 startingPosition;

	void Start() {
		startingPosition = transform.position;
	}

	void MoveTowards(Vector3 point, float speed) {
		var rb = GetComponent<Rigidbody> ();
		rb.MovePosition(Vector3.MoveTowards (transform.position, point, Time.deltaTime * speed));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton (control)) {
            var game = GetComponentInParent<Game>();
            if (game == null || game.lives >= 0)
    			MoveTowards (startingPosition + range, pullSpeed);
		} else {
			MoveTowards (startingPosition, springSpeed);
		}
	}
}
