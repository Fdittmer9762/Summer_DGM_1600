using UnityEngine;
using System.Collections;

public class MoveOnUpdate : MonoBehaviour {

	//this is bad, update never stops

	void Update () {
		if (transform.position.x <= 10)
			transform.Translate (0.1f, 0, 0);

		print ("update");
	}
}
