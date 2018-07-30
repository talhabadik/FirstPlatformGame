using UnityEngine;
using System.Collections;

public class At : MonoBehaviour {

	public float maxX;
	public float minX;
	public float hiz;
	public GameObject atSprite;
	public int yon;
	
	void Start () {
		
	}
	
	
	void Update () {
		if (transform.position.x > maxX) {
			yon = yon * -1;
			atSprite.transform.localScale=new Vector3(-7f,7f,1f);//köpeğimiz'in koordinatlarını alan ve ona göre bir yol belirleyen kodlar
			
		}
		if (transform.position.x < minX) {
			yon = yon * -1;
			atSprite.transform.localScale=new Vector3(7f,7f,1f);
		}
		transform.Translate (new Vector3 (hiz * yon, 0, 0));
	}
}
