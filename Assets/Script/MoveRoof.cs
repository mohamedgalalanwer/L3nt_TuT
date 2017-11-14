using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoof : MonoBehaviour {

    public bool moveRoof = false;
	public float posY;
	public AudioClip RoofMovinAudio;
	public AudioSource Src;
	void Start(){
		posY = transform.position.y;
	}
    void Update()
    {
		if (moveRoof && posY - 60 < (transform.position.y)) {
			Src.clip = RoofMovinAudio;
			Src.Play ();
			transform.Translate (0, 0, -0.5f * Time.deltaTime);
			//Debug.Log ("posY = " + posY + "\tTransform y" + transform.position.y);
		} else {
			Src.Stop ();
		}

    }
}
