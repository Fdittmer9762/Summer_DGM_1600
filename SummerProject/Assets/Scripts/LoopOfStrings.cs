using UnityEngine;
using System.Collections;

public class LoopOfStrings : MonoBehaviour {

	public string[] myFamily /*= { "Dad", "Mom", "Sam", "Sally", "Dave", "Jen" }*/;
	string familyArray;

	void Start () {
		foreach (string _familyName in myFamily) {
			familyArray += (_familyName + " Loves ");
			print (familyArray);
		}
			
	}
}
