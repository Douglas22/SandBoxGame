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
			pickupitems.LunchboxOn = 2;
		}
		else if (pickupitems.LunchboxOn == 1){ //pokaball takes 1 from the value of LunchboxOn you get one if it was set to 2 but not if it's set to 0
			transform.Rotate (new Vector4  (270 , 0, 0));
			pickupitems.LunchboxOn = 0;
			pickupitems.itemlunchbox = " ";
		}

	}
}
