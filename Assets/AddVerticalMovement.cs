using UnityEngine;
using System.Collections;

public class AddVerticalMovement : MonoBehaviour {

	public GameObject _player_GP;
	private float tmpPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tmpPos = _player_GP.transform.position.y;
		this.transform.localPosition = new Vector3 (transform.localPosition.x, tmpPos, transform.localPosition.z);
	}
}
