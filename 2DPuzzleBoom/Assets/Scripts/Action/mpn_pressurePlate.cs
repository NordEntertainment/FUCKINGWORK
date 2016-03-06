using UnityEngine;
using System.Collections;

public class mpn_pressurePlate : MonoBehaviour {


	void Start () {
		gameObject.layer = 1;
	}

	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D col){
	
		if (col.gameObject.tag.Equals ("redBox"))
			Destroy (GameObject.Find ("_exitLaserTest"));
	
	}
}
