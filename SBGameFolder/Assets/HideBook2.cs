using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBook2 : MonoBehaviour {
	public GameObject Book2;
	public static int xforbook2off ;

	void Start (){

		Debug.Log ("test script on Book2 is runing");

	}

	void Update () {

		if (  pickupitems.xforbook2off == 2){
			transform.Rotate (new Vector3  (90	, 90, 90));
			pickupitems.xforbook2off  = 3;
		}
		//Debug.Log ("update hidebook2 runing" +  pickupitems.xforbook2off );
	}
}
