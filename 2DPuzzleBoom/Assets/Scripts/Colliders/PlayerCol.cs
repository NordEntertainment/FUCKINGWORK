using UnityEngine;
using System.Collections;

public class PlayerCol : mpn_spawner
{
	public mpn_spawner ST;



	void OnCollisionEnter2D (Collision2D col)
	{

		if (col.gameObject.tag.Equals ("Laser")) {
			Destroy (this.gameObject);
			print ("death");
		}
	}
}
