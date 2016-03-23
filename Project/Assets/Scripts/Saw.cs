using UnityEngine;
using System.Collections;

public class Saw : MonoBehaviour {

	public float velocity;
	// Use this for initialization
	void Start () {
		velocity = 400f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,0,velocity*Time.deltaTime);
	}
}
