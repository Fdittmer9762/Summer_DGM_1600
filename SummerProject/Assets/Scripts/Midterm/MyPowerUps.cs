using UnityEngine;
using System.Collections;

public class MyPowerUps : MonoBehaviour {

	public int PowerUp(int stat, int mag){
		stat += mag;
		return stat;
	}

}
