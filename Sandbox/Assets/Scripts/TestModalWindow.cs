using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

//  This script will be updated in Part 2 of this 2 part series.
public class TestModalWindow : MonoBehaviour {
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
	}

	//  Send to the Modal Panel to set up the Buttons and Functions to call
	public void TestYNC () {
		modalPanel.Choice ("What do you want todo today?", TestYesFunction, TestNoFunction, TestCancelFunction);
	}

	//  These are wrapped into UnityActions
	void TestYesFunction () {
		displayManager.DisplayMessage ("Correct answer, show schedule!");
	}

	void TestNoFunction () {
		displayManager.DisplayMessage ("Incorrect answer...");
	}

	void TestCancelFunction () {
		displayManager.DisplayMessage ("Incorrect answer...");
	}
}