using UnityEngine;
using System.Collections;

public class projectileCol : MonoBehaviour
{

	public Collision2D col;

	void OnCollisionEnter2D (Collision2D col)
	{

		if (col.gameObject.tag.Equals ("Blocks")) {

			Destroy (this.gameObject);
//			print ("boom");
		}
	}
}
