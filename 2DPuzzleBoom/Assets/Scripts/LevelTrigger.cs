using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour
{

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag.Equals ("LevelExit"))
			SceneManager.LoadScene ("MainMenu");
	}
}
