using UnityEngine;
using System.Collections;

public class ClouldTolift : MonoBehaviour {


	public GameObject liftCloud;
	public Vector3 offset;

	void Start () 
	{
		//offset = transform.position - liftCloud.transform.position;
	}

	void Update () 
	{
		transform.position = liftCloud.transform.position;
	}
}
