using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour {
	
	public bool opening = false;
	public Collect Coll;
	public DoorAudio _DOOR;
	void Update () {
		if (Coll.CorrectNum==12&&transform.position.y < -8f){
			_DOOR.DisplayDoorOpen ();
			transform.Translate(0, 0, 1.5f * Time.deltaTime);
			Debug.Log (transform.position.y);
		}
	}
}
