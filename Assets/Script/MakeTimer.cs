﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeTimer : MonoBehaviour {
    public Text timerText;
    float startTime=60f;
    public GameObject doorOfPuzzle1;
    public GameObject canvasOfPuzzle1;
    static  bool  sTime=false;
	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
    public void StartPuzzle1(){
        canvasOfPuzzle1.SetActive (false);
        doorOfPuzzle1.SetActive (false);
        sTime = true;

    }
    void Update(){
        float t = Time.time - startTime;
        string m = ((int)t / 60).ToString ();
        string s = (t % 60).ToString ("f0");
        if (sTime) {
            // startTime -= 1;
            //timerText.text=startTime.ToString("f0");
            timerText.text=m + " : " +s;
            if (m == "5") {

                //Load Game

                Debug.Log ("time exit");

            }

        }


    }
}
