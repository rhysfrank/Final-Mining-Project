using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step_1 : MonoBehaviour {
	public static int bronzePlayer; 
	public static int silverPlayer;
	public int miningSpeed; 
	public static int bronzeSupply; 
	public static int silverSupply; 
	public int timeToMine; 
	public int currentCube;
	public static int goldSupply; 
	public static int goldPlayer; 
	float xPosition; 
	float yPosition;

	public GameObject bronzeSprite;
	Vector3 cubePosition; 
	public GameObject goldSprite; 
	public GameObject silverSprite; 
	bool goldSpawned;
	public static int playerScore; 

	// Use this for initialization
	void Start () {
		bronzePlayer = 0; 
		silverPlayer = 0; 
		miningSpeed = 4; 
		bronzeSupply = 0; 
		silverSupply = 0; 
		timeToMine = 1; 
		xPosition = 0; 
		yPosition = 0; 
		playerScore = 0;
		goldSpawned = false; 
		PrintScore ();



	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timeToMine) {
			// mine some gotdang ore, and update the number of ore the player has

			// only mine bronze if we have at least one in the supply
			if (bronzeSupply == 2 && silverSupply == 2 && goldSupply < 1 && goldSpawned == false) {
				goldSupply += 1; 

				xPosition = Random.Range (-5, 5);
				yPosition = Random.Range (-4, 4);
				cubePosition = new Vector3 (xPosition, yPosition, 0f); 
				Instantiate (goldSprite, cubePosition, Quaternion.identity);
				goldSpawned = true; 
			}
			else if (bronzeSupply < 4) {
				bronzeSupply += 1; 

				xPosition = Random.Range (-5, 5);
				yPosition = Random.Range (-4, 4);
				cubePosition = new Vector3 (xPosition, yPosition, 0f);
				Instantiate (bronzeSprite, cubePosition, Quaternion.identity);
				goldSpawned = false; 
			}
			// only mine silver if there's no bronze in the supply AND we have at least one silver
			else {
				silverSupply += 1; 

				xPosition = Random.Range (-5, 5);
				yPosition = Random.Range (-4, 4);
				cubePosition = new Vector3 (xPosition, yPosition, 0f); 
				Instantiate (silverSprite, cubePosition, Quaternion.identity);
			} 
		
			timeToMine += miningSpeed;

		
		}
	}
	public static void PrintScore () { 
		print ("Bronze: " + bronzePlayer); 
		print ("Silver: " + silverPlayer); 
		print ("Gold: " + goldPlayer);

		print ("Total Score: " + playerScore);
	}
}