using UnityEngine;
using System.Collections;

public class twitterHoover : MonoBehaviour {
	// Use this for initialization
	private float myscore;
	void Start () {
		myscore = PlayerPrefs.GetFloat ("ultimateScore");
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
		//event when the GUiTexture is clicked,,,,tweet the weed out nigga!!
		MainMenu.Tweet ("#teamliftoff I got " + myscore + " points while dodging asteroids in Liftoff.BEAT THAT!!! powered by NASA and IBM Bluemix", "https://twitter.com/codorpsgames", "https://twitter.com/codorpsgames", "en");
	}
}
