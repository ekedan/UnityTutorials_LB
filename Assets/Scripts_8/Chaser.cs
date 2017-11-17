using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour {

	//let's say we want to parent the sphere object to this cube object
	//the first thing we'll need is a reference to the sphere's Transform
	//a way to do this is to create a public Transform to the sphere (will show up in gui)

	public Transform targetTransform; 

	//Transform relates to the class
	//transform is the transform component of a game object

	public float speed = 7; //make this float publc


	//can then set up parent in Start() with 'sphereTransform.parent' and set it equal to Transform of cube


	void Update(){

		//below we're creating various Vector3 variables
		//though not really understanding the application/use of 'normalized'

		Vector3 displacementFromTarget = targetTransform.position - transform.position;
		Vector3 directionToTarget = displacementFromTarget.normalized; //norm. sets magnitude to 1
		Vector3 velocity = directionToTarget * speed;

		//overshoots and corrects when reaches target, make it stop before runs into target
		float distToTarget = displacementFromTarget.magnitude; //returns length of vector

		if (distToTarget > 1.5f){
			transform.Translate (velocity * Time.deltaTime);  //to give us our move amount
		}

	}

}

