using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour {
	//public image img;
	public void ExitGame() {
		Debug.Log ("Exiting Game");
		Application.Quit ();
	}
}
