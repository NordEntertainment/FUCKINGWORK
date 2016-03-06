using UnityEngine;
using System.Collections;

public class mpn_DrawLas2 : MonoBehaviour {

	private LineRenderer LR;
	public Transform LHit;

	void Start () {
		LR = GetComponent<LineRenderer> ();
		LR.enabled = false;
		LR.useWorldSpace = true;
	}

	void Update () {
		RaycastHit2D Hit = Physics2D.Raycast (transform.position, transform.up);
		Debug.DrawLine (transform.position, Hit.point);
		LHit.position = Hit.point;
		LR.SetPosition (0, transform.position);
		LR.SetPosition (1, LHit.position);
		if (Input.GetKey (KeyCode.O))
			LR.enabled = true;
		
	}
}
