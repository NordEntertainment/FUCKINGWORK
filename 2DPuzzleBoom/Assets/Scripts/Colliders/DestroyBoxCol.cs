using UnityEngine;
using System.Collections;

public class DestroyBoxCol : MonoBehaviour
{


	void OnCollisionEnter2D (Collision2D col)
	{

		if (col.gameObject.tag.Equals ("Projectile")) {

			Destroy (this.gameObject);
			//			print ("boom");
		}
	}
}
