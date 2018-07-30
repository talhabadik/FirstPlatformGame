using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

 	public karakter oyuncu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D () {
		oyuncu.Yerde ();

	}
}
