﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBook1 : MonoBehaviour {
	//public GameObject Book2;
	public static int clickitemoff ;

	void Start (){

		Debug.Log ("check script on Book1 is runing");

	}

	void Update () {

		if (  pickupitems.clickitemoff == 1){
			transform.Rotate (new Vector3  (90	, 90, 90));
			pickupitems.clickitemoff  = 0;
		}
		//Debug.Log ("update hidebook2 runing" +  pickupitems.clickitemoff );
	}
}
