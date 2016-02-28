using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class efa_MainMenu : MonoBehaviour
{

	public Button play;


	public void PlayGame ()
	{

		SceneManager.LoadScene ("TestLevel");
	}
}
