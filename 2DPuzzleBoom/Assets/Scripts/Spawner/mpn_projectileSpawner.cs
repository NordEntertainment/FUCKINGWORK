using UnityEngine;
using System.Collections;

public class mpn_projectileSpawner : MonoBehaviour {

	public Rigidbody2D Projectile;
	public float ProjSpd = 10f;

	public bool upp = true;
	public bool downn = false;
	public bool rightt = false;
	public bool leftt = false;

	void Awake () {

	}
	

	void Update () {
		Shoot ();
		dritt ();
	}

	void dritt(){
		if(Input.GetKey("up")){ 
			upp = true;
			downn = false;
			rightt = false;
			leftt = false;
		} else if(Input.GetKey("down")){ 
			upp = false;
			downn = true;
			rightt = false;
			leftt = false;
		} else if(Input.GetKey("right")){ 
			upp = false;
			downn = false;
			rightt = true;
			leftt = false;
		} else if(Input.GetKey("left")){ 
			upp = false;
			downn = false;
			rightt = false;
			leftt = true;
		}
	}



	void Shoot(){
		if (Input.GetButtonDown ("Shoot")) {
			
			Rigidbody2D ProjIns = Instantiate (Projectile, transform.position, transform.rotation) as Rigidbody2D;

			if(rightt) ProjIns.velocity = new Vector2(ProjSpd, 0);
			if(leftt) ProjIns.velocity = new Vector2(-ProjSpd, 0);
			if(upp) ProjIns.velocity = new Vector2(0, ProjSpd);
			if(downn) ProjIns.velocity = new Vector2(0, -ProjSpd);

			Projectile.name = "Projectile";

		}	
	}	
}
