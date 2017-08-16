using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour {

	public Text scoreKeeper;
	bool gameEnd = false;

	public void GameOver() {

		if (!gameEnd) {
			Debug.Log ("Game Over!");
			gameEnd = true;
		}
		Invoke("Restart", 2f);

	}

	public void Restart() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
