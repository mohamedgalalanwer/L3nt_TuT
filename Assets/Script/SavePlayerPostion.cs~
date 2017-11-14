using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPostion : MonoBehaviour {
    public GameObject PlayerPostion;

	// Use this for initialization
	void Start () {
        Debug.Log ("Data Loaded");
        Vector3 savePostion = new Vector3 (PlayerPrefs.GetFloat ("PlayerX"), PlayerPrefs.GetFloat ("PlayerY"), PlayerPrefs.GetFloat ("PlayerZ"));
        PlayerPostion.transform.position = savePostion;
    }
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetFloat ("PlayerX", PlayerPostion.transform.position.x);
        PlayerPrefs.SetFloat ("PlayerY", PlayerPostion.transform.position.y);
        PlayerPrefs.SetFloat ("PlayerZ", PlayerPostion.transform.position.z);
	}
}
