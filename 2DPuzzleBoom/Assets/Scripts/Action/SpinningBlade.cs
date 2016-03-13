using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SpinningBlade : MonoBehaviour
{

	private float spinSpeed = 50f;

	void Update ()
	{

		transform.Rotate (0, 0, spinSpeed * Time.deltaTime);

	
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag.Equals ("Player")) {
			string CurrentScene = SceneManager.GetActiveScene ().name;
			print ("Hit Player");
			Destroy (GameObject.Find ("_testChar(Clone)"));
			SceneManager.LoadScene (CurrentScene, LoadSceneMode.Single);
		}
	}
}
