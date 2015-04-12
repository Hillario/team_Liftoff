using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	const string AppId = "281115298711309";
const string ShareUrl = "http://www.facebook.com/dialog/feed";
	//class for sharing in facebook
public static void Share(string link, string pictureLink, string name,
    string caption, string description, string redirectUri)
{
    Application.OpenURL(ShareUrl +
        "?app_id=" + AppId +
        "&amp;link=" + WWW.EscapeURL( link )+
        "&amp;picture=" + WWW.EscapeURL(pictureLink) +
        "&amp;name=" + WWW.EscapeURL(name) +
        "&amp;caption=" + WWW.EscapeURL(caption) +
        "&amp;description=" + WWW.EscapeURL(description) +
        "&amp;redirect_uri=" + WWW.EscapeURL(redirectUri));
}
	//class for sharing in twitter
	const string Address = "http://twitter.com/intent/tweet";

public static void Tweet(string text, string url,
    string related, string lang)
{
    Application.OpenURL(Address +
        "?text=" + WWW.EscapeURL(text) +
        "&amp;url=" + WWW.EscapeURL(url) +
        "&amp;related=" + WWW.EscapeURL(related) +
        "&amp;lang=" + WWW.EscapeURL(lang));
}
	public GUITexture play;
	public GUITexture extras;
	public GUITexture highscores;	
	public GUITexture quit;			
	private Vector2 difference;
	public GUITexture slideStats;
	public GUITexture facebook;
	public GUITexture twitter;
	public float score=0f;
	void Awake()
	{
		slide();
	
	}
	void slide()
	{	
		//swipe the GUItexture
		slideStats.animation.Play("slide");
		
	}
	// Use this for initialization
	void Start () {
		//start ads from addbizz
		AdBuddizBinding.SetAndroidPublisherKey("793ba9ae-9baf-42be-85e7-dec59a7f1c4a");
		AdBuddizBinding.CacheAds();
		//disable quit for web
		//quit.enabled = false;
	//prevent phone from sleeping
	Screen.sleepTimeout=SleepTimeout.NeverSleep;
	score=PlayerPrefs.GetFloat("ultimateScore");	
		//AdBuddizBinding.ShowAd();
	}
	
	// Update is called once per frame
	void Update () {	
		//exit applcation
		if (Input.GetKey (KeyCode.Escape)) {
			//application quit
			Application.Quit();
				}
		//GUITexture controls
		PLAY ();
		FACEBOOK ();
		TWITTER ();
		QUIT ();
			if (Input.GetButtonDown("Jump"))
            {
                Application.LoadLevel("LevelSelect");
            }
	/*if(Input.touchCount>0)
		{
			if(play.HitTest(Input.GetTouch(0).position))
			{
				if(Input.GetTouch(0).phase==TouchPhase.Began)
				{
					//zoom in event here
					play.guiTexture.pixelInset=new Rect(-64f,75.1f,90f,40f);
					
				}
				if(Input.GetTouch(0).phase==TouchPhase.Ended)
				{
					//original position
					play.guiTexture.pixelInset=new Rect(-64f,75.1f,100f,50f);
					Application.LoadLevel(1);
				}
			}			
			if(quit.HitTest(Input.GetTouch(0).position))
			{
				if(Input.GetTouch(0).phase==TouchPhase.Began)
				{
					//zoom in event here
					quit.guiTexture.pixelInset=new Rect(-64f,35.3f,90f,40f);
					
				}
				if(Input.GetTouch(0).phase==TouchPhase.Ended)
				{
					//original event here
					quit.guiTexture.pixelInset=new Rect(-64f,35.3f,100f,50f);
					Application.Quit();
				}
			}
			if(facebook.HitTest(Input.GetTouch(0).position))
			{
				if(Input.GetTouch(0).phase==TouchPhase.Began)
				{
					//zoom out facebook icon
					facebook.guiTexture.pixelInset=new Rect(-58.3f,-100f,90f,40f);
				}
				if(Input.GetTouch(0).phase==TouchPhase.Ended)
				{
					facebook.guiTexture.pixelInset=new Rect(-58.3f,-100f,100f,50f);					
					Application.OpenURL("www.facebook.com/codorpstudios");
				}
			}
			if(twitter.HitTest(Input.GetTouch(0).position))
			{
				if(Input.GetTouch(0).phase==TouchPhase.Began)
				{
					twitter.guiTexture.pixelInset=new Rect(104.8f,-100f,90f,40f);
				}
				if(Input.GetTouch(0).phase==TouchPhase.Ended)
				{
					twitter.guiTexture.pixelInset=new Rect(104.8f,-100f,100f,50f);					
					Tweet("I got "+score+" points while dodging poisonous balls in Hajteron.BEAT THAT!!!","https://www.facebook.com/codorpstudios","https://twitter.com/codorpsgames","en");
				}
			}
		}
		/*if(Input.GetKeyDown(KeyCode.F))
		{
			Application.OpenURL("www.facebook.com/codorpstudios");
		}
		if(Input.GetKeyDown(KeyCode.T))
		{
            Tweet("I got " + score + " points while dodging poisonous balls in Hajteron.BEAT THAT!!! Hajteron.codorps.com", "https://twitter.com/codorpsgames", "https://twitter.com/codorpsgames", "en");            
		}*/
}
	void PLAY()
	{

			//detect touch input
			foreach (Touch mytouch in Input.touches) {
				if(mytouch.phase==TouchPhase.Stationary && play.HitTest(mytouch.position))
				{
					//zoom pixel inset
					play.pixelInset=new Rect(3f,3f,3f,3f);
				}
				else if(mytouch.phase==TouchPhase.Ended && play.HitTest(mytouch.position))
				{
					//event here
					play.pixelInset=new Rect(0f,0f,0f,0f);					
				Application.LoadLevel ("LevelSelect");
				}
		}
	}
	void QUIT()
	{
		
		//detect touch input
		foreach (Touch mytouch in Input.touches) {
			if(mytouch.phase==TouchPhase.Stationary && quit.HitTest(mytouch.position))
			{
				//zoom pixel inset
				quit.pixelInset=new Rect(3f,3f,3f,3f);
			}
			else if(mytouch.phase==TouchPhase.Ended && quit.HitTest(mytouch.position))
			{
				//event here
				quit.pixelInset=new Rect(0f,0f,0f,0f);					
				Application.Quit();
			}
		}
	}
	void FACEBOOK()
	{
		
		//detect touch input
		foreach (Touch mytouch in Input.touches) {
			if(mytouch.phase==TouchPhase.Stationary && facebook.HitTest(mytouch.position))
			{
				//zoom pixel inset
				facebook.pixelInset=new Rect(3f,3f,3f,3f);
			}
			else if(mytouch.phase==TouchPhase.Ended && facebook.HitTest(mytouch.position))
			{
				//event here
				facebook.pixelInset=new Rect(0f,0f,0f,0f);					
				Application.OpenURL("www.facebook.com/codorpstudios");
			}
		}
	}
	void TWITTER()
	{
		//detect touch input
		foreach (Touch mytouch in Input.touches) {
			if(mytouch.phase==TouchPhase.Stationary && twitter.HitTest(mytouch.position))
			{
				//zoom pixel inset
				twitter.pixelInset=new Rect(3f,3f,3f,3f);
			}
			else if(mytouch.phase==TouchPhase.Ended && twitter.HitTest(mytouch.position))
			{
				//event here
				twitter.pixelInset=new Rect(0f,0f,0f,0f);					
				//event when the GUiTexture is clicked,,,,tweet the weed out nigga!!
				MainMenu.Tweet ("#teamliftoff I got " + score + " points while dodging asteroids in Liftoff.BEAT THAT!!! powered by NASA and IBM Bluemix", "https://twitter.com/codorpsgames", "https://twitter.com/codorpsgames", "en");
			}
		}
	}
}
	

