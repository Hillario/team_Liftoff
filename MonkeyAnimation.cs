using UnityEngine;
using System.Collections;

public class MonkeyAnimation : MonoBehaviour {
	private GameObject slide;//the slideGUITexture
	private Vector2 fp;//first finger position
	private Vector2 lp;//last finger position	
	public AudioClip woosh;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		slide=GameObject.FindWithTag("slide");
	//move monkey
		//move monkey
		
		foreach(Touch touch in Input.touches)
{
if (touch.phase == TouchPhase.Began)
{
fp = touch.position;
lp = touch.position;
}
if (touch.phase == TouchPhase.Moved )
{
lp = touch.position;
}
if(touch.phase == TouchPhase.Ended)
{
if((fp.x - lp.x) > 80) // left swipe
{
//animation for left swipe
		slide.animation.Play("slide",PlayMode.StopAll);	
		animation.Play("returnup",PlayMode.StopAll);
					audio.PlayOneShot(woosh);
}
else if((fp.x - lp.x) < -80) // right swipe
{
//animation for right swipe
					
}
else if((fp.y - lp.y) < -80 ) // up swipe
{
//animation for up swipe
			
}
				else if((fp.y - lp.y)> 80 )//down swipe
				{
					//animation for down swipe
					animation.Play("slideDown",PlayMode.StopAll);
					slide.animation.Play("returnside",PlayMode.StopAll);
					audio.PlayOneShot(woosh);
				}
}
		
}
		
	}
}
