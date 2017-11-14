using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoor : MonoBehaviour {

	public GameObject Door;
	public AudioClip DoorMoveAudio;
	public AudioSource Src;

	public void MoveTrueDoor(){
		Src.clip = DoorMoveAudio;
		Src.Play ();
		Door.GetComponent<HingeJoint> ().useSpring = true;
	}
}
