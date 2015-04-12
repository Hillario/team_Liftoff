using UnityEngine;
using System.Collections;
public class SavedScores : MonoBehaviour {	
	private float achievedScore=0f;
	GUIStyle ganamStyle;
	public Font sysFont;
	public GUIText stats;
	public Font fontStats;
	private float bestScore=0f;
	private int red;
	private int green;
	private int yellow;
	public GUIText redtext;
	public GUIText yellowtext;
	public GUIText greentext;
	public GUIText network;
	public AudioClip mainmusic;
	public GUIText creator;
	public GUIText creditSounds;
	public GUIText devicemodel;
	public GUIText graphicsName;
	public GUIText graphicssize;
	public AudioClip crowd;
	public GUITexture gauge10;
	public GUITexture gauge20;
	public GUITexture gauge30;
	public GUITexture gauge40;
	public GUITexture gauge50;
	public GUITexture gauge60;
	public GUITexture gauge70;
	public GUITexture gauge80;
	public GUITexture gauge90;
	public GUITexture gauge100;
	public float concentration;
	// Use this for initialization
	void Start () {		
	    bestScore=PlayerPrefs.GetFloat("ultimateScore");
		achievedScore=PlayerPrefs.GetFloat("normalscore");
		red=PlayerPrefs.GetInt("redsaved");
		yellow=PlayerPrefs.GetInt("yellowsaved");
		green=PlayerPrefs.GetInt("greensaved");
		if(achievedScore>bestScore)
		{
			//play crowd sfx
			audio.PlayOneShot(crowd);
		}
		concentration = (achievedScore / bestScore) * 100;
	}
	// Update is called once per frame
	void Update () {
		concentrationGauge ();
	}
	//when the graphical user interface is loaded by the liveware.
	void OnGUI()
	{
		ganamStyle=new GUIStyle();
		ganamStyle.fontSize=22;
		ganamStyle.font=sysFont;
		ganamStyle.normal.textColor=Color.blue;		
		
		GUI.Label(new Rect(40,20,50,50),"Best Score:"+bestScore,ganamStyle);
		//font style
		stats.font=fontStats;
		stats.fontSize=32;
		stats.material.color=Color.black;
		stats.text="Score:"+achievedScore;
		redtext.font=fontStats;
		redtext.fontSize=24;
		redtext.material.color=Color.red;
		redtext.text="Mathilde asteroids| Multiplier(x1):"+red;
		yellowtext.font=fontStats;
		yellowtext.fontSize=24;
		yellowtext.material.color=Color.yellow;
		yellowtext.text="Ida asteroids| Multiplier(x2):"+yellow;
		greentext.font=fontStats;
		greentext.fontSize=24;
		greentext.material.color=Color.green;
		greentext.text="Eros Asteroids | Multiplier(x3):"+green;
		network.font=fontStats;
		network.fontSize=24;
		network.material.color=Color.magenta;
		network.text="Send Data          to mission control!!";
		creator.font=fontStats;
		creator.fontSize=18;
		creator.material.color=Color.black;
		creator.text="CodOrps Interactive";
		creditSounds.font=fontStats;
		creditSounds.fontSize=18;
		creditSounds.material.color=Color.yellow;
		creditSounds.text="freesfx.co.uk";
		devicemodel.font=fontStats;
		devicemodel.fontSize=18;
		devicemodel.material.color=Color.cyan;
		devicemodel.text=SystemInfo.deviceModel.ToString();
		graphicsName.font=fontStats;
		graphicsName.fontSize=18;
		graphicsName.material.color=Color.cyan;
		graphicsName.text=SystemInfo.graphicsDeviceName.ToString();
		graphicssize.font=fontStats;
		graphicssize.fontSize=18;
		graphicssize.material.color=Color.yellow;
		graphicssize.text=SystemInfo.graphicsMemorySize+"MiB";
	}
	void concentrationGauge()
	{
		if (concentration >= 0 && concentration <= 10) {

				} else if (concentration > 10 && concentration <= 20) {
			gauge10.enabled=true;
			gauge20.enabled=false;
			gauge30.enabled=false;
			gauge40.enabled=false;
			gauge50.enabled=false;
			gauge60.enabled=false;
			gauge70.enabled=false;
			gauge80.enabled=false;
			gauge90.enabled=false;
			gauge100.enabled=false;
				}
		else if (concentration > 10 && concentration <= 20) {
			gauge10.enabled=false;
			gauge20.enabled=true;
			gauge30.enabled=false;
			gauge40.enabled=false;
			gauge50.enabled=false;
			gauge60.enabled=false;
			gauge70.enabled=false;
			gauge80.enabled=false;
			gauge90.enabled=false;
			gauge100.enabled=false;
		}
		else if (concentration > 20 && concentration <= 30) {
			gauge10.enabled=false;
			gauge20.enabled=false;
			gauge30.enabled=true;
			gauge40.enabled=false;
			gauge50.enabled=false;
			gauge60.enabled=false;
			gauge70.enabled=false;
			gauge80.enabled=false;
			gauge90.enabled=false;
			gauge100.enabled=false;
		}
		else if (concentration > 30 && concentration <= 40) {
			gauge10.enabled=false;
			gauge20.enabled=false;
			gauge30.enabled=false;
			gauge40.enabled=true;
			gauge50.enabled=false;
			gauge60.enabled=false;
			gauge70.enabled=false;
			gauge80.enabled=false;
			gauge90.enabled=false;
			gauge100.enabled=false;
		}
		else if (concentration > 40 && concentration <= 50) {
			gauge10.enabled=false;
			gauge20.enabled=false;
			gauge30.enabled=false;
			gauge40.enabled=false;
			gauge50.enabled=true;
			gauge60.enabled=false;
			gauge70.enabled=false;
			gauge80.enabled=false;
			gauge90.enabled=false;
			gauge100.enabled=false;
		}
		else if (concentration > 50 && concentration <= 60) {
			gauge10.enabled=false;
			gauge20.enabled=false;
			gauge30.enabled=false;
			gauge40.enabled=false;
			gauge50.enabled=false;
			gauge60.enabled=true;
			gauge70.enabled=false;
			gauge80.enabled=false;
			gauge90.enabled=false;
			gauge100.enabled=false;
		}
		else if (concentration > 60 && concentration <= 70) {
			gauge10.enabled=false;
			gauge20.enabled=false;
			gauge30.enabled=false;
			gauge40.enabled=false;
			gauge50.enabled=false;
			gauge60.enabled=false;
			gauge70.enabled=true;
			gauge80.enabled=false;
			gauge90.enabled=false;
			gauge100.enabled=false;
		}
		else if (concentration > 70 && concentration <= 80) {
			gauge10.enabled=false;
			gauge20.enabled=false;
			gauge30.enabled=false;
			gauge40.enabled=false;
			gauge50.enabled=false;
			gauge60.enabled=false;
			gauge70.enabled=false;
			gauge80.enabled=true;
			gauge90.enabled=false;
			gauge100.enabled=false;
		}
		else if (concentration > 80 && concentration <= 90) {
			gauge10.enabled=false;
			gauge20.enabled=false;
			gauge30.enabled=false;
			gauge40.enabled=false;
			gauge50.enabled=false;
			gauge60.enabled=false;
			gauge70.enabled=false;
			gauge80.enabled=false;
			gauge90.enabled=true;
			gauge100.enabled=false;
		}
		else if (concentration > 90 && concentration <= 100) {
			gauge10.enabled=false;
			gauge20.enabled=false;
			gauge30.enabled=false;
			gauge40.enabled=false;
			gauge50.enabled=false;
			gauge60.enabled=false;
			gauge70.enabled=false;
			gauge80.enabled=false;
			gauge90.enabled=false;
			gauge100.enabled=true;
		}

	}
}
