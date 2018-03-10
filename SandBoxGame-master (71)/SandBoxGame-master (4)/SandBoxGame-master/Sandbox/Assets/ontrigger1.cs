using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OnTriggerEnter2DScript : MonoBehaviour {

	void OnTriggerEnter2D()
	{
		print ("t1x");
	}

}

/*
#pragma strict

var level: String;

function OnTriggerEnter2D (Col: Collider2d )
{
	if (Col.CompareTag("Player"))
	{
		Application.LoadLevel(level);
	}
}*/
