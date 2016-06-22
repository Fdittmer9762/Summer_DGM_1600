using UnityEngine;
using System.Collections;

public class Mutliplayer : MonoBehaviour {

	public PlayerHealth[] players;

	void Start (){
		foreach (PlayerHealth player in players) {
			print (player.username + " : " + player.currentHealth);
			int currentHealth = player.TakeDownDefense();
			print (currentHealth);
		}
	}
}
