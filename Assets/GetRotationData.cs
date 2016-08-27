using UnityEngine;
using System.Collections;

public class GetRotationData : MonoBehaviour {

	public GameObject _DATA_INPUT;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		this.transform.rotation = _DATA_INPUT.transform.rotation;

	}
}
