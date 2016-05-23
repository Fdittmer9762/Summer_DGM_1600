using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour
{
	
	public int myInt;
	//public int yourInt;


	int MyInt (int _i, int _j) //it looks like the underscore is just part of the name. Things can be placed in front of and behind the underscore and it does not affect the int.
	{
		return _i - _j;
	}


	void Start ()
	{
		//myInt = MyInt (20,8);
		//print (myInt);
		 print (MyInt (myInt, 8));
		// would this be easier?
	}


}
