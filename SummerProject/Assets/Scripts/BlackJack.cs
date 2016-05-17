using UnityEngine;
using System.Collections;

public class BlackJack : MonoBehaviour 
{
	int card;
	int myHand;
	//int dealerHand;
	bool blackJack;
	bool bust;

	void Awake ()
	{
		myHand = 0;
		//dealerHand = 0;
	}

	void Start ()
	{
		Draw ();
		Debug.Log (myHand);
		Table ();
		Debug.Log (bust);
	}

	void Table ()
	{
		blackJack = false;
		if (myHand >= 22) 
		{
			bust = true;
		}
		else if (myHand <= 20) 
		{
			bust = false;
		} 
		else 
		{
			blackJack = true;
			bust = true;
		}

	}
		
	int Draw ()
	{
		card = Random.Range (1, 13);
		myHand += card;
		return myHand;
	}
}
