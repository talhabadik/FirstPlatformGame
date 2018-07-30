using UnityEngine;
using System.Collections;

public class feto : MonoBehaviour {

	public Sprite bagirma;
	public AudioSource sesi;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.name == "Karakter") {
			sesi.Play();
			GetComponent<SpriteRenderer>().sprite = bagirma;
		}

	}
}
