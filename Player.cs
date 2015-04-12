using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float currentxposition=0f;
	public float targetxposition=10f;
	public float xvelocity=0.5f;
	public float xsmoothtime=0.5f;
	public float currentzposition=0f;
	public float targetzposition=10f;
	public float zvelocity=0.5f;
	public float zsmoothtime=0.5f;
	public float xchange=0f;
	public float zchange=0f;
	public float xminpos=0f;
	public float xmaxpos=10f;
	public float zminpos=0f;
	public float zmaxpos=10f;
	private float lastxpos;
	public float multiplier=3f;
	public float swaydamptime=0.3f;
	private float swayv;
	private float currentzrotation;
	private GameObject left;
	private GameObject right;
	public float accSpeed=10;
	// Use this for initialization
	void Start () {

	}
	void Movement()
	{
		xchange=Mathf.SmoothDamp(currentxposition,targetxposition*Input.GetAxis("Horizontal"),ref xvelocity,xsmoothtime);
		zchange=Mathf.SmoothDamp(currentzposition,targetzposition*Input.GetAxis("Horizontal"),ref zvelocity,zsmoothtime);	
	transform.position=new Vector3(Mathf.Clamp(transform.position.x+xchange*Time.deltaTime,xminpos,xmaxpos),transform.position.y,Mathf.Clamp(transform.position.z+zchange*Time.deltaTime,zminpos,zmaxpos));		
	currentzrotation-=(transform.position.x-lastxpos)*multiplier;
	currentzrotation=Mathf.SmoothDamp(currentzrotation,0,ref swayv,swaydamptime);
	transform.rotation=Quaternion.Euler(new Vector3(0f,180f,-currentzrotation));	
	lastxpos=transform.position.x;	
	}
	
	// Update is called once per frame
	void Update () {
	Movement();

	}	
	void findBeacon()
	{
		//find the beacons
		left=GameObject.FindWithTag("left");
		right=GameObject.FindWithTag("right");		
		int beaconRandom=Random.Range(0,11);
		if(beaconRandom==0)
		{
			left.renderer.material.color=Color.blue;
			right.renderer.material.color=Color.yellow;
		}
		else if(beaconRandom==5)
		{
			right.renderer.material.color=Color.magenta;
			left.renderer.material.color=Color.yellow;
		}
	}
}
