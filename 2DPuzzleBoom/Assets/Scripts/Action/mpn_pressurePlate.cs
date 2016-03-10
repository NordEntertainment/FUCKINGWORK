using UnityEngine;
using System.Collections;

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



	void Start ()
	{
		gameObject.layer = 1;
		if (LaserPP) {
			
			HiddenLaser.gameObject.SetActive (false);
			
			ActiveLaser.gameObject.SetActive (true);
		}

		/*if (LaserSwitch)
			SHiddenLaser.gameObject.SetActive (false);*/

			
		PPColor = GetComponent<SpriteRenderer> ();
		PPcollider = GetComponent<BoxCollider2D> ();

			
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