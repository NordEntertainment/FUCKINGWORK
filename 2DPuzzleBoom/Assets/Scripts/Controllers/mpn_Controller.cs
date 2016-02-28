using UnityEngine;
using System.Collections;

public class mpn_Controller : MonoBehaviour {

	private float MovSpd = 10f;

	void Update () {
		CharMove ();
	}

	void CharMove(){

		if (Input.GetKey ("up"))
			transform.Translate (0, MovSpd * Time.deltaTime, 0);

		if (Input.GetKey ("down"))
			transform.Translate (0, -MovSpd * Time.deltaTime, 0);

		if (Input.GetKey ("right"))
			transform.Translate (MovSpd * Time.deltaTime, 0, 0);

		if (Input.GetKey ("left"))
			transform.Translate (-MovSpd * Time.deltaTime, 0, 0);
		
	}

}
