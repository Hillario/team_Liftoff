using UnityEngine;
using System.Collections;

public class Accelerate : MonoBehaviour {
	public float movespeed=10f;
	public float offset=10f;//declare the transfom position
	void MoveBackground()
	{
		offset+=movespeed*Time.deltaTime;//increase the value of offset per frame rate
		renderer.material.SetTextureOffset("_MainTex",new Vector2(offset,0f));
	}	
	// Update is called once per frame
	void Update () {
	MoveBackground();
	}
}
