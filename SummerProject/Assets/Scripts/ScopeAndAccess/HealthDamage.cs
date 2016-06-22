using UnityEngine;
using System.Collections;

public class HealthDamage : MonoBehaviour {

	public Mutliplayer mP;

	void OnMouseDown (){
		foreach (PlayerHealth health in mP.players) {
			if (health.username == this.name) { 								//this.name ref the gameobjects name
				print (health.TakeDownDefense() + " : " + health.username);
			}
		}
	}
}
