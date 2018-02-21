using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour {

	public GameObject effectObject;

	// Use this for initialization
	void Start () {
		effectObject.SetActive (false);
	}
	void OnTriggerEnter (Collider otherCollider){
		if (otherCollider.GetComponent<Ball> () != null) {
			//Debug.Log ("Score!");
			effectObject.SetActive(true);
		}
	}
}
