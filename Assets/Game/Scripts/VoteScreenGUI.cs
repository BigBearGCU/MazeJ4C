using UnityEngine;
using System.Collections;

public class VoteScreenGUI : MonoBehaviour {
	
	public Texture2D avatar1;
	public Texture2D avatar2;
	public Texture2D avatar3;
	public Texture2D positiveImage;
	public Texture2D neutralImage;
	public Texture2D negativeImage;
	public Texture2D tickImage;
	
	enum Vote {
		
		noVote,
		positive,
		neutral,
		negative
	};
	
	private Vote[] player = new Vote[3] { Vote.noVote, Vote.noVote, Vote.noVote };
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		GUI.Label (new Rect(30, 30, 64, 64), avatar1);
		GUI.Label (new Rect(35, 10, 50, 20), "Player 2");
		
		GUI.Label (new Rect(30, 124, 64, 64), avatar2);
		GUI.Label (new Rect(35, 104, 50, 20), "Player 3");
		
		GUI.Label (new Rect(30, 218, 64, 64), avatar3);
		GUI.Label (new Rect(35, 198, 50, 20), "Player 4");
		
		bool positiveVote = false;
		bool neutralVote = false;
		bool negativeVote = false;
		
		for (int i = 0; i < 3; i++) {
			if (player[i] == Vote.positive) {
				positiveVote = true;
			}
			else if (player[i] == Vote.neutral) {
				neutralVote = true;
			}
			else if (player[i] == Vote.negative) {
				negativeVote = true;
			}
		}
		
		if (positiveVote) {
			for (int i = 0; i < 3; i++) {
				if (player[i] == Vote.positive) {
					if (GUI.Button (new Rect(100, 30 + 94 * i, 50, 50), tickImage)) {
						player[i] = Vote.noVote;
					}
				}
				else {
					GUI.Box (new Rect(100, 30 + 94 * i, 50, 50), "");
				}
			}
		}
		else {
			for (int i = 0; i < 3; i++) {
				if (GUI.Button (new Rect(100, 30 + 94 * i, 50, 50), positiveImage)) {
					player[i] = Vote.positive;
				}
			}
		}
		
		if (neutralVote) {
			for (int i = 0; i < 3; i++) {
				if (player[i] == Vote.neutral) {
					if (GUI.Button (new Rect(170, 30 + 94 * i, 50, 50), tickImage)) {
						player[i] = Vote.noVote;
					}
				}
				else {
					GUI.Box (new Rect(170, 30 + 94 * i, 50, 50), "");
				}
			}
		}
		else {
			for (int i = 0; i < 3; i++) {
				if (GUI.Button (new Rect(170, 30 + 94 * i, 50, 50), neutralImage)) {
					player[i] = Vote.neutral;
				}
			}
		}
		
		if (negativeVote) {
			for (int i = 0; i < 3; i++) {
				if (player[i] == Vote.negative) {
					if (GUI.Button (new Rect(240, 30 + 94 * i, 50, 50), tickImage)) {
						player[i] = Vote.noVote;
					}
				}
				else {
					GUI.Box (new Rect(240, 30 + 94 * i, 50, 50), "");
				}
			}
		}
		else {
			for (int i = 0; i < 3; i++) {
				if (GUI.Button (new Rect(240, 30 + 94 * i, 50, 50), negativeImage)) {
					player[i] = Vote.negative;
				}
			}
		}
	}
}
