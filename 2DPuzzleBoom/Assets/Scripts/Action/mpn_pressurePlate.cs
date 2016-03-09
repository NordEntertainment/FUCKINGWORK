using UnityEngine;
using System.Collections;

public class mpn_pressurePlate : MonoBehaviour {
	// Exit trigger
	public bool ExitPP = false;
	// Laser Swap trigger
	public bool LaserPP = false;
	public GameObject GoingToHideRenderer;
	public GameObject hiddenLineRenderer;



	void Start () {
		gameObject.layer = 1;
		if (LaserPP) {
			hiddenLineRenderer.gameObject.SetActive (false);
			GoingToHideRenderer.gameObject.SetActive (true);
		}
	}

	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D col){
		if (ExitPP) {
			if (col.gameObject.tag.Equals ("redBox")) {
				Destroy (GameObject.Find ("_exitLaserTest"));
			}
		}		
		if (LaserPP) {
			if (col.gameObject.tag.Equals ("redBox")) {
				hiddenLineRenderer.gameObject.SetActive (true);
				GoingToHideRenderer.gameObject.SetActive (false);
		}
		
		}
	}
}
