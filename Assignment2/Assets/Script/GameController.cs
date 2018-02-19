using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject mooseMan;
	public int maxScore;

	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}

	public void AddScore(){
		score++;
		if (score == maxScore) {
			EndGame ();
		}
	}

	void EndGame(){
		//mooseman dance
	}
}
