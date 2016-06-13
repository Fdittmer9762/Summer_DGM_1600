using UnityEngine;
using System.Collections;

public class BaseWeapon : MonoBehaviour {

	public BaseAmmo thisAmmo;

	void Update () {
		thisAmmo.Fire ();
	}
}
