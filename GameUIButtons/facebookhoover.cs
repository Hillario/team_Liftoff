using UnityEngine;
using System.Collections;

public class facebookhoover : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseEnter()
	{
		//event for mouse on the specific GUITexture
		guiTexture.pixelInset = new Rect (3f, 3f, 3f, 3f);
	}
	void OnMouseExit()
	{
		//event when mouse pointer leaves the GUITexture
		guiTexture.pixelInset = new Rect (0f, 0f, 0f, 0f);
	}
	void OnMouseDown()
	{
		//event when the GUiTexture is clicked
		//Application.ExternalEval("window.open('http://www.facebook.com/codorpstudios','_blank')");
	}
}
