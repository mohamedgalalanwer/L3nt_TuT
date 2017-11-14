using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerChecker : MonoBehaviour {

	private void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "TT") {
			SceneManager.LoadScene ("Test");
		}
	}
}
