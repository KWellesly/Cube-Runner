using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour {
	public Transform player;
	public Text scoreKeeper;


	
	// Update is called once per frame
	void Update () {
		scoreKeeper.text = (player.position.z).ToString ("0");
	}
}
