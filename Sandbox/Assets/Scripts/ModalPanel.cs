using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ModalPanel : MonoBehaviour {

	public Text question;
	public Button cancelButton;
	public Button noButton;
	public Button yesButton;
	public GameObject modalPanelObject;
	public GameObject classroomScheduleObject;

	private static ModalPanel modalPanel;

	public static ModalPanel Instance () {
		if (!modalPanel) {
			modalPanel = FindObjectOfType(typeof (ModalPanel)) as ModalPanel;
			if (!modalPanel)
				Debug.LogError ("There needs to be one active ModalPanel script on a GameObject in your scene.");
		}

		return modalPanel;
	}

	// Yes/No/Cancel: A string, a Yes event, a No event and Cancel event
	public void Choice (string question, UnityAction yesEvent, UnityAction noEvent, UnityAction cancelEvent) {
		modalPanelObject.SetActive (true);

		yesButton.onClick.RemoveAllListeners();
		yesButton.onClick.AddListener (yesEvent);
		yesButton.onClick.AddListener (ClosePanel);
		yesButton.onClick.AddListener (DisplaySchedule);

		noButton.onClick.RemoveAllListeners();
		noButton.onClick.AddListener (noEvent);

		cancelButton.onClick.RemoveAllListeners();
		cancelButton.onClick.AddListener (cancelEvent);

		this.question.text = question;

		yesButton.gameObject.SetActive (true);
		noButton.gameObject.SetActive (true);
		cancelButton.gameObject.SetActive (true);
	}

	void ClosePanel () {
		modalPanelObject.SetActive (false);
	}

	void DisplaySchedule () {
		classroomScheduleObject.SetActive (true);
	}
}
