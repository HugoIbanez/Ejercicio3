using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed;
	public float dir;
	// Use this for initialization
	void Start () {
		speed = 3;
		dir = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.x<-10)
		{
			dir=1;
		}
		if(this.transform.position.x>10)
		{
			dir=-1;
		}
		moverSiempre ();
	}
	//funcion que mueve al personaje
	public void moveLe()
	{
		dir = -1;
	}
	//funcion que mueve al personaje
	public void moveR()
	{
		dir = 1;
	}
	//funcion paramoverse siempre
	public void moverSiempre()
	{
		this.transform.Translate ((Time.deltaTime * speed * dir) * Vector3.right);
	}

}
