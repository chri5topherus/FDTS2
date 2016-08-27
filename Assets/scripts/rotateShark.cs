using UnityEngine;
using System.Collections;

public class rotateShark : MonoBehaviour {

	private float rotateSpeed = 6F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
	}
}
