using UnityEngine;
using System.Collections;

public class TankMermi : MonoBehaviour {

	public float hiz;
	public int yon=-1;


	void Start () {

		Destroy (gameObject, 4f);
	}
	
	// Update is called once per frame
	void Update () {

			transform.Translate (Vector3.right * hiz * yon);

	}
}
