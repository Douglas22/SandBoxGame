﻿using UnityEngine;
using UnityEngine.UI;//for image
using System.Collections;
using System.Collections.Generic;

public class pickupitems : MonoBehaviour {
	
	
	
	public static int clickitemoff = 0;
	public static string itembook1 = " ";
	public static string itembook2 = " ";
	public static string itembook3 = " ";
	public static string itembook4 = " ";
	public static string itemnotepad = " ";
	public static string itempencilcase = " ";
	public static string itemlunchbox = " ";
	
	public void ExitGame() {
		Debug.Log ("Exiting Game from book2");
		Application.Quit ();
	}
	public void takebook1() {
		Debug.Log ("took book1 " + clickitemoff);
		clickitemoff  = 1;
		itembook1 = "book1";
	}
	public void takebook2() {
		clickitemoff  = 2;
		Debug.Log ("took book2 " + clickitemoff );
		itembook2 = ", book2";	
	}
	public void takebook3() {
		clickitemoff  = 3;
		Debug.Log ("took book3 " + clickitemoff );
		itembook3 = ", book3";	
	}
	public void takebook4() {
		clickitemoff  = 4;
		Debug.Log ("took book4 " + clickitemoff );
		itembook4 = ", book4";	
	}
	public void takenotepad() {
		clickitemoff  = 5;
		Debug.Log ("took notepad " + clickitemoff );
		itemnotepad = ", notepad";	
	}
	public void takepencilcase() {
		clickitemoff  = 6;
		Debug.Log ("took pencilcase " + clickitemoff );
		itempencilcase = ", pencilcase";	
	}
	public void takelunchbox() {
		clickitemoff  = 7;
		Debug.Log ("took pencilcase " + clickitemoff );
		itemlunchbox = ", lunchbox";	
	}
}
