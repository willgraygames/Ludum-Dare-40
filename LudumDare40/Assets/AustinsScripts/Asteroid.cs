using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Asteroid : MonoBehaviour 
{

	public float speed;


	void Update () 
	{

		//transform.position= new Vector2(Random.Range(-10f,10f),Random.Range(-10f,10f));
		//transform.position = new Vector3(Mathf.PingPong(Time.time, 5), Random.Range(-10f, 10f), transform.position.z);
		//transform.position=new Vector2(Mathf.PingPong(Random.Range(-10f,10),Random.Range(-10f,10f)),Mathf.PingPong(Random.Range(-10f,10f),Random.Range(-10f,10f)))* speed;
	}

	void Move()
	{
		//transform.position = new Vector2(Mathf.PingPong)(Time.time, 5), Random.Range(-10f, 10f, Random.Range(-10f,10f));
	}


}
