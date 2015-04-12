using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	public Rigidbody ObstacleObject;
	public static int maxRandom=200;
	public float min=0f;
	public float max=0f;
	public GUIText mylevelText;
	public static string myText;
	//function for instantiating the obstacles
	void CreateObject()
	{
		
		int halfRandom=maxRandom/2;
		int randomint=Random.Range(0,maxRandom);
		if(randomint==halfRandom){
		Instantiate(ObstacleObject,transform.position+new Vector3(Random.Range(min,max),0f,50f),transform.rotation);
		}
		
	}	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	CreateObject();
	}
}
