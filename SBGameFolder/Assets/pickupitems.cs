using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//for image

public class pickupitems : MonoBehaviour {
	//public GameObject book2;
	public static int xforbook2off = 1;
	
	public void ExitGame() {
		Debug.Log ("Exiting Game from book2");
		Application.Quit ();
	}
	public void takebook2() {
		Debug.Log ("took t book2");
		//Book2 SetActive (false);
		xforbook2off  = 2;
		Debug.Log ("took t book2" + xforbook2off );
		//transform.Translate (1,4,0f);
		//book2.enabled = false;
	}

}
