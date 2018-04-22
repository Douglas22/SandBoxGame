using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideLunchbox : MonoBehaviour {

	public static int clickitemoff ;

	void Start (){

		Debug.Log ("check script on lunchbox is runing");

	}

	void Update () {

		if (  pickupitems.clickitemoff == 7){
			transform.Rotate (new Vector4  (90	, 90, 90));
			pickupitems.clickitemoff  = 0;
		}

	}
}
