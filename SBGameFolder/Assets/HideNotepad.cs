using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideNotepad : MonoBehaviour {

	public static int clickitemoff ;

	void Start (){

		Debug.Log ("check script on Notepad is runing");

	}

	void Update () {

		if (  pickupitems.clickitemoff == 5){
			transform.Rotate (new Vector4  (90	, 90, 90));
			pickupitems.clickitemoff  = 0;
			pickupitems.NotepadOn = 2;
		}
		else if (pickupitems.NotepadOn == 1){ 
//clicking the wrong item takes 1 from the value of all the on intergers for the correct objects so you get one if it was set to 4 but not if it's set to 0
			transform.Rotate (new Vector4  (270 , 0, 0));
			pickupitems.NotepadOn = 0;
			pickupitems.itemnotepad = " ";
		}

	}
}
