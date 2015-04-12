using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	public GUITexture pausedImage;
	public GUITexture play;
	public GUITexture back;	
	private float savedtimescale;
	// Use this for initialization
	void Start () {
		//pausedImage.enabled = false;
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
		Object[] myObjects=FindObjectsOfType(typeof(GameObject));
		foreach(GameObject go in myObjects)
		{
			go.SendMessage("ResumeGame",SendMessageOptions.DontRequireReceiver);						
			
		}

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
}
