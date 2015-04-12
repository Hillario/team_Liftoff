using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseEnter()
	{
		//zoom pixel inset
		guiTexture.pixelInset=new Rect(3f,3f,3f,3f);
	}
	void OnMouseExit()
	{
		guiTexture.pixelInset=new Rect(0f,0f,0f,0f);
	}
	void OnMouseDown()
	{
		//continue
		
	}

}
