using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour {


	void Start(){

//		int x = 8;
//		int y = 8;
//
//		bool a = x==y;
//		bool b = x!=y;

		bool a = true;
		bool b = true;

//		if (a) {
//			print ("x and y are equal");

//		} else if (x > y) {
//			print ("x is greater than y");
//
//		} else {
//			print ("x is less than y");
//		}

		if (a && b) {
			print ("both are true");
		}

		if (a || b) {
			print ("either or both are true");
		}

		if (!a) {
			print ("a is false");
			//if 'not a' means that a is false
		}
	}
}