using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

	public bool myBool = true;
	public int myInt = 1;
	public string myString;
	const string myConst = "password";

	void Start () {
		if (myBool == true) {
			print ("Open The Gates");
		} 
		else {
			print ("Close The Gates");
		}
	}

	void Update () {
		// not a good idea to put a if statement in update, takes a tonne of processing power
		// unless you're teaching
		if (myString== myConst) {
			print ("That's correct, you have unlocked things");
		}
		//this will check endlessly, reguardless if it prints
		else {
			print ("Nice try");
		}
	}
}
