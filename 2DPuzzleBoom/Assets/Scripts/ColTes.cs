using UnityEngine;
using System.Collections;

public class ColTes : MonoBehaviour {
	
	void OnCollisionEnter2D (Collision2D col){

		if (col.gameObject.tag.Equals ("Blocks"))
			Destroy (this.gameObject);


	}
}
