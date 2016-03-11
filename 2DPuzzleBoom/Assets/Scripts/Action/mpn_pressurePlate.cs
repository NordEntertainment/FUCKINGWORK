using UnityEngine;
using System.Collections;
using System;


public class mpn_pressurePlate : MonoBehaviour
{
	private Collider2D PPcollider;
	private SpriteRenderer PPColor;
	// Exit trigger
	public bool ExitPP = false;
	// Laser Swap trigger
	private bool PPtrigged = false;
	public bool LaserPP = false;
	public GameObject ActiveLaser;
	public GameObject HiddenLaser;
	//Laser On/Off
	private bool SPPtrigged = false;
	public bool LaserSwitch = false;
	public GameObject SHiddenLaser;

	//Swap box color
	public bool ColorSwap = false;
	private Transform TargetLoc;
	public GameObject TargetBox;
	public GameObject NewBox;

	//Swap More Boxes
	public bool ColorSwapX1;
	private Transform TargetLocX1;
	public GameObject TargetBoxX1;
	public GameObject NewBoxX1;

	public bool ColorSwapX2;
	private Transform TargetLocX2;
	public GameObject TargetBoxX2;
	public GameObject NewBoxX2;

	//LaserShooting
	public bool LaserShoot;
	public GameObject LaserBullet;



	void Start ()
	{
		gameObject.layer = 1;

		PPColor = GetComponent<SpriteRenderer> ();
		PPcollider = GetComponent<BoxCollider2D> ();
		if (LaserPP) {
			HiddenLaser.gameObject.SetActive (false);
			ActiveLaser.gameObject.SetActive (true);
		}			
	}

	void Update ()
	{
		if (PPColor.color == Color.red)
			PPcollider.enabled = false;	
	}

	void OnTriggerStay2D (Collider2D col)
	{
		if (ExitPP) {
			if (col.gameObject.tag.Equals ("redBox")) {
				Destroy (GameObject.Find ("_exitLaserTest"));
				PPColor.color = Color.red;
			}
		}

		if (LaserPP) {
			if (!PPtrigged) {
				if (col.gameObject.tag.Equals ("redBox")) {
					HiddenLaser.gameObject.SetActive (true);
					ActiveLaser.gameObject.SetActive (false);
					PPColor.color = Color.red;
					PPtrigged = true;
				}
			}
		}

		if (ColorSwap) {
			if (col.gameObject.tag.Equals ("redBox")) {
				Destroy (TargetBox);
				GameObject BoxSwap = Instantiate (NewBox, TargetBox.transform.position, Quaternion.identity) as GameObject;
				BoxSwap.name = "_redBox";
				ColorSwap = false;
				PPColor.color = Color.red;
			}
		}

		if (ColorSwapX1) {
			if (col.gameObject.tag.Equals ("redBox")) {
				Destroy (TargetBoxX1);
				GameObject BoxSwap = Instantiate (NewBoxX1, TargetBoxX1.transform.position, Quaternion.identity) as GameObject;
				BoxSwap.name = "_redBox";
				ColorSwapX1 = false;
				PPColor.color = Color.red;
			}
		}

		if (ColorSwapX2) {
			if (col.gameObject.tag.Equals ("redBox")) {
				Destroy (TargetBoxX2);
				GameObject BoxSwap = Instantiate (NewBoxX2, TargetBoxX1.transform.position, Quaternion.identity) as GameObject;
				BoxSwap.name = "_redBox";
				ColorSwapX2 = false;
				PPColor.color = Color.red;
			}
		}
		if (LaserSwitch) {
			if (!SPPtrigged) {
				if (col.gameObject.tag.Equals ("redBox")) {
					PPColor.color = Color.red;
					SHiddenLaser.gameObject.SetActive (false);
					SPPtrigged = true;
				}
			}
		}
	}
}