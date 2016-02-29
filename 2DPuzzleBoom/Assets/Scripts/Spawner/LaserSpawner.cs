using UnityEngine;
using System.Collections;

public class LaserSpawner : LasCol
{
	public LasCol LC;

	public GameObject laser;
	public GameObject laserSpawn;

	/*	public float laserX = 0f;
	public float laserY = 0f;*/

	public float laserX = 0.30f;
	public float laserY = 0f;
	public int maxLas = 25;
	private Vector2 PrevLasPos;

	void Start ()
	{
		
		//spawn første laser
/*		Instantiate (laser, laserSpawn.transform.position, laserSpawn.transform.rotation);*/
		//sett PrevLasPos Vector2 til først laser position;
		PrevLasPos = laserSpawn.transform.position; /*new Vector2 (laserSpawn.transform.position.x, laserSpawn.transform.position.y);*/
	

	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (HitBox == false)
			spawnlaser ();
	}


		
	void spawnlaser ()
	{


		//	for (int i = 0; i < 25; i++) {
		/*Vector2 lSpawn = PrevLasPos + new Vector2 (laserX, laserY);
		Instantiate (laser, lSpawn, Quaternion.identity);
		PrevLasPos = lSpawn;*/
	
/*

		} else if (dick == 0)
			print ("fuckyou");*/
	}
		
}
