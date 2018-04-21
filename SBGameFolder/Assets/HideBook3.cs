using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBook3 : MonoBehaviour {
	//public GameObject Book2;
	public static int clickitemoff ;

	void Start (){

		Debug.Log ("check script on Book3 is runing");

	}

	void Update () {

		if (  pickupitems.clickitemoff == 3){
			transform.Rotate (new Vector3  (90	, 90, 90));
			pickupitems.clickitemoff  = 0;
		}
		//Debug.Log ("update HideBook3 runing" +  pickupitems.clickitemoff );
	}
}
