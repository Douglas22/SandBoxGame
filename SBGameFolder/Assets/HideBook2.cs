﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBook2 : MonoBehaviour {
	//public GameObject Book2;
	public static int clickitemoff ;

	void Start (){

		Debug.Log ("check script on Book2 is runing");

	}

	void Update () {

		if (  pickupitems.clickitemoff == 2){
			transform.Rotate (new Vector3  (90	, 90, 90));
			pickupitems.clickitemoff  = 0;
			pickupitems.Book2On = 2;
		}
		else if (pickupitems.Book2On == 1){ 
//clicking the wrong item takes 1 from the value of all the on intergers for the correct objects so you get one if it was set to 2 but not if it's set to 0
			transform.Rotate (new Vector4  (270 , 0, 0));
			pickupitems.Book2On = 0;
			pickupitems.itembook2 = " ";
		}
	}
}
