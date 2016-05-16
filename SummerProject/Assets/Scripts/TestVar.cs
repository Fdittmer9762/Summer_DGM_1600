using UnityEngine;
using System.Collections;

public class TestVar : MonoBehaviour {

	public int cookies = 12;
	int portion;
	int kids;
	int leftovers;

	void Start () 
	{
		kids = Random.Range (1, 4);
		portion = Random.Range (1, 3);
		Cookies (leftovers);
		Debug.Log (leftovers);
	}

	int Cookies (int numberEaten)
	{
		numberEaten = kids * portion;
		leftovers = cookies - numberEaten;
		return leftovers;
	}
}
