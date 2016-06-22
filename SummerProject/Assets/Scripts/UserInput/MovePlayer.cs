using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	Vector3 pos;
	public float speed = 10;

	/*public float speed {
		get;
		set;
	}*/

	void Move ()
	{
		//move character in X using the arrow keys
		pos.x = Input.GetAxis ("Horizontal")* Time.deltaTime* speed;
		transform.Translate (pos);
	}

	void Update () {
		Move ();
	}
}
