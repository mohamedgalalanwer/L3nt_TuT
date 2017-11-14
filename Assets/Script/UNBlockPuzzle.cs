﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNBlockPuzzle : MonoBehaviour {
    public Rigidbody[] blocks_rigidbodies;
    public GameObject door;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Win_Piece")
        {
            foreach (var block in blocks_rigidbodies)
            {
                block.useGravity = true;
                block.constraints = RigidbodyConstraints.None;
                door.SetActive (false);
                Destroy(block.GetComponent<BlockPuzzle>());
            }

          
        }
    }

}