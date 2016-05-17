using UnityEngine;
using System.Collections;

public class BlackJack : MonoBehaviour 
{
	int card;
	int myHand;
	//int dealerHand;

	void Awake ()
	{
		myHand = 0;
		//dealerHand = 0;
	}

	void Start ()
	{
		Draw ();
		Debug.Log (myHand);
	}

	int Draw ()
	{
		card = Random.Range (1, 13);
		myHand += card;
		return myHand;
	}
}
