using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class efa_MainMenu : MonoBehaviour
{

	public Button play;


	public void PlayGame ()
	{

		Application.LoadLevel ("TestLevel");
	}
}
