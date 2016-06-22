[System.Serializable]
public class PlayerHealth {

	//this is our players base health data
	public int currentHealth;
	public int strength;
	public int speed = 25;
	protected int defense= 100; //works as both a private and protected var
	public string username;

	public int TakeDownDefense () {
		currentHealth -= 10;
		return currentHealth;
	}

}
