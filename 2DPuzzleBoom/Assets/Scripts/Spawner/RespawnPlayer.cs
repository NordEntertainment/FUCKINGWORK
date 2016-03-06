using UnityEngine;
using System.Collections;

public class RespawnPlayer : mpn_spawner
{
	

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (GameObject.FindGameObjectWithTag ("Player") == null) {
			Vector2 PlayerPos = new Vector2 (-7f, -4f);
			Instantiate (player, PlayerPos, Quaternion.identity);
		}


	}
}
