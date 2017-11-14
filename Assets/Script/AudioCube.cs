using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCube : MonoBehaviour {

	public AudioClip Correct;
	public AudioClip Wrong;
	public AudioSource _SourceAudio;

	public void DisplayAudioWin(){
		_SourceAudio.clip = Correct;
		_SourceAudio.Play ();
	}

	public void DisplayAudioWrongn(){
		_SourceAudio.clip = Wrong;
		_SourceAudio.Play ();
	}
}
