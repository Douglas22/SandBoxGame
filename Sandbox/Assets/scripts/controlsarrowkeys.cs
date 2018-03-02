using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//reused from past project may be messy but will want to re use count text part latter on
public class moveacube : MonoBehaviour {
	private int count;
	//t1
	public static float t1x;
	public static float t1y;
	public static float t1z;
	//t1
	//public Text countText;
	void start ()
	{
		//count = 0;
		//SetCountText ();
	}
	void FixedUpdate () {
		//print (Input.GetAxis("Horizontal"));  //testing
		transform.Translate (Input.GetAxis("Horizontal")*0.3f,0.3f*Input.GetAxis("Vertical"),0f);

		//t1 = Input.GetAxis("Horizontal"); //testing

		t1x = transform.position.x;
		t1y = transform.position.y;
		t1z = transform.position.z;
		//print (t1x);  //testing

	}
	/* keep and reuse for sandbox game
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("pickup")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}
	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
	}*/
}

