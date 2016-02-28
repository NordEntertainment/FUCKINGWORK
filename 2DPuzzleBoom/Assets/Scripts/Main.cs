using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

	public GameObject block;

	private Vector2 spawn;
	public int maxSpawns = 55;
	public float minX = -800;
	public float maxX = 800;
	public float minY = -500;
	public float maxY = 500;

	// Use this for initialization
	void Start ()
	{

		GenerateBlocks ();

	
	}
	
	// Update is called once per frame
	void Update ()
	{

	
	
	}

	void GenerateBlocks ()
	{
		

		for (int i = 0; i < maxSpawns; i++) {
			Color ran = Random.ColorHSV ();
			Vector2 spawn = new Vector2 (Random.Range (minX, maxX), Random.Range (minY, maxY));
			GameObject go = Instantiate (block, spawn, Quaternion.identity) as GameObject;
			go.GetComponent<SpriteRenderer> ().color = ran;
			go.name = ("Position = " + spawn);

		}


	}
}
