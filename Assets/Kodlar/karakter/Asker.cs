using UnityEngine;
using System.Collections;

public class Asker : MonoBehaviour {

	public GameObject AskerMermi;
	public Transform Askerfire;
	public float hiz;

	public Transform player;
	int bekleme = 0;
	
	
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		bekleme++;
		if (bekleme == 150) {
			if(Vector3.Distance(transform.position,player.position) < 50){
				Instantiate (AskerMermi,Askerfire.position, Askerfire.rotation);
			}
			bekleme = 0;
		}
		
	}
}
