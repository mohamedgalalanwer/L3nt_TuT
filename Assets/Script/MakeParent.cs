using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeParent : MonoBehaviour {

	public GameObject child;
	public GameObject Player;
	public MoveRoof Roof;
	public AudioClip KeyAudio;
	public AudioSource Source;

	public void Collect(){
		child.transform.parent = Player.transform;
		child.transform.rotation = Player.transform.rotation;
		child.transform.position = Player.transform.position;
		Roof.moveRoof = true;

			Source.clip = KeyAudio;
			Source.Play ();
	}
	public void setParent(){
		child.transform.parent = Player.transform;
		child.transform.rotation = Player.transform.rotation;
		child.transform.position = Player.transform.position;

	}
}
