using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_10 : MonoBehaviour {

	//first thing is you'll want to get a reference to the attached rigidbody component,
	//then set it inside Start() method

	Rigidbody myRigidbody;

	public float speed = 6;
	Vector3 velocity; //declare this at top so can access in FixedUpdate()
	int coinCount;


	void Start(){

		myRigidbody = GetComponent<Rigidbody>(); //GC is a 'generic' method w/ a specific syntax

		//we'll be moving the RB around in the fixedUpdate() method, 
		//but we still want to get our input inside the Update() method
		//below, create a number of V3s
	}

	void Update(){

		Vector3 input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		Vector3 direction = input.normalized;
		velocity = direction * speed;
		//Vector3 velocity = direction * speed; 
		//GetAxisRaw, part of Input system, returns value of axis with no smoothing filtering

	}


	//Specify that Coin object is a Trigger, and thus that Player should ignore collisions from this object (box collider)

	void FixedUpdate (){

		myRigidbody.position += velocity * Time.fixedDeltaTime; 
		//another way to read this is my RBposition + velocity as updated per FU calls
		//T.fDT is the time between FixedUpdate calls, however you could also write T.dT and it would understand
		//that this is happening inside an FU and would return correct FixedDeltaTime value for us 

	}

	//specify 'Coin' object as trigger so that Player ignores collisions with it
	//even though collision ignored, it's still being registered by the physics engine and we can ask to be notified of it inside of our script
	//Within this Player class/script for our Player, we'll create a void method below called OTE which takes in Collider variable


	//in order for this to work, (1) this script needs to be attached to one of two or more objects that will collide, and
	//(2) one of colliders need to be marked as trigger(since we're using OTE), and (3) at least one of colliding objects must have Rigidbody attached

	void OnTriggerEnter (Collider triggerCollider) {
		
//		print (triggerCollider.gameObject.name);

		//inside of OTE, if there are many types of objects, we'll need a way to tell what kind of object we've collided with > use 'Tags'

		if(triggerCollider.tag == "Coin"){
			Destroy(triggerCollider.gameObject);   // Destroy removes a gameobject,component or asset; .gO removes gameobject this component attached to
			coinCount++;   // this will increment our countvariable by 1, everytime we touch a coin;
			print(coinCount);
		}

		//print(coinCount);  print command works inside or outside of if statement, but inside OTE
	}
}

