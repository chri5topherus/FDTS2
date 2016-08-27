using UnityEngine;
using System.Collections;

public class liftAnimation : MonoBehaviour {

	public GameObject _player;
	public GameObject _playerParent;
	private float platformStartY;

	private bool down;
	private bool wait;

	// Use this for initialization
	void Start () {
		down = true;
		platformStartY = transform.position.y;
		wait = false;
	}
	
	// Update is called once per frame
	void Update () {

	}



	void OnTriggerEnter(Collider other) {
		Debug.Log ("touched");
		//start lift after 1 sec

		if (!wait) {
			if (down)
				StartCoroutine (startLiftUp ());
			else
				StartCoroutine (startLiftDown ());

		}
	}



	IEnumerator startLiftUp() {
		wait = true;
		yield return new WaitForSeconds(1);
		down = false;
		_player.transform.SetParent (this.gameObject.transform);
		iTween.MoveTo(this.gameObject,iTween.Hash("position", new Vector3  (transform.position.x, 8.24f, transform.position.z),"easetype",iTween.EaseType.easeInOutSine,"time",10.0f));
		StartCoroutine (exitLift ());
	}




	IEnumerator startLiftDown() {
		wait = true;
		down = true;
		yield return new WaitForSeconds(1);
		_player.transform.SetParent (this.gameObject.transform);
		iTween.MoveTo(this.gameObject,iTween.Hash("position", new Vector3  (transform.position.x, platformStartY, transform.position.z),"easetype",iTween.EaseType.easeInOutSine,"time",10.0f));
		StartCoroutine (exitLift ());

	}

	IEnumerator exitLift() {
		yield return new WaitForSeconds(11);
		_player.transform.SetParent (_playerParent.transform);
		wait = false;
	}
		

}
