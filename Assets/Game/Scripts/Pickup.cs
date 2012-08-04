using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
	
	public int scoreValue = 5;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag.Equals("Player")) {
			
			
			/*GameGUI gameGUI = Camera.main.GetComponent<GameGUI>();
			gameGUI.score += scoreValue;*/
			other.GetComponent<ScoreTimer>().GetTreasure(scoreValue);
			Destroy(gameObject);
		}
	}
}

