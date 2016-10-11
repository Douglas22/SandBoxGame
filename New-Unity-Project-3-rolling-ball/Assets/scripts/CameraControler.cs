using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {

	public GameObject Player;

	//private Vector3 offset;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - Player.transform.position;
	}
	/*public void RotateCamera()
	{
		float x = 5 * Input.GetAxis("Mouse X");
		float y = 5 * -Input.GetAxis("Mouse Y");
		Camera.main.transform.parent.transform.Rotate (y,x,0);
	}*/
	// Update is called once per frame
	void LateUpdate () {

		//float x = 5 * Input.GetAxis("Mouse X");
		//print (x);

		transform.position = Player.transform.position + offset;
		//transform.Rotate = Input.mousePosition;
		//print (Input.GetAxis ("Mouse X"));
		//print (Input.mousePosition);
		//transform.Rotate ( );
	}
}
//transform.position.x = Input.mousePosition.x;
//transform.position.z = Input.mousePosition.y;
//transform.position = Input.mousePosition;