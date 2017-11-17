using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Episode_04 : MonoBehaviour {

	int frameCount = 0; //variable declaration and initialization


	void Start(){
		//local variables get destroyed outside of scope
		//local variable can only be used within curlybrackets
		print ("Start");
		//print is a function, should be 'Print()', however this is an anomaly in Unity

		float dist = GetDistBetTwoPoints (2, 4, 4, 8);
		print (dist);
	}

	void Update(){
		frameCount += 1; // shorter way to write 'frameCount = frameCount + 1'
		print ("Frame count: " + frameCount);
	}

	float GetDistBetTwoPoints(float x1, float y1, float x2, float y2){
		float dX = x2 - x1; // local variables below
		float dY = y2 - y1;
		float distSquared = dX * dX + dY * dY;
		float dist = Mathf.Sqrt (distSquared);  
		//Mathf is a Struct, which behaves similar to class
		return dist;
		//semicolon tells the computer that the line has ended, 
		//w/out it, it will read script as continuous, even if written on lower line
	}

}
 

