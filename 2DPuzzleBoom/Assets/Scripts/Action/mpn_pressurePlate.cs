using UnityEngine;
using System.Collections;

public class mpn_pressurePlate : MonoBehaviour
{
	private SpriteRenderer PPColor;
	// Exit trigger
	public bool ExitPP = false;
	// Laser Swap trigger
	public bool LaserPP = false;
	public GameObject GoingToHideRenderer;
	public GameObject hiddenLineRenderer;

	//Swap box color
	public bool ColorSwap = false;
	private Transform TargetLoc;
	public GameObject TargetBox;
	public GameObject NewBox;



	void Start ()
	{
		gameObject.layer = 1;
		if (LaserPP) {
			hiddenLineRenderer.gameObject.SetActive (false);
			GoingToHideRenderer.gameObject.SetActive (true);
		}
		PPColor = GetComponent<SpriteRenderer> ();
		/*if (ColorSwap) {
			TargetLoc.transform.position = TargetBox.transform.position;
		}*/
			
	}

	void Update ()
	{
	
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
			if (col.gameObject.tag.Equals ("redBox")) {
				hiddenLineRenderer.gameObject.SetActive (true);
				GoingToHideRenderer.gameObject.SetActive (false);
				PPColor.color = Color.red;
			}
		
		}

		if (ColorSwap) {
			if (col.gameObject.tag.Equals ("redBox")) {
				
				Destroy (TargetBox);
				Instantiate (NewBox, TargetBox.transform.position, Quaternion.identity);
				ColorSwap = false;
				PPColor.color = Color.red;
				
			}
		}
	}
}
