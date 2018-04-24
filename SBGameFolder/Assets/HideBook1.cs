using System.Collections;
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
			pickupitems.Book1On = 2;
		}
		else if (pickupitems.Book1On == 1){ 
//clicking the wrong item takes 1 from the value of all the on intergers for the correct objects so you get one if it was set to 2 but not if it's set to 0
			transform.Rotate (new Vector4  (270 , 0, 0));
			pickupitems.Book1On = 0;
			pickupitems.itembook1 = " ";
		}
		
	}
}
