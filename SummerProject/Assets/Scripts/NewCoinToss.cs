using UnityEngine;
using System.Collections;

public class NewCoinToss : MonoBehaviour {


	public int coinToss = 2;

	void FixedUpdate () {
		coinToss = Random.Range (1, 3);
		Call (coinToss);
	}

	void Call (int toss) {
		switch (toss)
		{
		case 2:
			print ("Heads");
			break;
		case 1:
			print ("Tails");
			break;
		}
	}
}