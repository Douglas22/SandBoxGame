using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public void Switch(string choice) 
	{
		switch (choice) 
		{
		case "startmenu":
			Debug.Log ("Switching to StartMenu scene");
			SceneManager.LoadScene ("Start Menu", LoadSceneMode.Single);
			break;
		case "bedroom":
			Debug.Log ("Switching to Bedroom scene");
			SceneManager.LoadScene ("Bedroom", LoadSceneMode.Single);
			break;
		case "lunchhall":
			Debug.Log ("Switching to Lunch Hall scene");
			SceneManager.LoadScene ("Lunch Hall", LoadSceneMode.Single);
			break;
		default:
			Debug.Log ("Aborting scene switch because it was an unexpected scene...");
			break;
		}
	}
}
