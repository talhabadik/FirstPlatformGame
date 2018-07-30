using UnityEngine;
using System.Collections;

public class karakter : MonoBehaviour {

	public float hiz,ziplamaGücü;
	public bool yerde=true,yurume;
	Rigidbody2D agirlik;

	public Animator anim;
	public GameObject mermi;
	public Transform firePoint;

	public int yon=1;


	void Start () {
		agirlik = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");

		agirlik.velocity = new Vector2 (h * hiz,agirlik.velocity.y);

		if(Input.GetKeyDown(KeyCode.Space)&& yerde){
			yerde=false;
			agirlik.AddForce(Vector3.up*ziplamaGücü);
			anim.SetBool("ziplama",true);
		}
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				
			Instantiate (mermi, firePoint.position, firePoint.rotation);

		}

		if(Input.GetKey(KeyCode.D)){
			anim.SetBool("yurume",true);
			transform.localScale = new Vector3(1,1,1);
			yon=1;

			}
			else if(Input.GetKey(KeyCode.A)){
			anim.SetBool("yurume",true);
			transform.localScale = new Vector3(-1,1,1);
			yon=-1;

		}else{
			anim.SetBool("yurume",false);
		}

	}

	public void Yerde ()
	{
		yerde = true;
		anim.SetBool ("ziplama", false);
	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.name == "Gemi") {
			transform.parent=col.gameObject.transform.parent;

		}
		if (col.gameObject.name == "AtSprite") {
			transform.parent=col.gameObject.transform.parent;
			
		}





	}


	void OnCollisionExit2D(){
	
		transform.parent = null;
	
	
	}




}


