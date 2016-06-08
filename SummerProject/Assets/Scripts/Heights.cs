using UnityEngine;
using System.Collections;

public class Heights : MonoBehaviour {

	public float sarah;
	public float emma;


	void Start () {
		SetHeight (sarah);
		SetHeight (emma);
		WhoIsTaller ();
	}

	float SetHeight (float height){
		height = Random.Range (4, 6); //can't figure out why it won't change their values
		return height;
	}

	void WhoIsTaller (){
		if (sarah > emma) {
			print ("Sarah is taller.");
		}
		if (sarah < emma) {
			print ("Emma is taller.");
		} else {
			print ("They are the same.");
		}
	}
}
