using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bronzeClick : MonoBehaviour {
	void OnMouseDown () {
		step_1.bronzeSupply -= 1;
		step_1.playerScore += 1;  
		step_1.bronzePlayer += 1;
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
