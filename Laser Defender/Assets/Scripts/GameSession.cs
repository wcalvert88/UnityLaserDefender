﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour {

	int score = 0;

	// Use this for initialization
	private void Awake () {
		SetUpSingleton();
	}

	private void SetUpSingleton() {
		int numberGameSessions = FindObjectsOfType<GameSession>().Length;
		Debug.Log(numberGameSessions);
		if (numberGameSessions > 1) {
			Destroy(gameObject);
		} else {
			DontDestroyOnLoad(gameObject);
		}
	}

	public int GetScore() {
		return score;
	}

	public void AddToScore(int scoreValue) {
		score += scoreValue;
		Debug.Log(GetScore());
	}

	public void ResetGame() {
		Destroy(gameObject);
	}
}
