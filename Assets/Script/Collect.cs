using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {
	public Camera VRView;
	public bool _Tcheck = false;
	public GameObject []cubePuzzels;
	public bool PickedCube;
	public int indexin;
	public int CorrectNum=0;
	public float dis = 3f;
	public bool checkWin;
	void Update () {
		
		if (PickedCube) {
			
			Vector3 target = VRView.transform.position + (VRView.transform.rotation * Vector3.forward) * dis;
			Vector3 curr = cubePuzzels[indexin].transform.position;
	
			if ((target - curr).magnitude > .01f) {
				cubePuzzels [indexin].transform.position = Vector3.Lerp (curr, target, Time.deltaTime * 3f);
		  }
			if(_Tcheck){
				cubePuzzels [indexin].transform.position = cubePuzzels[indexin+12].transform.position;
				PickedCube = false;
			}
	   }
		if (checkWin) {
			cubePuzzels [indexin].transform.position = cubePuzzels[indexin+24].transform.position;
			checkWin = false;
		}
	}
	public void Pick(int indexout){
		indexin = indexout;
		PickedCube = true;
		_Tcheck = false;
	}
	public void CheckNot(){
		_Tcheck = true;
	}
	public void counterCorrect(){
		CorrectNum = CorrectNum+1;
	}
	public void counterWrong(){
		CorrectNum = CorrectNum-1;
	}
}