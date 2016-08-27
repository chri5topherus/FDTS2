using UnityEngine;
using System.Collections;

public class GetLocalOriginPosition : MonoBehaviour {

	public GameObject _localOrigin;
	public Rigidbody rigidBodyPlayer;

	// Use this for initialization
	void Start () {
		rigidBodyPlayer = this.GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		rigidBodyPlayer.MovePosition(new Vector3 (_localOrigin.transform.position.x, transform.position.y, _localOrigin.transform.position.z)) ;
	}
}
