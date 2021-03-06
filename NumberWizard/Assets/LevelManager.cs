﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log ("A level load requested to: " + name);
		Application.LoadLevel(name);
	}

	public void QuitRequest() {
		Debug.Log("I want to quit the game!");
		Application.Quit();
	}
}
