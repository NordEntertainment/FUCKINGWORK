using UnityEngine;
using System.Collections;

public class LevelOnePPlate : MonoBehaviour
{


	public GameObject hiddenLineRenderer;


	public GameObject GoingToHideRenderer;

	void Start ()
	{
		gameObject.layer = 1;


		hiddenLineRenderer.gameObject.SetActive (false);
		GoingToHideRenderer.gameObject.SetActive (true);
	}

	void Update ()
	{

	}

	void OnTriggerStay2D (Collider2D col)
	{

		if (col.gameObject.tag.Equals ("redBox")) {
			Destroy (GameObject.Find ("_exitLaserTest"));

			hiddenLineRenderer.gameObject.SetActive (true);
			GoingToHideRenderer.gameObject.SetActive (false);

		}
	}
}
