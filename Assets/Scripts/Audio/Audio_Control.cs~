using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Control : MonoBehaviour {

    private GvrAudioSource _audioSource;
    void Start(){
    
    
        _audioSource = GetComponent<GvrAudioSource>();
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player") {
            _audioSource.Play();
        }
    }
}
