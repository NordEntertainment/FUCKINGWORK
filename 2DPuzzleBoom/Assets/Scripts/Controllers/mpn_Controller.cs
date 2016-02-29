using UnityEngine;
using System.Collections;

public class mpn_Controller : MonoBehaviour {

	public Vector2 Velocity;
	private Rigidbody2D rb2d;
	public GameObject _testChar;
	public float MovSpd = 10f;
//	private int zRot;

	void Awake(){
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		
		CharMove ();
	}

	void CharMove(){

		rb2d.MovePosition(rb2d.position + Velocity * Time.deltaTime);

		if (Input.GetKey ("up")) {

			rb2d.AddForce (Vector2.up * MovSpd);
			rb2d.MoveRotation (angle: 0);
//			transform.Translate (0, MovSpd * Time.deltaTime, 0);
//			transform.forward = new Vector3 (0f, 0f, 0f);

		}	else if (Input.GetKey ("down")) {
			
			rb2d.AddForce (Vector2.down * MovSpd);
			rb2d.MoveRotation (angle: 180);
//			transform.Translate (0, -MovSpd * Time.deltaTime, 0);
//			transform.forward = new Vector3 (0f, 0f, 0f);
		
		}	else if (Input.GetKey ("right")) {

			rb2d.AddForce (Vector2.right * MovSpd);
			rb2d.MoveRotation (angle: 270);
//			transform.Translate (MovSpd * Time.deltaTime, 0, 0);
//			transform.forward = new Vector3 (0f, 0f, 0f);

		}	else if (Input.GetKey ("left")) {

			rb2d.AddForce (Vector2.left * MovSpd);
			rb2d.MoveRotation (angle: 90);
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
