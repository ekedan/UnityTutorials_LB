using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {



	//let's say we want to parent the sphere object to this cube object
	//the first thing we'll need is a reference to the sphere's Transform
	//a way to do this is to create a public Transform to the sphere (will show up in gui)

	public Transform sphereTransform;  //this is the reference to the sphere's Transform

	public float speed = 7; //make this float publc



	void Start(){

		//in Start() we're going to set the sphere's parent, and we'll set it to the transform of the cube gameobject
		sphereTransform.parent = transform;   //here, recognized as the transform attached to gameobject of this script

//		sphereTransform.localScale = new Vector3 (2, 2, 2); //OR
		sphereTransform.localScale = Vector3.one *2; 
		//the above sets the sphere's scale to a new vector
	} 
		
	//how to rotate objects with code:

	void Update(){

		//eulerAngles are a more intuitive way of working with rotation than 'rotation' whis is a Quaternion
		//+= will increase the rotation over time

//		transform.eulerAngles += new Vector3 (0, 180 * Time.deltaTime, 0); //y as 180 degrees per second

//		transform.eulerAngles += new Vector3 (0, 1, 0) * 180 * Time.deltaTime; //OR:

//		transform.eulerAngles += Vector3.up * 180 * Time.deltaTime; //.up is short for (0,1,0); no 'new' here
	
		//the Rotate method here is referring to the gameObject, and by default will work in object space
		//if you want it to rotate in global space, add Space.World (v. Space.Self) designates coordinates to work within

		transform.Rotate (Vector3.up * 180 * Time.deltaTime); //by default, 'Rotate' works in object space (not global space)

		transform.Translate (Vector3.forward * Time.deltaTime * 7, Space.World); //adding a comma adds a Space parameter to the method


		//experiment with setting position versus local position below:

		if (Input.GetKeyDown (KeyCode.Space)) {
//			sphereTransform.position = Vector3.zero; //will snap to global origin position
			//sphereTransform.localPosition = Vector3.zero; // will snap to position of parent's origin,indicates zero offset from parent
			sphereTransform.position = Vector3.zero;
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
//			sphereTransform.localPosition = (Vector3.right * 2); OR, another way to write it
			sphereTransform.localPosition = new Vector3 (0, 2, 0);
//			sphereTransform.position = new Vector3 (0, 2, 0);


		}
	} 
}
		



