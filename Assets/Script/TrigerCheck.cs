using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerCheck : MonoBehaviour {
	public Collect _isCollected;
	public string _NameCube;
	public AudioCube _ClipSound;
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == _NameCube) {
			_isCollected.PickedCube = false;
			_isCollected.counterCorrect ();
			_ClipSound.DisplayAudioWin ();
			_isCollected.cubePuzzels [_isCollected.indexin].GetComponent<Rigidbody> ().isKinematic = true;
			_isCollected.checkWin = true;
		} else {
			_isCollected.CheckNot();
			_ClipSound.DisplayAudioWrongn ();
			_isCollected.cubePuzzels [_isCollected.indexin].GetComponent<Rigidbody> ().isKinematic = false;
		}

    }
	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.name == _NameCube) {
			_isCollected.counterWrong ();
			_isCollected.CheckNot();
			_isCollected.cubePuzzels [_isCollected.indexin].GetComponent<Rigidbody> ().isKinematic = false;
		}

	}
}