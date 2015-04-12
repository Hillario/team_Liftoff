using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float rotateSpeed=60f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//rotate the ship		
		transform.Rotate(new Vector3(0f,rotateSpeed*Time.deltaTime,0f),Space.World);
	}
}
