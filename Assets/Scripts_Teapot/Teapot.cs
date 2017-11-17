using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teapot : MonoBehaviour {

	//first declare our variables

	public Color color;   //Color is a class predefined, First, declare it as variable

	public float size;

	public string liquidTypeName;

//	public Material mat;		// material we'll assign to teapot, though this one didn't work

	public Material googleMat;  //imported material

	public MeshRenderer meshRend;

	public float fluidAmount;

	public Material defaultMaterial; //to set default material as Unity default



	void Start(){  
//		color = new Color ();

		//First we set the default color variable, size, and liquidTypeName
		color = Color.gray;
		size = 1;
		liquidTypeName = "tea";

		//Getting the defualt unity material from a gameobject in the scene and storing it
		defaultMaterial = GameObject.Find("Box").GetComponent<MeshRenderer>().material; //setting material to default material in Unity

		//Setting a Custom Material we made to the googleMat variable
		googleMat = Resources.Load<Material>("DiamondGrid");  //set variable 'material' to imported material

		//We are storing a refrence to this gameobects MeshRenderer to the variable meshRend, inorder to have access to the teapots material at all times
		meshRend = gameObject.GetComponent<MeshRenderer>();

		//We are setting the teapots material to the custom google material at start
		meshRend.material = googleMat;
//		mat = googleMat;
//		Debug.Log (defaultMaterial);
//		Debug.Log (meshRend);
	}
	 


	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) { 
			ToggleMaterial();
			Pour ();
		}
			
	}
		
	//define functions 
	//make public so that other scripts can use these functions

	public void Pour(){  //vector math, rotation, lerp
		//want to rotate 90 degrees - how access rotation of teapot?
		//want to lift 
		transform.Rotate (new Vector3 (45, 0, 0));
//		while(transform.rotation.x <= 45 ){
//			transform.rotation.x = Vector3.Lerp( 90, (.5f*Time.deltaTime)); //if statement that keeps running
//		}
	}

	public void Heat(){ //change to red
		//you don't want to change albedo (texture) in this case 
		//i only want to change color 
	}

	public void Cool(){  //change to blue
	
	}

	public void ChangeLiquidType(){ //just changing name, create another game object that's liquid inside the teapot
	
	}

	public void ChangeMaterial(){ 
		meshRend.material = defaultMaterial;
	}


	public void ToggleMaterial(){ //first check which material it is, then switch to other material

		if (meshRend.material.name == "DiamondGrid (Instance)") { // for conditions, need 'equals to'
			meshRend.material = defaultMaterial;
		} else {
			meshRend.material = googleMat;
		}
//			print (meshRend.material);
		Debug.Log (meshRend.material);
		Debug.Log (googleMat);
		Debug.Log (meshRend.material.name);
	}

}







