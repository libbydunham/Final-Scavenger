using UnityEngine;
using System.Collections;

public class Flash : MonoBehaviour {
	public float flashDuration = 0.5f;

	void OnCollisionEnter(Collision eventInfo) {
		Light l = GetComponent<Light> ();
		l.intensity = 1.0f;
		StartCoroutine(Dim (l, flashDuration));
	}

	IEnumerator Dim(Light l, float duration) {
		while (l.intensity > 0) {
			yield return null;
			l.intensity -= Time.deltaTime / duration;
		}
	}
}
