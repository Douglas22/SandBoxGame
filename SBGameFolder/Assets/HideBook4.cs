using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBook4 : MonoBehaviour {

	public static string itemnotepad = " ";
	public static int clickitemoff ;
	public static int clickitemon ;

	void Start (){

		Debug.Log ("check script on Book4 is runing");

	}


	void Update () {

		if (  pickupitems.clickitemoff == 4 ){
			transform.Rotate (new Vector4  (90	, 90, 90));
			pickupitems.clickitemoff  = 0;
			pickupitems.Book4On = 2;
		}
		else if (pickupitems.Book4On == 1){ 
//clicking the wrong item takes 1 from the value of all the on intergers for the correct objects so you get one if it was set to 4 but not if it's set to 0
			transform.Rotate (new Vector4  (270 , 0, 0));
			pickupitems.Book4On = 0;
			pickupitems.itembook4 = " ";
		}

	}
}
