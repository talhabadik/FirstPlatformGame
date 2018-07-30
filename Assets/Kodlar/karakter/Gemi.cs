using UnityEngine;
using System.Collections;

public class Gemi : MonoBehaviour {
	public float maxX;
	public float minX;
	public float hiz;
	public GameObject k;
	public int yon;
	void Start () {
	
	}
	

	void Update () {
		if (transform.position.x > maxX) {
			yon = yon * -1;
			transform.localScale=new Vector3(1,1,1f);
			
		}
		if (transform.position.x < minX) {
			yon = yon * -1;
			transform.localScale=new Vector3(1,1,1f);
		}
		transform.Translate (new Vector3 (hiz * yon, 0, 0));
	}





	}

