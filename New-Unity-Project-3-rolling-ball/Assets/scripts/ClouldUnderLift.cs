using UnityEngine;
using System.Collections;
//useing for cloud as of 16/01/16
public class ClouldUnderLift : MonoBehaviour {

	public Rigidbody rb ;
	public int a = 0;
	//blow statics not yet used
	/*t1
	public static float t1x;
	public static float t1y;
	public static float t1z;
	t1*/

	void start () 
	{
		rb = GetComponent<Rigidbody> ();
		/*t1
		t1x = transform.position.x;
		t1y = transform.position.y;
		t1z = transform.position.z;
		t1*/
	}
	void Update () 
	{
		Vector3 movement = new Vector3 (0.0f, (0), 0.0f);
		(GetComponent<Rigidbody> ()).AddForce (movement);
		transform.eulerAngles = new Vector3 (90, 270, 270);

		//transform.position = new Vector3(0, (-10 + (a/20)), -11);
		//a = a + 1;
		//cloudtouched = 1;
	}







}
