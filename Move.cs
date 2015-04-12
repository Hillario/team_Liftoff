using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float killtime=3f;
	public float speed=1f;
	public float acceleration=3f;
	public float rotateSpeed=60f;
	// Use this for initialization
	void Start () {
	
	}
	//function for moving the obstacles in respect to the z axis
	public void MoveObjects()
	{
		speed+=acceleration*Time.deltaTime;
		killtime-=Time.deltaTime;
		if(killtime<=0)
		{
			Destroy(gameObject);
		}
		transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z-speed*Time.deltaTime);
		
	}
	// Update is called once per frame
	void Update () {
	MoveObjects();
	}
	void OnTriggerEnter(Collider ballhit)
	{
		if(ballhit.tag=="Haji")
		{
			Destroy(gameObject);
		}
	}
}
