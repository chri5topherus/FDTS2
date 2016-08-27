using UnityEngine;
using System.Collections;

public class changeConstantForce : MonoBehaviour {

	ConstantForce force;
	float currentForce;
	int counter = 0;

	// Use this for initialization
	void Start () {
		currentForce = 0f;
		force = this.GetComponent<ConstantForce> ();
	}
	
	// Update is called once per frame
	void Update () {
		counter = counter + 1; 
		if (counter == 300) {
			updateForce ();
			counter = 0;
		}
	}


	void updateForce() {
		if (currentForce == 0) {
			force.force = new Vector3 (0, 0.5f, 0);
			currentForce = 1;
			//Debug.Log ("zero");
		} else { 
			force.force = new Vector3 (0, 0.0f, 0);
			currentForce = 0;
			//Debug.Log ("1");
		}

	}



}
