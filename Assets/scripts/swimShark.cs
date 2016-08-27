using UnityEngine;
using System.Collections;

public class swimShark : MonoBehaviour {

	float speed = 2f;
	float rotation = 5.0f;

	float r1; 

	float test = 5.0f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		r1 = Mathf.Cos(Time.time * speed + 0.0f) * rotation;

		Quaternion rotation1 = Quaternion.Euler(270.0f, 0.0f, r1+test);

		transform.localRotation = rotation1;

	}

}