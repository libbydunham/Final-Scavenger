using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class UpdateScore : MonoBehaviour {

	void TotalScore (int score) {
		GetComponent<Text> ().text = score.ToString ();
	}
}
