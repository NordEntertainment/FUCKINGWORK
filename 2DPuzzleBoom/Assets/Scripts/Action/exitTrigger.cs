using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class exitTrigger : MonoBehaviour
{
	public int CurrentScene;

	void Start ()
	{
		CurrentScene = SceneManager.GetActiveScene ().buildIndex;

	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag.Equals ("Player")) {
			if (CurrentScene < SceneManager.sceneCountInBuildSettings)
				SceneManager.LoadScene (CurrentScene + 1);
			
		}

	}


}
