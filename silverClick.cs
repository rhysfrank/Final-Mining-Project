using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silverClick : MonoBehaviour {
	void OnMouseDown () {
		step_1.silverSupply -= 1;
		step_1.playerScore += 10;  
		step_1.silverPlayer += 1; 
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
