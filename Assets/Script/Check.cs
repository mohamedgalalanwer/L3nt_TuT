﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check : MonoBehaviour {
	public bool c;
	private void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag=="Player") {
		SceneManager.LoadScene ("GameOver");
		} 
	}
}
