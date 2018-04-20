using UnityEngine;
using UnityEngine.UI;//for image
using System.Collections;
using System.Collections.Generic;

public class pickupitems : MonoBehaviour {
	
	
	
	public static int xforbook2off = 1;
	public static string itemname = " ";
	
	public void ExitGame() {
		Debug.Log ("Exiting Game from book2");
		Application.Quit ();
	}
	public void takebook2() {
		Debug.Log ("took item1 / book2");
		xforbook2off  = 2;
		Debug.Log ("took t book2" + xforbook2off );
		//itemname = "fjfdjkdjkjfk";
		itemname = " book2 ";
	}

}
