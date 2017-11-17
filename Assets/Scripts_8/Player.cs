using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	float speed = 10;


	void Start(){
		//transform.position = new Vector3 (0, 2, 0);
		//transform is the component attached to game object; position is Vector3
	}

	void Update(){

		//create a Vector3 called input, direction, and velocity
		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

		//in order to get direction of 'input' you need to normalize the value
		Vector3 direction = input.normalized;   //'normalized' returns vector with a magnitude of 1
			
		Vector3 velocity = direction * speed;

		Vector3 moveAmount = velocity * Time.deltaTime;

		//to update the object's position:
//		transform.position += moveAmount;

		//another way to do the above
		transform.Translate(moveAmount);


	}

}