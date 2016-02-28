using UnityEngine;
using System.Collections;

public class TestLevel : SpawnTester {

	public SpawnTester ST;

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
