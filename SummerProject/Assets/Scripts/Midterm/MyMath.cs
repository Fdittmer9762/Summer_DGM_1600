using UnityEngine;
using System.Collections;

public class MyMath : MonoBehaviour {

	public int Add (int x, int y){
		int temp = x + y;
		return temp;
	}

	public int Subtract (int x, int y){
		x += y;
		return x;
	}

}
