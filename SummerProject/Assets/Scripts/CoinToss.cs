using UnityEngine;
using System.Collections;

public class CoinToss : MonoBehaviour {

	string user1 = "Player 1";
	string user2 = "Player 2";
	//public int coin;

	public bool winnerBool;

	void FixedUpdate () {
		TestWhoWon ();
	}

	void TestWhoWon (){
		if (winnerBool) {
			print (user1 + "is the winner");
		}
		else {
			print (user2 + "is the winner");
		}
	}
}
