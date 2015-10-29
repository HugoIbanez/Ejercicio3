using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		speed = 20;
	}
	
	// Update is called once per frame
	void Update () {
		//moveForward ();
	}
	//funcion que mueve al personaje
	public void moveLe()
	{
		//Debug.Log ("Hola ");
		//Mover posicion de forma constante
		//Vector3.down
		this.transform.Translate( (Time.deltaTime * speed) * Vector3.left);
	}
	//funcion que mueve al personaje
	public void moveR()
	{
		//Debug.Log ("Hola ");
		//Mover posicion de forma constante
		this.transform.Translate( (Time.deltaTime * speed) * Vector3.right);
	}
}
