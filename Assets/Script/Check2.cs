using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check2 : MonoBehaviour {

	public bool c;
	public Collect cc;
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "GameName") {
			cc.dis -= 0.01f;
			c = true;
		} else
			cc.dis = 3;
	}
}
