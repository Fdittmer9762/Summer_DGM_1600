using UnityEngine;
using System.Collections;

public class MidtermController : MonoBehaviour {

	public enum inventory {health = 100, ammo = 27, water = 73, food= 8} 

	public MyPowerUps powerUps;
	public inventory myInventory;
	public int intOne;
	public int intTwo;

	int ChangeOperation (int x, int y){
		switch (myInventory) {
		case inventory.health:
			print (powerUps.PowerUp (x, y));
			inventory.health = x;
			break;
		case inventory.ammo:
			print (powerUps.PowerUp (inventory.ammo, intTwo));
			break;
		case inventory.water:
			print (powerUps.PowerUp (inventory.water, intTwo));
			break;
		case inventory.food:
			print (powerUps.PowerUp (inventory.food, intTwo));
			break;
		default:
			Debug.Log ("error");
			break;
		}
	}

	void OnMouseDown (){
		ChangeOperation (intOne, intTwo);
	}
}
