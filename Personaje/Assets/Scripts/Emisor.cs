using UnityEngine;
using System.Collections;

public class Emisor : MonoBehaviour {
	public GameObject objetoPrefab;
	public int total;
	public float counter;
	public float inter;
	// Use this for initialization
	void Start () {
		total = 20;
		counter = 0;
		inter = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (counter > inter) 
		{
			counter=0;
			secuenciaRandom();
		}
		counter += Time.deltaTime;
		//float pos;
		//pos= Random.Range(-10,10);
		//Vector3 newPos = new Vector3(this.transform.position.x+pos,this.transform.position.y,this.transform.position.z);

	}
	public void secuenciaRandom()
	{
		int initRange = (total/2)-total;
		for (int i=0; i<total; i++) 
		{
			if(Random.Range(0,2)==1)
			{
				Instantiate(objetoPrefab,new Vector3(this.transform.position.x+(initRange+i),this.transform.position.y,this.transform.position.z),Quaternion.identity);
			}
		}
	}
}
