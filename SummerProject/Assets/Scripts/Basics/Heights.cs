using UnityEngine;
using System.Collections;

public class Heights : MonoBehaviour {

	public float sarah;
	public float emma;


	void Start () {
		//SetHeight (sarah);  //this was how I plugged it in originally. Why doesn't this work? (maybe because I never explicitly set it as that value, but it worked with other variables)
		//SetHeight (emma);
		sarah = SetHeight (sarah);
		emma = SetHeight (emma);
		WhoIsTaller ();
	}

	float SetHeight (float height){
		return Random.Range (4f, 6f);
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
