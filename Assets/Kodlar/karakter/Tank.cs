using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

	public GameObject TankMermi;
	public Transform Tankfire;
	public float hiz;
	Tank t;
	public Transform player;
	int bekleme = 0;



	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		bekleme++;
		if (bekleme == 150) {
			if(Vector3.Distance(transform.position,player.position) < 40){
				Instantiate (TankMermi,Tankfire.position, Tankfire.rotation);
			}
			bekleme = 0;
		}

	}
}
