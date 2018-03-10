using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {
	public void ExitGame() {
		Debug.Log ("Exiting Game");
		Application.Quit ();
	}
}
