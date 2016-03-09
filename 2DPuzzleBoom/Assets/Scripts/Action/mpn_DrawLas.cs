using UnityEngine;
using System.Collections;

public class mpn_DrawLas : MonoBehaviour
{

	private LineRenderer LR;
	private float tikk;
	private float dist;

	public bool RaycastDebug;
	public Transform LasBirth;
	public Transform LasDeath;

	public float DrawSpeed;
	public float LasWidth = 0.30f;

	private Vector3 pointA;
	private Vector3 pointB;

	void Start ()
	{
	
		LR = GetComponent<LineRenderer> ();
		LR.SetPosition (0, LasBirth.position);
		LR.SetWidth (LasWidth, LasWidth);

		dist = Vector3.Distance (LasBirth.position, LasDeath.position);

	}

	

	void Update ()
	{
		RaycastHit2D LHit = Physics2D.Raycast (LasBirth.position, LasBirth.right);
//		dist = Vector3.Distance (LasBirth.position, LasDeath.position); 


		pointA = LasBirth.position;

		if (LHit.collider != null && RaycastDebug)
			Debug.Log (LHit.collider.name);
		
		if (LHit.collider.name == "_testChar(Clone)") {

			Destroy (GameObject.Find ("_testChar(Clone)"));

		}
		if (LHit.collider.name == "Projectile(Clone)") {

			Destroy (GameObject.Find ("Projectile(Clone)"));

		}

		if (LHit.collider.name == "_redBox") {
			
			tikk += 0.1f / DrawSpeed;

			float x = Mathf.Lerp (0, dist, tikk);

			pointB = LHit.point;

			Vector3 pointAlongLine = x * Vector3.Normalize (pointB - pointA) + pointA;

			LR.SetPosition (1, pointAlongLine);
			dist = Vector3.Distance (LasBirth.position, pointB);

		}

		if (LHit.collider.name == "LDeath") {

			tikk += 0.1f / DrawSpeed;

			float x = Mathf.Lerp (0, dist, tikk);

			pointB = LHit.point;

			Vector3 pointAlongLine = x * Vector3.Normalize (pointB - pointA) + pointA;

			LR.SetPosition (1, pointAlongLine);
			dist = Vector3.Distance (LasBirth.position, pointB);
			
		} 
	}
}
