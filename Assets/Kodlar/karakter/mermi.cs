using UnityEngine;
using System.Collections;

public class mermi : MonoBehaviour {

	public float speed;

	karakter k;//karakter sınıfımızdan k diye bir değişkenle nesneyi aldık
	int atesYonu;//ilk baştaki yönü almak için kullanılır


	void Start () {
		k = GameObject.FindGameObjectWithTag("Player").GetComponent<karakter>();//karakter'e ulaştık ve bunu karakter sınıfından k adına atadık
		atesYonu = k.yon;//k'nın ilk başta ki yönünü almak için kullandık
		Destroy (gameObject, 4f);//mermiler 4 saniye sonra kaybolması için
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.right * speed*atesYonu);

	}
}
