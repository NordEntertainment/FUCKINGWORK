using UnityEngine;
using System.Collections;

public class ColTes : MonoBehaviour
{

	public Collision2D col;

	void OnCollisionEnter2D (Collision2D col)
	{

		if (col.gameObject.tag.Equals ("Blocks")) {

			Destroy (this.gameObject);
			print ("boom");
		}
	}
}
