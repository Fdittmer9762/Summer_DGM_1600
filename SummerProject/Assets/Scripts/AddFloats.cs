using UnityEngine;
using System.Collections;

public class AddFloats : MonoBehaviour {

	float A = 20;
	float B = 15;

	void Start () {
		print (Addition (A,B));
		/*Addition(A,B);
		if (Addition (A, B) >= 30) {
			print (Addition (A, B));
		}*/
	}

	float Addition (float x, float y){
		float z = x + y;
		return z;
	}
}
