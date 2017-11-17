using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame_Take2 : MonoBehaviour {

	float StartTime; //when you don't specify a value, it initializes to zero, automatically
	int waitTime;


	void Start(){
		print ("Press spacebar when allotted time up");
		SetNewRandomTime ();
	}


	void Update(){
		//put in 'Input' class, make call to GetKeyDown method/function
		if (Input.GetKeyDown(KeyCode.Space)) {
			float playerWaitTime = Time.time - StartTime; //counting starts
			float error = Mathf.Abs(waitTime - playerWaitTime); 
			//calc how far off the player is from time generated
			//use Mathf.Absolute function because we don't care if it's pos. or neg number

			string message = " ";
			if (error < .15f) {
				message = "fantastic!";
			} else if (error < .50f) {
				message = "good job!";
			} else if (error < .75f) {
				message = "not bad!";
			} else if (error >= 1f) {
				message = "you tried!";
			} else {
				message = "you slipped in between .75 and 1.0!";
			}

			print ("you waited " + playerWaitTime + " seconds. that's " + error + " seconds off");
			print (message);
			SetNewRandomTime (); // will print new random number generated
		}			 
	}


	void SetNewRandomTime(){
		int waitTime = Random.Range (2, 5); //generating a random number to play against
		StartTime = Time.time; //Class called time, make a call to time function in Unity
		//StartTime is declared as a float at top, so don't need to specify 'float' in front of it

		print (waitTime + " seconds"); //returns the random number generated

		//this function generates a random number, then prints it
	}

}