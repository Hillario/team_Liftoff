using UnityEngine;
using System.Collections;
public class ScoreSystem : MonoBehaviour {
	public int minRandomNumber=0;
	public int maxRandomNumber=300;
	private int halfRandomNumber;
	private int minusOneRandom;
	public int number;	
	public float score=0f;
	public float health=5f;
	public Font scoreFont;	
	GUIStyle fontsize;
	GUIStyle concentrate;
	public GameObject DieExplosion;
	public float waitDeath=10f;
	public Color lerpedcolor=Color.green;
	public Texture2D lifeImage;	
	public Texture2D scoreImage;
	public string scoreCollider;
	public float normalscore=0f;	
	private float uniqueScore=0f;
	public float ultimateScore=0f;
	private float finalscore=0f;
	public int redCount=0;
	public int greenCount=0;
	public int yellowCount=0;
	public int redsaved;
	public int greensaved;
	public int yellowsaved;
	public AudioClip wrongball;
	public AudioClip rightball;
	public AudioClip explosion;
	public GUITexture death;
	public GUIText mylevelText;
	private int superman;
	public Material skybox1;
	public Material skybox2;
	public Material skybox3;
	public Material skybox4;
	public Material skybox5;
	public Material skybox6;
	public Material skybox7;
	public Material skybox8;
	public Material skybox9;
	public Material skybox10;
	public GUIText myscore;
	public GUIText myhealth;
	public GUIText mystatus;
	// Use this for initialization
	void Awake(){
		superman = PlayerPrefs.GetInt ("Haji");
		Debug.Log (superman.ToString ());
		RenderSettings.skybox=skybox1;
		}
	void Start () {	
		finalscore=PlayerPrefs.GetFloat("ultimateScore");
	Screen.sleepTimeout=SleepTimeout.NeverSleep;		
	}
	void FixedUpdate(){
		death.enabled = false;
		}
	void RandomMethod()
	{
	 //the AI for determining the difficulty of the game
		halfRandomNumber=maxRandomNumber/2;
		minusOneRandom=maxRandomNumber-1;
		number=Random.Range(minRandomNumber,maxRandomNumber);
		if(number==minRandomNumber)
		{
			GameObject.FindWithTag("Green").guiTexture.enabled=true;
			GameObject.FindWithTag("Yellow").guiTexture.enabled=false;
			GameObject.FindWithTag("Red").guiTexture.enabled=false;
			lerpedcolor=Color.Lerp(Color.white,Color.green,Time.time);
			
		}
		else if(number==halfRandomNumber)
		{
			//divide the random number by half the random 
			GameObject.FindWithTag("Green").guiTexture.enabled=false;
			GameObject.FindWithTag("Yellow").guiTexture.enabled=true;
			GameObject.FindWithTag("Red").guiTexture.enabled=false;
			lerpedcolor=Color.Lerp(Color.white,Color.yellow,Time.time);
		}
		else if(number==minusOneRandom)
		{
			//subtract the random number by one
			GameObject.FindWithTag("Green").guiTexture.enabled=false;
			GameObject.FindWithTag("Yellow").guiTexture.enabled=false;
			GameObject.FindWithTag("Red").guiTexture.enabled=true;
			lerpedcolor=Color.Lerp(Color.white,Color.red,Time.time);
		}
		
	}	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.T))
		   {

		}
				if (health > 10) {
						//set the  default max health ==10
						health = 10f;
				}
				//real time level change
		if ( levelScript.checker == true)
		{
			RenderSettings.skybox=skybox1;
			Obstacle.maxRandom = 115;
			mylevelText.text = "Moon:384,400KM";
			Debug.Log("level one");
		}
		
		
		if (levelScript2.checker == true) 
		{
			RenderSettings.skybox=skybox2;
			Obstacle.maxRandom = 110;
			mylevelText.text = "Mercury:77,000,000KM";
			
		}
		else if (levelScript2.checker == false && score >= 50 && score < 90) //70 90
		{
			RenderSettings.skybox=skybox2;
			Obstacle.maxRandom = 110;
			mylevelText.text = "Mercury:77,000,000KM";
		}
		if (levelScript3.checker == true) 
		{
			RenderSettings.skybox=skybox3;
			Obstacle.maxRandom = 105;
			mylevelText.text = "Venus:261,000,000KM";			
		}
		else if (levelScript3.checker == false && score >= 90 && score < 110) //90 110
		{
			RenderSettings.skybox=skybox3;
			Obstacle.maxRandom = 105;
			mylevelText.text = "Venus:261,000,000KM";
		}

		if (levelScript4.checker == true) 
		{		
			RenderSettings.skybox=skybox4;
			Obstacle.maxRandom = 100;
			mylevelText.text = "Mars:225,300,000KM";
			
		}
		else if (levelScript4.checker == false && score >= 110 && score < 130) //110 130
		{
			RenderSettings.skybox=skybox4;
			Obstacle.maxRandom = 100;
			mylevelText.text = "Mars:225,300,000KM";
		}
		if (levelScript5.checker == true) 
		{
			RenderSettings.skybox=skybox5;
			Obstacle.maxRandom = 95;
			mylevelText.text = "Jupiter:588,000,000KM";
			
		}
		else if (levelScript5.checker == false && score >= 130 && score < 150)
		{
			RenderSettings.skybox=skybox5;
			Obstacle.maxRandom = 95;
			mylevelText.text = "Jupiter:588,000,000KM";
		}

		if (levelScript6.checker == true) 
		{			
			RenderSettings.skybox=skybox6;
			Obstacle.maxRandom = 90;
			mylevelText.text = "Saturn:1,200,000,000KM";
			
		}
		else if (levelScript6.checker == false && score >= 150 && score < 170)
		{
			RenderSettings.skybox=skybox6;
			Obstacle.maxRandom = 90;
			mylevelText.text = "Saturn:1,200,000,000KM";
		}
		if (levelScript7.checker == true) 
		{		
			RenderSettings.skybox=skybox7;
			Obstacle.maxRandom = 85;
			mylevelText.text = "Uranus:2,600,000,000KM";
			
		}
		else if (levelScript7.checker == false && score >= 170 && score < 190)
		{
			RenderSettings.skybox=skybox7;
			Obstacle.maxRandom = 85;
			mylevelText.text = "Uranus:2,600,000,000KM";
		}
		if (levelScript8.checker == true) 
		{			
			RenderSettings.skybox=skybox8;
			Obstacle.maxRandom = 80;
			mylevelText.text = "Neptune:2,700,000,000KM";
			
		}
		else if (levelScript8.checker == false && score >= 190 && score < 210)
		{
			RenderSettings.skybox=skybox8;
			Obstacle.maxRandom = 80;
			mylevelText.text = "Neptune:2,700,000,000KM";
		}
		if (levelScript9.checker == true) 
		{			
			RenderSettings.skybox=skybox9;
			Obstacle.maxRandom = 75;
			mylevelText.text = "Sun:149,600,000KM";
			
		}
		else if (levelScript9.checker == false && score >= 210 && score < 230)
		{
			RenderSettings.skybox=skybox9;
			Obstacle.maxRandom = 75;
			mylevelText.text = "Sun:149,600,000KM";
		}
		if (levelscript10.checker == true) 
		{			
			RenderSettings.skybox=skybox10;
			Obstacle.maxRandom = 70;
			mylevelText.text = "Level 10";
			
		}
		else if (levelscript10.checker == false && score >= 230 && score < 250)
		{
			RenderSettings.skybox=skybox10;
			Obstacle.maxRandom = 70;
			mylevelText.text = "Level 10";
		}
		if (levelScript11.checker == true) 
		{		
			RenderSettings.skybox=skybox1;
			Obstacle.maxRandom = 65;
			mylevelText.text = "Level 11";
			
		}
		else if (levelScript11.checker == false && score >= 250 && score < 270)
		{
			RenderSettings.skybox=skybox1;
			Obstacle.maxRandom = 65;
			mylevelText.text = "Level 11";
		}
		if (levelScript12.checker == true) 
		{		
			RenderSettings.skybox=skybox2;
			Obstacle.maxRandom = 60;
			mylevelText.text = "Level 12";
			
		}
		else if (levelScript12.checker == false && score >= 270 && score < 290)
		{
			RenderSettings.skybox=skybox2;
			Obstacle.maxRandom = 60;
			mylevelText.text = "Level 12";
		}
		if (levelScript13.checker == true) 
		{			
			RenderSettings.skybox=skybox3;
			Obstacle.maxRandom = 55;
			mylevelText.text = "Level 13";
			
		}
		else if (levelScript13.checker == false && score >= 290 && score < 310)
		{
			RenderSettings.skybox=skybox3;
			Obstacle.maxRandom = 55;
			mylevelText.text = "Level 13";
		}
		if (levelScript14.checker == true) 
		{			
			RenderSettings.skybox=skybox4;
			Obstacle.maxRandom = 50;
			mylevelText.text = "Level 14";
			
		}
		else if (levelScript14.checker == false && score >= 310 && score < 330)
		{
			RenderSettings.skybox=skybox4;
			Obstacle.maxRandom = 50;
			mylevelText.text = "Level 14";
		}
		if (levelScript15.checker == true) 
		{			
			RenderSettings.skybox=skybox5;
			Obstacle.maxRandom = 45;
			mylevelText.text = "Level 15";
			
		}
		else if (levelScript15.checker == false && score >= 330 && score < 350)
		{
			RenderSettings.skybox=skybox5;
			Obstacle.maxRandom = 45;
			mylevelText.text = "Level 15";
		}
		if (levelScript16.checker == true) 
		{			
			RenderSettings.skybox=skybox6;
			Obstacle.maxRandom = 40;
			mylevelText.text = "Level 16";
			
		}
		else if (levelScript16.checker == false && score >=350 && score < 370)
		{
			RenderSettings.skybox=skybox6;
			Obstacle.maxRandom = 40;
			mylevelText.text = "Level 16";
		}
		if (levelScript17.checker == true) 
		{			
			RenderSettings.skybox=skybox7;
			Obstacle.maxRandom = 35;
			mylevelText.text = "Level 17";
			
		}
		else if (levelScript17.checker == false && score >= 370 && score < 390)
		{
			RenderSettings.skybox=skybox7;
			Obstacle.maxRandom = 35;
			mylevelText.text = "Level 17";
		}
		if (levelScript18.checker == true) 
		{			
			RenderSettings.skybox=skybox8;
			Obstacle.maxRandom = 30;
			mylevelText.text = "Level 18";
			
		}
		else if (levelScript18.checker == false && score >= 390 && score < 410)
		{
			RenderSettings.skybox=skybox8;
			Obstacle.maxRandom = 30;
			mylevelText.text = "Level 18";
		}
		if (levelScript19.checker == true) 
		{			
			RenderSettings.skybox=skybox9;
			Obstacle.maxRandom = 25;
			mylevelText.text = "Level 19";
			
		}
		else if (levelScript19.checker == false && score >= 410 && score < 430)
		{
			RenderSettings.skybox=skybox9;
			Obstacle.maxRandom = 25;
			mylevelText.text = "Level 19";
		}
		if (levelScript20.checker == true) 
		{			
			RenderSettings.skybox=skybox10;
			Obstacle.maxRandom = 10;
			mylevelText.text = "Level 20";
			
		}
		else if (levelScript20.checker == false && score >=430)
		{
			RenderSettings.skybox=skybox10;
			Obstacle.maxRandom = 10;
			mylevelText.text = "Level 20";
		}
		RandomMethod();				
		if(health<=0)
		{
			audio.PlayOneShot(explosion);
			health=0;
			this.audio.Play();
			this.audio.loop=true;
			Instantiate(DieExplosion,transform.position,transform.rotation);
			waitDeath-=Time.deltaTime;
			if(waitDeath<=0f)
			{				
				Application.LoadLevel(0);
			}
		}		
		fontsize=new GUIStyle();		
	    fontsize.fontSize=32;
		fontsize.normal.textColor=lerpedcolor;
		fontsize.font=scoreFont;
	    concentrate=new GUIStyle();
		concentrate.fontSize=20;
		concentrate.normal.textColor=lerpedcolor;
		concentrate.font=scoreFont;
		Screen.sleepTimeout=SleepTimeout.NeverSleep;			
		
	PlayerPrefs.SetFloat("normalscore",score);	//
		//comparison of score and highscore
		if(score>finalscore)
		{
            //set the highest score in the main menu 
			uniqueScore=score;
		}
		else
		{
            //algorithm for setting the finalscore to the main menu
			uniqueScore=finalscore;
		}
		PlayerPrefs.SetFloat("ultimateScore",uniqueScore);
		PlayerPrefs.SetInt("redsaved",redCount);
		PlayerPrefs.SetInt("greensaved",greenCount);
		PlayerPrefs.SetInt("yellowsaved",yellowCount);
	}
	void OnTriggerEnter(Collider colliderHit)
	{
		if(GameObject.FindWithTag("Green").guiTexture.enabled==true)
		{
			if(colliderHit.tag=="GreenBall")
			{
				audio.PlayOneShot(rightball);
				score+=3f;
			    scoreCollider="Good Flying!";
				greenCount++;
                //health++;
				death.enabled = false;

			}
			else
			{
				audio.PlayOneShot(wrongball);
				//Handheld.Vibrate();
				death.enabled = true;//vibrate for phone
				health--;
				scoreCollider="Hit Green eros asteroids!";
			}
		}
		else if(GameObject.FindWithTag("Yellow").guiTexture.enabled==true)
		{
			if(colliderHit.tag=="YellowBall")
			{
					audio.PlayOneShot(rightball);
				score+=2f;
				scoreCollider="Good Flying!";
				yellowCount++;
                //health++;
				death.enabled = false;
			}
			else
			{
				audio.PlayOneShot(wrongball);
				//Handheld.Vibrate();
				death.enabled = true;
				health--;
				scoreCollider="Hit yellow Ida asteroids!";
			}
		}
		else if(GameObject.FindWithTag("Red").guiTexture.enabled==true)
		{
			if(colliderHit.tag=="RedBall")
			{
					audio.PlayOneShot(rightball);
				score+=1f;
				scoreCollider="Good Flying!";
				redCount++;
                //health++;
				death.enabled = false;
			}
			else
			{
				audio.PlayOneShot(wrongball);
				//Handheld.Vibrate();
				death.enabled = true;
				health--;
				scoreCollider="Hit Red mathilde asteroids!";
			}
		}
	}
	//----------put the GUI text on screen
	void OnGUI()
	{			
		/*try{
		
	    GUI.Label(new Rect(1100,25,40,20),""+health,fontsize);
	    GUI.Label(new Rect(700,25,40,20),""+score.ToString("f0"),fontsize);		
	    GUI.Label(new Rect(720,50,50,50),":"+scoreCollider,concentrate);
		}
		catch(System.Exception e)
		{
			print (e.ToString());
		}*/
		myscore.text = score.ToString ();
		myhealth.text = health.ToString ();
		mystatus.text = scoreCollider.ToString ();
	}	
}
