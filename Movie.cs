using UnityEngine;
using System.Collections;

public class Movie : MonoBehaviour {
	private float killscene=2f;
	// Use this for initialization
	void Start () {
	//play splash
//		Handheld.PlayFullScreenMovie("splash.mp4",Color.black,FullScreenMovieControlMode.CancelOnInput);
		
	}
	
	// Update is called once per frame
	void Update () {
	killscene-=Time.deltaTime;
		if(killscene<=0)
		{
            //do not load the main menu if on unity player
			Application.LoadLevel(1);
		}
	}
}
