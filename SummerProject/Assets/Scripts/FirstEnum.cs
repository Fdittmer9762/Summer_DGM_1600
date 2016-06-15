using UnityEngine;
using System.Collections;

public class FirstEnum : MonoBehaviour {

	public enum Operations { ADD, SUBTRACT, MULTIPLY, DIVIDE, SQUARE, POWER };

	public Operations currentOperation;

	public int numOne;
	public int numTwo;

	int ChangeOperation (int x, int y){
		int value = 0;
		switch (currentOperation) {
		case Operations.ADD:
			value = x + y;
			break;
		case Operations.SUBTRACT:
			value = x - y;
			break;
		case Operations.MULTIPLY:
			value = x * y;
			break;
		case Operations.DIVIDE:
			value = x / y;
			break;
		case Operations.SQUARE:
			value = (x+y)*(x+y);
			break;
		case Operations.POWER:
			int temp = x;
			for (int i = 1; i < y; i++) {
				temp *= x;
			}
			value = temp;
			break;
		default:
			Debug.Log ("error");
			break;
		}
		return value;
	}

	void OnMouseDown (){
		int finalValue = ChangeOperation (numOne, numTwo);
		print (finalValue);
	}
}
