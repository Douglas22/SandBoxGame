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
		}

	}
}
