using UnityEngine;
using System.Collections;

public class CubeMover : MonoBehaviour {

	public float xDistance = 0;
	public Vector3 pos;

	//this is the best way to do this, is uses much less memory and stops when it reaches the end
	//use enumerators and loops whenever possible, or when you need things to stop
	IEnumerator MoveInX () {
		while (pos.x <= xDistance) {
			pos.x += .1f;
			transform.position = pos;
			print (pos.x);
			yield return new WaitForSeconds (0.1f);
		}
	}

	void OnMouseDown () {
		xDistance += 1;
		StartCoroutine (MoveInX ());
	}
}
