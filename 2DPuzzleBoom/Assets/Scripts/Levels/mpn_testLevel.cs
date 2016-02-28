using UnityEngine;
using System.Collections;

public class mpn_testLevel : mpn_spawner {

	public mpn_spawner ST;

	void Start () {

		for (int i = 0; i < maxRed; i++)
		{
			RedCube ();
		}
		for (int i = 0; i < maxYellow; i++)
		{
			YellowCube ();
		}
		for (int i = 0; i < maxGreen; i++)
		{
			GreenCube ();
		}
	
		
	}
}
