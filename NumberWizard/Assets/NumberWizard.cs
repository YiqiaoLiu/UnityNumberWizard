using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;


	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame() {
		max = 1000;
		min = 1;
		guess = 500;

		max = max + 1;

		print("-------------------------");
		print("Welcome to Number Wizard!");
		print("Please think a number between 1 and 1000, don't let me know!");
		
		print("Is the number higher or lower than " + guess);
		print("Up = higher, down = lower, enter = equal");
	}

	void UpdateGuess() {
		guess = (min + max) / 2;
		print ("The number is " + guess);
		print("Is the number higher or lower than " + guess);
		print("Up = higher, down = lower, enter = equal");
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			UpdateGuess();
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			UpdateGuess();
		}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame();
		}
	}
}
