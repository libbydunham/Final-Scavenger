using UnityEngine;
using System.Collections;

public class BallLost : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		SendMessageUpwards ("Plays", -1, SendMessageOptions.DontRequireReceiver);
	}
}
