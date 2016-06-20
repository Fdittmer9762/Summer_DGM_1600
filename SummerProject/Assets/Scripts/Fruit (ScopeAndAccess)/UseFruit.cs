using UnityEngine;
using System.Collections;

public class UseFruit : MonoBehaviour { //monobehaviour makes it an instance of the script and must be instanciated before it can be accessed

	private Fruit MyFruit;

	void Start (){
		MyFruit = new Fruit (); //this can be done within or outside of the function
		MyFruit.AddApples (10);
		MyFruit.AddBananas (5);
		MyFruit.lemons = 6;
		int allFruit = MyFruit.MixedFruit ();
		print (allFruit);
	}


}
