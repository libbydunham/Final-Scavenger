using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Game : MonoBehaviour {
	[SerializeField]
	int score = 0;

	public int lives = 3;
	void Start() {
		// Send global message about current life count
		BroadcastMessage ("CurrentPlays", lives, SendMessageOptions.DontRequireReceiver);
	}

	void Score(int gained) {
		score += gained;
		BroadcastMessage ("TotalScore", score, SendMessageOptions.DontRequireReceiver);
	}

	void Plays(int gained) {
		lives += gained;
		BroadcastMessage ("CurrentPlays", lives, SendMessageOptions.DontRequireReceiver);
	}
}
