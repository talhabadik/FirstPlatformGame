using UnityEngine;
using System.Collections;

public class KameraRunner : MonoBehaviour {

	public Transform player;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.position.x + 6,player.position.y, -10);//karakterin hareketine göre kameranın hareketini sağlayan kod
	
	}
}
