using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePencilcase : MonoBehaviour {

	public static int clickitemoff ;

	void Start (){

		Debug.Log ("check script on Pencilcase is runing");

	}

	void Update () {

		if (  pickupitems.clickitemoff == 6){
			transform.Rotate (new Vector4  (90	, 90, 90));
			pickupitems.clickitemoff  = 0;
			pickupitems.PencilcaseOn = 2;
		}
		else if (pickupitems.PencilcaseOn == 1){ 
//clicking the wrong item takes 1 from the value of all the on intergers for the correct objects so you get one if it was set to 4 but not if it's set to 0
			transform.Rotate (new Vector4  (270 , 0, 0));
			pickupitems.PencilcaseOn = 0;
			pickupitems.itempencilcase = " ";
		}

	}
}
