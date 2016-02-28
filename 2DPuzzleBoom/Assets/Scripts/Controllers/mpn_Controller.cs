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
			transform.Translate (0, MovSpd * Time.deltaTime, 0);
		}
		if (Input.GetKey ("down")) {
			transform.Translate (0, -MovSpd * Time.deltaTime, 0);
		}
		if (Input.GetKey ("right")) {
			transform.Translate (MovSpd * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey ("left")) {
			transform.Translate (-MovSpd * Time.deltaTime, 0, 0);
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
