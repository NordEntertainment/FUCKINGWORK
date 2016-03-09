using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class exitTrigger : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D col)
	{
//		if (col.gameObject.tag.Equals ("Player")) {
//			SceneManager.LoadScene ("TestLevel");
//		}
		if (SceneManager.GetActiveScene().name.Equals("TestLevel")) {
				SceneManager.LoadScene ("LevelOne");
			}
		if (SceneManager.GetActiveScene().name.Equals("LevelOne")) {
			SceneManager.LoadScene ("LevelTwo");
		}
	}
}
