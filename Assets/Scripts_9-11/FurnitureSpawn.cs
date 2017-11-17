using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureSpawn : MonoBehaviour {

	//begin by getting reference to the chair prefab

	public GameObject chairPrefab;


	void Start (){
	}


	//spawn a chair in a random position when player hits space key

	void Update(){

		if(Input.GetKeyDown(KeyCode.Space)){
			Vector3 randomSpawnPos = new Vector3 (Random.Range (-10f,10f), 0, Random.Range (-10f,10f));  //choose a random position 
			Vector3 randomSpawnRot = Vector3.up * Random.Range (0, 360); //random rotation around y axis

			//to spawn prefab, use instantiate method
//			Instantiate(chairPrefab, randomSpawnPos, Quaternion.Euler(randomSpawnRot)); 

			//often, we may want to get a reference to the thing we just instantiated
			//Instantiate returns an object. Because we're passing a GameObject into Instant, then can convert return object to GO

//			GameObject newChair = Instantiate(chairPrefab, randomSpawnPos, Quaternion.Euler(randomSpawnRot)); 
		
		    // open parenthesis to write the type of object we want to cast to
			GameObject newChair = (GameObject)Instantiate(chairPrefab, randomSpawnPos, Quaternion.Euler(randomSpawnRot)); 
		
			// to do something with our reference, we could make it parent the chairs instantiated
		
			newChair.transform.parent = transform; //sets parent of newChair gameobject to Furniture transform (because Furn set to this script)

			print (newChair); //in console, it prints name of chairPrefab Gameobject, it prints 'Chair', name that we've given the prefab
		}

	

	}

}