using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class countingtext : MonoBehaviour {
	
	public static int clickCount;
	public int x = Roll.clickCount;

	Text text;
	void Awake ()
	{
		//setup refrence
		text = GetComponent <Text> ();
	}

	void Update () 
	{
		text.text = "fethers " + Roll.clickCount;
	}
	/*if (Roll.clickCount != 0)
	{
		print ("fghjk");
	}*/
}
