using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldClick : MonoBehaviour {
	void OnMouseDown () {
		step_1.goldSupply -= 1;
		step_1.playerScore += 100; 
		step_1.goldPlayer += 1; 
		step_1.PrintScore ();
		Destroy (gameObject);

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
