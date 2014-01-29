using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GameState : MonoBehaviour {
	public PlayerController player;
	
	public static bool DEBUG_MODE = true;
	
	public static GameState Instance { get; private set; }

	void Awake() {
		// First we check if there are any other instances conflicting
		if (Instance != null && Instance != this) {
			Destroy(this);
			return;
		}

		// Here we save our singleton instance
		Instance = this;
	}

	void Update() {
		CheckInput();
		if ( DEBUG_MODE ) {
			RunDebugCommands();
		}
	}

	void CheckInput() {
		if (Input.GetKeyDown ("e")) {
			player.Action();
		}
	}

	void RunDebugCommands() {
		if ( Input.GetKeyDown( "t" ) ) {
			if ( Time.timeScale == 1.0f ) {
				Time.timeScale = 10.0f;
			} else {
				Time.timeScale = 1.0f;
			}
		}
		if ( Input.GetKeyDown( "y" ) ) {
			if ( Time.timeScale == 1.0f ) {
				Time.timeScale = 0.25f;
			} else {
				Time.timeScale = 1.0f;
			}
		}
	}
}
