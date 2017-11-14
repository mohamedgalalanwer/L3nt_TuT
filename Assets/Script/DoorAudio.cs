using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAudio : MonoBehaviour {

	public AudioClip mySound;
	public AudioSource soundSource;

	public void DisplayDoorOpen(){
		soundSource.clip = mySound;
		soundSource.Play ();
	}
}
