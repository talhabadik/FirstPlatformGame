using UnityEngine;
using System.Collections;

public class Kule : MonoBehaviour {
	public GameObject KuleMermi;
	public Transform KuleFire;
	public float hiz;

	public Transform player;
	int bekleme = 0;
	
	
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		bekleme++;
		if (bekleme == 150) {
			if(Vector3.Distance(transform.position,player.position) < 40){
				Instantiate (KuleMermi,KuleFire.position, KuleFire.rotation);
			}
			bekleme = 0;
		}
		
	}
}
