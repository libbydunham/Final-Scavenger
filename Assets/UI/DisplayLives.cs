using UnityEngine;
using System.Collections;

public class DisplayLives : MonoBehaviour {
	public Transform template;

	void CurrentPlays(int lives) {
		while (transform.childCount > lives) {
			var child = transform.GetChild (lives);
            if (child) {
                child.SetParent(null);
                Destroy(child.gameObject);
            }
		}
		while (transform.childCount < lives) {
			Transform newChild = Instantiate (template);
			newChild.SetParent (transform, false);
		}
	}
}
