using UnityEngine;
using System.Collections;

public class Roll:MonoBehaviour {
	public Rigidbody rb;
	public static int clickCount = 0;
	//blow statics not yet used
	/*t1
	public static float t1x;
	public static float t1y;
	public static float t1z;
	t1*/
	//t2
	public static float LiftY;
	//t2
	void start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 ( 4f*Input.GetAxis ("Vertical") , LiftY, -1 * moveHorizontal);

		(GetComponent<Rigidbody> ()).AddForce (movement);


		if (
			/*t1   t1x < transform.position.x & (t1x + 10) > transform.position.x & t1z < transform.position.z & (t1z + 10) > transform.position.z   t1*/
			/*t2  transform.position.z > 1 & transform.position.z < 7 & transform.position.x > 1 & transform.position.x < 7 & transform.position.y < 0   t2*/
			GetComponent<Rigidbody>().position.x > -10 & GetComponent<Rigidbody>().position.x < 5  &
			GetComponent<Rigidbody>().position.z > -5 & GetComponent<Rigidbody>().position.z < 5 
			& GetComponent<Rigidbody>().position.y < 0
			|| GetComponent<Rigidbody>().position.y < -29
			) 
	
		{
			print ("x = " + transform.position.x);
			LiftY = 12;

		}

		else 
		{
			print ("your out");
			LiftY = 0.0f ;
		}

		//to stop the player falling through the flaw start
		/*if (t1y < transform.position.y)
		{
			print ("fuck");
		}*/
		//to stop the player falling through the flaw end
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("bird"))
		{
			print ("whywontyouwork" + clickCount);
			clickCount = clickCount + 1 ;
			//other.gameObject.SetActive (false);
		}
	}



}
