using UnityEngine;
using System.Collections;

public class MidtermController : MonoBehaviour {

	public enum inventory {health = 100, ammo = 27, water = 73, food= 8} 

	public inventory myInventory;
	public int intOne;
	public int intTwo;

	int ChangeOperation (int x, int y){
		int temp = 0;
		switch (myInventory) {
		case inventory.health:
			print (inventory.health);
			break;
		case inventory.ammo:
			
			break;
		case inventory.water:
			temp = x * y;
			break;
		case inventory.food:
			temp = x / y;
			break;
		default:
			Debug.Log ("error");
			break;
		}
		return temp;
	}


}
