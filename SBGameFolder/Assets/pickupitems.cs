﻿using UnityEngine;
using UnityEngine.UI;//for image
using System.Collections;
using System.Collections.Generic;

public class pickupitems : MonoBehaviour {
	
	
	
	public static int clickitemoff = 0;
	public static int clickallitemon = 0;
	
	public static string itembook1 = " ";
	public static string itembook2 = " ";
	public static string itembook3 = " ";
	public static string itembook4 = " ";
	public static string itemnotepad = " ";
	public static string itempencilcase = " ";
	public static string itemlunchbox = " ";
	public static string itempokeball = " ";
	
	public void ExitGame() {
		Debug.Log ("Exiting Game from book2");
		Application.Quit ();
	}
	public void takebook1() {
		Debug.Log ("took book1 " + clickitemoff);
		clickitemoff  = 1;
		itembook1 = "Maths book";
	}
	public void takebook2() {
		clickitemoff  = 2;
		Debug.Log ("took book2 " + clickitemoff );
		itembook2 = ",English book";	
	}
	public void takebook3() {
		clickitemoff  = 3;
		Debug.Log ("took book3 " + clickitemoff );
		itembook3 = ",PE book";	
	}
	public void takebook4() {
		clickitemoff  = 4;
		Debug.Log ("took book4 " + clickitemoff );
		itembook4 = ",ART book";	
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
		Debug.Log ("took lunchbox " + clickitemoff );
		itemlunchbox = ", lunchbox";	
	}
		public void takepokeball() {
		clickallitemon = clickallitemon - 1 ;
		Debug.Log ("Clicked pokeball return objects" + clickitemoff );
		
		//HideBook4.notepadonfunction
		//HideBook4.HideBook4 =	
	}
}
