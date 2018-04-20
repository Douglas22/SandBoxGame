using UnityEngine;
using UnityEngine.UI;

public class ListOfItemsPickedUp : MonoBehaviour 
{
	public Text ListOfItems;
	// Use this for initialization
	void Start () {
		//ItemList.text = "My text has now changed.";
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("test");
		
		ListOfItems.text = "items collected " + pickupitems.itemname ;
	}
}
