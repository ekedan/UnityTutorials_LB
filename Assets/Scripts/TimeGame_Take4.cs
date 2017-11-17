using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame_Take4 : MonoBehaviour {


	float delayTime = 2;
	float startTime; //when you don't specify a value, it initializes to zero, automatically
	int waitTime;
	bool roundStarted; //create a bool to determine whether round has started
	//bools are automatically set to false if don't give them a value

	//if want to ignore Input while waiting for new round to start

	void Start(){
		print ("Press spacebar when allotted time up");
		Invoke ("SetNewRandomTime", delayTime);
		//Invoke allows you to schedule a function call after a time delay
		//allows you to use method call function that's time sensitive
		//in this case, SNRT will be called after delayTime
		//only methods(f(x)s) that have no parameters (), can be invoked
	}


	void Update(){
		//put in 'Input' class, make call to GetKeyDown method/function
		if (Input.GetKeyDown(KeyCode.Space) && roundStarted) {
			InputRecieved ();
		}			 
	}


	void InputRecieved() {  //create a new method to allow Update() to be more crisp
		
		roundStarted = false;
		float playerWaitTime = Time.time - startTime; //counting starts
		//if i replace sT with 0, the counting accumulates, to be total counting time since entire game started
		float error = Mathf.Abs(waitTime - playerWaitTime); //calc how far off the player is from time generated
		//use Mathf.Absolute function because we don't care if it's pos. or neg number

		print ("you waited " + playerWaitTime + " seconds. that's " + error + " seconds off");
		print (GenerateMessage (error));

		Invoke ("SetNewRandomTime", delayTime);
	}


	string GenerateMessage(float error){ // create new method that returns a string and takes a float called 'error'

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
		return message; //always need to 'return' if function doesn't return void. return is not a function so 'message' doesn't need to be in ()
	}



	void SetNewRandomTime(){
		waitTime = Random.Range (2, 5); //generating a random number to play against
		startTime = Time.time; //Class called time, make a call to time function in Unity
		//StartTime is declared as a float at top, so don't need to specify 'float' in front of it
		roundStarted = true;

		print (waitTime + " seconds"); //returns the random number generated

		//this function generates a random number, then prints it
	}

}