using UnityEngine;
using System.Collections;

public class levelScript2 : MonoBehaviour {
	//variables for the score limits that determines the level.
	public float scoreLevel2;
	public int RandomParameter;
	//get the saved highscore
	private float scoreDeterminant;
	public static bool checker;
	void Start () {
		checker = false;
		//guiTexture.enabled=true;
		scoreDeterminant = PlayerPrefs.GetFloat ("ultimateScore");
		if (scoreDeterminant >= scoreLevel2) {
						guiTexture.enabled = true;
				} else {
			guiTexture.enabled=false;
				}
	}
	// Update is called once per frame
	void Update () {
		HANDHELD_TOUCH("Mercury:77,000,000KM");
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
		//set parameter here first
		Obstacle.maxRandom = RandomParameter;
		levelScript.levelString="Mercury:77,000,000KM";
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
				Obstacle.maxRandom = RandomParameter;
				levelScript.levelString = mylevel;
				//event to open the main level for the game
				Application.LoadLevel ("level1");
			}
		}
	}
}
