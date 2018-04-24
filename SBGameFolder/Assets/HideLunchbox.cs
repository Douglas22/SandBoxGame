using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideLunchbox : MonoBehaviour {

	public static int clickitemoff ;

	void Start (){

		Debug.Log ("check script on lunchbox is runing");

	}

	void Update () {

		if (  pickupitems.clickitemoff == 7 ){
			transform.Rotate (new Vector4  (90 , 0, 0));
			pickupitems.clickitemoff  = 0;
			pickupitems.clickallitemon = 2;
			//v3Current = Vector3.Lerp (90 , 90, 90);
			//transform.eulerAngles = (90 , 90 , 90);			
			//rotation.eulerAngles = new Vector3(90	, 90, 90);
		}
		else if (pickupitems.clickallitemon == 1){
			transform.Rotate (new Vector4  (270 , 0, 0));
			pickupitems.clickallitemon = 0;
		}

	}
}
