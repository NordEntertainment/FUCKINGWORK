using UnityEngine;
using System.Collections;

public class mpn_redBoxBehaviour : MonoBehaviour {

	public Transform PPPosition;

	void Start () {
	
	}

	void Update () {
	
	}
	void OnTriggerStay2D(Collider2D col){
	
		if(col.gameObject.tag.Equals("PressurePlate")){

			this.gameObject.transform.position = PPPosition.transform.position;

		}

	}
}
