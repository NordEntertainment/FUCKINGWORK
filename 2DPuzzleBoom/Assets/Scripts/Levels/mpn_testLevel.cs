using UnityEngine;
using System.Collections;

public class mpn_testLevel : mpn_spawner
{

	public bool CRed;
	public bool CYellow;
	public bool CGreen;
	public bool CLaser;


	public mpn_spawner ST;

	void Start ()
	{
		if (CRed) {
			for (int i = 0; i < maxRed; i++) {
				RedCube ();
			}
		}
		if (CYellow) {
			for (int i = 0; i < maxYellow; i++) {
				YellowCube ();
			}
		}
		if (CGreen) {
			for (int i = 0; i < maxGreen; i++) {
				GreenCube ();
			}
		}
		if(CLaser)	
			LaserBox ();
	
		PlayerSpawn ();
	}
}
