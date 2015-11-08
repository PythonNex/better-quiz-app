
/*
 * The TitleAgent is responsible for moving the user past the title screen
 * 		- Setup Game: Move to the configuration screen
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public class TitleAgent : MonoBehaviour {
	
	/**
	 * Tells the Core to setup the game
	 */
	
	public void setupGame(){
		// Make sure we have a reference to our Game Object
		loadCache ();

		myCore.setupGame ();
	}
	
	// Cache the on screen objects to improve performance
	Core myCore;
	
	// Searches out the game for our objects. Caching them improves performance
	void loadCache(){
		// Find Core
		if (myCore == null) {
			myCore = GameObject.Find ("GameCore").GetComponent<Core>();
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

