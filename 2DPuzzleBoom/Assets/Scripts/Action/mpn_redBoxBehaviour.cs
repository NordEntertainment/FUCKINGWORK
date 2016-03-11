using UnityEngine;
using System.Collections;

public class mpn_redBoxBehaviour : MonoBehaviour
{

	//public Transform PPPosition;
	private Rigidbody2D redBoxBody;

	void Start ()
	{
		redBoxBody = GetComponent<Rigidbody2D> ();


	
	}

	void Update ()
	{

		if (Input.GetAxis ("Horizontal") != 0)
			redBoxBody.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
		else
			redBoxBody.constraints = RigidbodyConstraints2D.FreezeRotation;
	
		if (Input.GetAxis ("Vertical") != 0)
			redBoxBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
		else
			redBoxBody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	void OnTriggerStay2D (Collider2D col)
	{
	
		if (col.gameObject.tag.Equals ("PressurePlate")) {
			Destroy (this.gameObject);
			//this.gameObject.transform.position = PPPosition.transform.position;

		}

	}


}
