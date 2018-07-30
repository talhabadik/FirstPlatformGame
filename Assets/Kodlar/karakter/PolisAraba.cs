using UnityEngine;
using System.Collections;

public class PolisAraba : MonoBehaviour {

	public float maxX;//köpeğimizin gidip gelmesini istediğimiz noktaları belirttik.Bu değişkenleri editörden değiştirebiliyoruz
	public float minX;
	public float hiz;
	public GameObject k;
	public int yon;//Yönümüzü belirten değişken

	public GameObject ArabaMermi;
	public Transform ArabaFire;

	public Transform player;
	int bekleme = 0;



	
	void Start () {
		
	}
	
	
	void Update () {
		bekleme++;
		if (transform.position.x > maxX) {
			yon = yon * -1;
			transform.localScale=new Vector3(-6f,5f,1f);//köpeğimiz'in koordinatlarını alan ve ona göre bir yol belirleyen kodlar
			
		}
		if (transform.position.x < minX) {
			yon = yon * -1;
			transform.localScale=new Vector3(6f,5f,1f);
		}
		transform.Translate (new Vector3 (hiz * yon, 0, 0));

	
		if (bekleme == 100) {
			if(Vector3.Distance(transform.position,player.position) < 50){
				Instantiate (ArabaMermi,ArabaFire.position,ArabaFire.rotation);
			}
			bekleme = 0;
		}


	}
}

