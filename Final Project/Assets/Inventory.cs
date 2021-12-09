using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	public Transform grip;
	public Vector3 rightOffset;

    void OnControllerColliderHit(ControllerColliderHit other)
    {
		var item = other.gameObject.GetComponentInParent<Item> ();
		if (item != null) {
			item.transform.SetParent (grip);
			item.transform.localRotation = Quaternion.identity;
			item.transform.localPosition = rightOffset;
		}
    }
}
