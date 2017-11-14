using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControll : MonoBehaviour {

	// Use this for initialization
    public void GotoSecondGame () {
        SceneManager.LoadScene ("SecondGame");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
