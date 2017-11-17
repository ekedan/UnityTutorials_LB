using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//colon indicates that the class is inheriting MonoBehavior
public class Enemy : MonoBehaviour {

	public static int numberOfEnemiesAlive = 0; //class variable
	int instanceExample = 0;			 //instance variable
	//putting public in front of static makes it accessible to other classes


	void Start(){
		numberOfEnemiesAlive = numberOfEnemiesAlive + 1;
		instanceExample = instanceExample + 1;
	}



	void Update(){

		bool canSeePlayer = false;
		//set canSeePlayer to true if the player is within a certain distance
		if(canSeePlayer){
			//attack the player
		}
	}
}









//instance variable is the default kind of variable
//opposite of an instance variable is a class variable
//class variable belongs not to one instance, but to the class itself
//create class variables by adding the keyword 'static'

