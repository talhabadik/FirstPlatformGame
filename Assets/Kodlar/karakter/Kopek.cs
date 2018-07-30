using UnityEngine;
using System.Collections;

public class Kopek : MonoBehaviour {
	public float maxX;//köpeğimizin gidip gelmesini istediğimiz noktaları belirttik.Bu değişkenleri editörden değiştirebiliyoruz
	public float minX;
	public float hiz;
	public GameObject k;
	public int yon;//Yönümüzü belirten değişken
	
	void Start () {
		
	}
	
	
	void Update () {
		if (transform.position.x > maxX) {
			yon = yon * -1;
			transform.localScale=new Vector3(-2.5f,3f,1f);//köpeğimiz'in koordinatlarını alan ve ona göre bir yol belirleyen kodlar
			
		}
		if (transform.position.x < minX) {
			yon = yon * -1;
			transform.localScale=new Vector3(2.5f,3f,1f);
		}
		transform.Translate (new Vector3 (hiz * yon, 0, 0));
	}
}
