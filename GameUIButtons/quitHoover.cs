using UnityEngine;
using System.Collections;

public class quitHoover : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape))
		{
			//quit the application
			Application.Quit();
		}
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
		Application.Quit();
	}
}
