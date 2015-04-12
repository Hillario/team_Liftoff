using UnityEngine;
using System.Collections;

public class back : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			//event to open the main menu for the game
			Application.LoadLevel ("MainMenu");
				}
		RETURN_MAIN_MENU ();
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
		//event to open the main menu for the game
		Application.LoadLevel ("MainMenu");
	}
	void RETURN_MAIN_MENU()
	{
		//detect touch input
		foreach (Touch mytouch in Input.touches) {
			if(mytouch.phase==TouchPhase.Stationary && guiTexture.HitTest(mytouch.position))
			{
				//zoom pixel inset
				guiTexture.pixelInset=new Rect(3f,3f,3f,3f);
			}
			else if(mytouch.phase==TouchPhase.Ended && guiTexture.HitTest(mytouch.position))
			{
				//event here
				guiTexture.pixelInset=new Rect(0f,0f,0f,0f);
				Application.LoadLevel ("MainMenu");
			}
		}
	}
}
