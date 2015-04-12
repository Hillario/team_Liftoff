using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
   public GUITexture pausedImage;
	public GUITexture play;
	public GUITexture back;	
	private float savedtimescale;		
	void Awake()
	{
	    
		pausedImage.enabled=false;
		play.enabled=false;
	}
	// Use this for initialization
	void Start () {		
	// set the desired aspect ratio (the values in this example are
    // hard-coded for 16:9, but you could make them into public
    // variables instead so you can set them at design time)
    float targetaspect = 16.0f / 9.0f;

    // determine the game window's current aspect ratio
    float windowaspect = (float)Screen.width / (float)Screen.height;

    // current viewport height should be scaled by this amount
    float scaleheight = windowaspect / targetaspect;

    // obtain camera component so we can modify its viewport
    Camera camera = GetComponent<Camera>();

    // if scaled height is less than current height, add letterbox
    if (scaleheight < 1.0f)
    {  
        Rect rect = camera.rect;

        rect.width = 1.0f;
        rect.height = scaleheight;
        rect.x = 0;
        rect.y = (1.0f - scaleheight) / 2.0f;
        
        camera.rect = rect;
    }
    else // add pillarbox
    {
        float scalewidth = 1.0f / scaleheight;

        Rect rect = camera.rect;

        rect.width = scalewidth;
        rect.height = 1.0f;
        rect.x = (1.0f - scalewidth) / 2.0f;
        rect.y = 0;

        camera.rect = rect;
    }
	}
	
	// Update is called once per frame
	void Update () {
		//PAUSE_ALL ();
		//RESUME_ALL ();
	/*if(Input.touchCount>0){
			if(pausedImage.HitTest(Input.GetTouch(0).position))
		    {			
			if(Input.GetTouch(0).phase==TouchPhase.Began)
			{				
				//zoom in texture
					pausedImage.guiTexture.pixelInset=new Rect(-64f,-7.86f,37.9f,35.7f);
			}
				if(Input.GetTouch(0).phase==TouchPhase.Ended)
				{
					//zoom out GUI Texture
					pausedImage.guiTexture.pixelInset=new Rect(-64f,-7.86f,47.9f,45.7f);
				pausedImage.enabled=false;
				play.enabled=true;
				back.enabled=false;	
				Object[] myObjects=FindObjectsOfType(typeof(GameObject));
				foreach(GameObject go in myObjects)
				{
					go.SendMessage("PauseGame",SendMessageOptions.DontRequireReceiver);							
					
				}				
				}	
				
			}		
			
		  if(play.HitTest(Input.GetTouch(0).position))
			{
				if(Input.GetTouch(0).phase==TouchPhase.Began)
				{
					play.guiTexture.pixelInset=new Rect(-27.97f,-29f,69.46f,48f);
				
				}	
				if(Input.GetTouch(0).phase==TouchPhase.Ended)
				{
					play.guiTexture.pixelInset=new Rect(-27.97f,-29f,79.46f,58f);
					play.enabled=false;
					pausedImage.enabled=true;
					back.enabled=true;
					Object[] myObjects=FindObjectsOfType(typeof(GameObject));
				foreach(GameObject go in myObjects)
				{
					go.SendMessage("ResumeGame",SendMessageOptions.DontRequireReceiver);						
					
				}
				}
			}
			if(back.HitTest(Input.GetTouch(0).position))
			{
				if(Input.GetTouch(0).phase==TouchPhase.Began)
				{
					back.guiTexture.pixelInset=new Rect(-64f,-40.45f,49.4f,31.1f);
					
				}
				if(Input.GetTouch(0).phase==TouchPhase.Ended)
				{
					back.guiTexture.pixelInset=new Rect(-64f,-40.45f,59.4f,41.1f);
					Application.LoadLevel(1);
				}
			}
			
		}*/		
		
	}
	
	
	public void PauseGame()
	{
		savedtimescale=Time.timeScale;
		Time.timeScale=0;		
		AudioListener.pause=true;		
	}	
	public void ResumeGame()
	{		
		Time.timeScale=savedtimescale;		
		AudioListener.pause=false;
	}
	void PAUSE_ALL()
	{
		//detect touch input
		foreach (Touch mytouch in Input.touches) {
			if(mytouch.phase==TouchPhase.Stationary && pausedImage.HitTest(mytouch.position))
			{
				//zoom pixel inset
				pausedImage.pixelInset=new Rect(3f,3f,3f,3f);
			}
			else if(mytouch.phase==TouchPhase.Ended && pausedImage.HitTest(mytouch.position))
			{
				//event here
				pausedImage.pixelInset=new Rect(0f,0f,0f,0f);
				//pause the game
				pausedImage.enabled=false;
				play.enabled=true;
				back.enabled=false;	
				Object[] myObjects=FindObjectsOfType(typeof(GameObject));
				foreach(GameObject go in myObjects)
				{
					go.SendMessage("PauseGame",SendMessageOptions.DontRequireReceiver);							
					
				}				
			}
		}
	}
	void RESUME_ALL()
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
				//resume game here
				play.enabled=false;
				pausedImage.enabled=true;
				back.enabled=true;
				Object[] myObjects=FindObjectsOfType(typeof(GameObject));
				foreach(GameObject go in myObjects)
				{
					go.SendMessage("ResumeGame",SendMessageOptions.DontRequireReceiver);						
					
				}
			}
		}
	}
}
