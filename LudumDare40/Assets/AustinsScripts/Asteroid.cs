using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour 
{

	public float timer;
	public int newTarget;
	public float speed;
	public NavMeshAgent nav;
	public Vector2 target;










	/*private float speed;
	private Rigidbody2D myBody;

	void Awake()
	{
		myBody = GetComponent<Rigidbody2D> ();
	}
	void Update () 
	{
		myBody.velocity = new Vector2 (.00005f, .000005f);
		transform.position= new Vector2(Random.Range(-10f,10f),Random.Range(-10f,10f));
	}*/
}
