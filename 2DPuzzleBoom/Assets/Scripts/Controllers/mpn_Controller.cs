using UnityEngine;
using System.Collections;

public class mpn_Controller : MonoBehaviour {

	private Rigidbody2D rb2d;
	public GameObject _testChar;
	private float MovSpd = 10f;
//	private int zRot;

	void Awake(){
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		
		CharMove ();
	}

	void CharMove(){

		if (Input.GetKey ("up")) {

			rb2d.AddForce (Vector2.up * MovSpd);
//			transform.Translate (0, MovSpd * Time.deltaTime, 0);
//			transform.forward = new Vector3 (0f, 0f, 0f);

		}	else if (Input.GetKey ("down")) {

			rb2d.AddForce (Vector2.down * MovSpd);
//			transform.Translate (0, -MovSpd * Time.deltaTime, 0);
//			transform.forward = new Vector3 (0f, 0f, 0f);
		
		}	else if (Input.GetKey ("right")) {

			rb2d.AddForce (Vector2.right * MovSpd);
//			transform.Translate (MovSpd * Time.deltaTime, 0, 0);
//			transform.forward = new Vector3 (0f, 0f, 0f);

		}	else if (Input.GetKey ("left")) {

			rb2d.AddForce (Vector2.left * MovSpd);
//			transform.Translate (-MovSpd * Time.deltaTime, 0, 0);
//			transform.forward = new Vector3 (0f, 0f, 0f);

		}
	}

//	void CharRot(){
//
//		Quaternion rot = transform.localRotation;
//		rot.eulerAngles = new Vector3 (0, 0, zRot);
//		transform.localRotation = rot;
//			
//	}

}
