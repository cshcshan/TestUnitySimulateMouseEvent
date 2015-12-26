using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class SimulateMouseEvent : MonoBehaviour {
	public GameObject button;

	void OnGUI() {
		GUI.Label(new Rect(0, 0, 100, 30), " Press Keyboard");
		GUI.Label(new Rect(0, 30, 100, 30), " Q: Hover");
		GUI.Label(new Rect(0, 60, 100, 30), " W: Un-hover");
		GUI.Label(new Rect(0, 90, 100, 30), " E: Submit");
		GUI.Label(new Rect(0, 120, 100, 30), " R: Press");
		GUI.Label(new Rect(0, 150, 100, 30), " T: Release");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mouseEvent();
	}

	void mouseEvent() {
		PointerEventData pointer = new PointerEventData(EventSystem.current); // pointer event for Execute

		if (Input.GetKeyDown(KeyCode.Q))
		{
			Debug.Log(" Press Keyboard Q");
			ExecuteEvents.Execute(button, pointer, ExecuteEvents.pointerEnterHandler);
		}
		if (Input.GetKeyDown(KeyCode.W)) // un-hover (end hovering)
		{
			Debug.Log(" Press Keyboard W");
			ExecuteEvents.Execute(button, pointer, ExecuteEvents.pointerExitHandler);
		}
		if (Input.GetKeyDown(KeyCode.E)) // submit (~click)
		{
			Debug.Log(" Press Keyboard E");
			ExecuteEvents.Execute(button, pointer, ExecuteEvents.submitHandler);
		}
		if (Input.GetKeyDown(KeyCode.R)) // down: press
		{
			Debug.Log(" Press Keyboard R");
			ExecuteEvents.Execute(button, pointer, ExecuteEvents.pointerDownHandler);
		}
		if (Input.GetKeyUp(KeyCode.T)) // up: release
		{
			Debug.Log(" Press Keyboard T");
			ExecuteEvents.Execute(button, pointer, ExecuteEvents.pointerUpHandler);
		}

	}
}
