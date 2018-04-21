using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBook4 : MonoBehaviour {
	//public GameObject Book2;
	public static int clickitemoff ;

	void Start (){

		Debug.Log ("check script on Book4 is runing");

	}

	void Update () {

		if (  pickupitems.clickitemoff == 4){
			transform.Rotate (new Vector4  (90	, 90, 90));
			pickupitems.clickitemoff  = 0;
		}
		//Debug.Log ("update HideBook4 runing" +  pickupitems.clickitemoff );
	}
}
