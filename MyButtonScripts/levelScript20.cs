using UnityEngine;
using System.Collections;

public class levelScript20 : MonoBehaviour {
	//variables for the score limits that determines the level.
	public float scoreLevel20;
	public int randomParameter;
	//get the saved highscore
	private float scoreDeterminant;
	public static bool checker;
	void Start () {
		checker = false;
		scoreDeterminant = PlayerPrefs.GetFloat ("ultimateScore");
		if (scoreDeterminant >= scoreLevel20) {
			guiTexture.enabled = true;
		} else {
			guiTexture.enabled=false;
		}
	}
	// Update is called once per frame
	void Update () {
		HANDHELD_TOUCH ("Level 20");
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
		checker = true;
		Obstacle.maxRandom = randomParameter;
		//event to open the main level for the game
		Application.LoadLevel ("level1");
	}
	public void HANDHELD_TOUCH(string mylevel)
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
				checker = true;
				//set parameter here first
				Obstacle.maxRandom = randomParameter;
				levelScript.levelString = mylevel;
				//event to open the main level for the game
				Application.LoadLevel ("level1");
			}
		}
	}
}
