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
		}

	}
}
