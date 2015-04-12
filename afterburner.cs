using UnityEngine;
using System.Collections;

public class afterburner : MonoBehaviour {
	public GameObject propulsion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate (propulsion, transform.position, transform.rotation);
	}
}
