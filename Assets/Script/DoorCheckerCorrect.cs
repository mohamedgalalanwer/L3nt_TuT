using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCheckerCorrect : MonoBehaviour {
	public MoveDoor m;
	private void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "key") {
			m.MoveTrueDoor ();
			Destroy (other.gameObject);
		}
	}
}
