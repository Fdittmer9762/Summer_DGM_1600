using UnityEngine;
using System.Collections;
[System.Serializable]
public class BaseAmmo {

	//This controls the amount and powerlevel of the ammo
	public int ammoCount;
	public int ammoPower;

	public void Fire(){
		while (ammoCount > 0) {
			--ammoCount;
			Debug.Log ("Ammo: " + ammoCount);
		}
		Debug.Log ("*click*");
	}
}
