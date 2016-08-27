using UnityEngine;
using System.Collections;

public class GetPositionData : MonoBehaviour {

	public GameObject _DATA_INPUT;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (_DATA_INPUT.transform.position.x, _DATA_INPUT.transform.position.y, _DATA_INPUT.transform.position.z);
	}
}
