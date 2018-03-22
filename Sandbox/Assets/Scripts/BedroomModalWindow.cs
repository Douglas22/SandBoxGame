using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class BedroomModalWindow : MonoBehaviour {
	private ModalPanel modalPanel;
	private DisplayManager displayManager;

	private UnityAction myYesAction;
	private UnityAction myNoAction;
	private UnityAction myCancelAction;

	void Awake () {
		modalPanel = ModalPanel.Instance ();
		displayManager = DisplayManager.Instance ();

		myYesAction = new UnityAction (TestYesFunction);
		myNoAction = new UnityAction (TestNoFunction);
		myCancelAction = new UnityAction (TestCancelFunction);

		displayModal ();
	}

	//  Send to the Modal Panel to set up the Buttons and Functions to call
	public void displayModal () {
		modalPanel.Choice ("What do you want todo today?", TestYesFunction, TestNoFunction, TestCancelFunction);
	}

	//  These are wrapped into UnityActions
	void TestYesFunction () {
		displayManager.DisplayMessage ("Good, check schedule and pack your items!");
	}

	void TestNoFunction () {
		displayManager.DisplayMessage ("Incorrect...");
	}

	void TestCancelFunction () {
		displayManager.DisplayMessage ("Incorrect...");
	}
}