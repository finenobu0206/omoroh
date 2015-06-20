using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {

	float timer;
	int waitingTime;

	// Use this for initialization
	void Start () {
		timer = 0;
		waitingTime = 2;
//		this.SendMessage ("Explode");
	}
	// Update is called once per frame
	void Update () {
	timer += Time.deltaTime;
	if (timer > waitingTime) {
		//Action
			this.SendMessage ("Explode");
			timer = 0;
		}
	}
}