using UnityEngine;
using System.Collections;

public class CollideScore : MonoBehaviour {
	public int points = 5;

	void OnCollisionEnter(Collision eventInfo) {
		SendMessageUpwards ("Score", points, SendMessageOptions.DontRequireReceiver);
	}
}
