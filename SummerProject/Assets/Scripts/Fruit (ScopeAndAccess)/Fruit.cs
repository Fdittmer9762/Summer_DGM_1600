using UnityEngine;
using System.Collections;

public class Fruit { //monodevelop must be removed in order to access anything from the script without being instanciated

	protected int apples;
	private int bananas;
	public int lemons; //this will be overriden by anything within a function;

	public void AddApples (int moreApples){
		apples += moreApples; //more apples can only be accessed by the AddApples script
	}

	public void AddBananas (int moreBananas){
		bananas += moreBananas; //more bananas can only be accessed by the AddBAnanas script
	}

	public int MixedFruit (){
		return apples + bananas + lemons;
	}

	private void EatFruit (int portion){
		apples-= portion;
		bananas-= portion;
		lemons-= portion;
	}
}
