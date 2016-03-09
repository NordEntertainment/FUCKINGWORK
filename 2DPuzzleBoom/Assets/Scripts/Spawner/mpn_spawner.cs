using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mpn_spawner : MonoBehaviour
{

	public GameObject redBox;
	public GameObject yellowBox;
	public GameObject greenBox;
	public GameObject laserBox;
	public GameObject player;
	public int maxRed;
	public int maxYellow;
	public int maxGreen;
	public float maxX = 5f;
	//slutt bredde
	public float minX = -5f;
	//start bredde
	public float maxY = 5f;
	//slutt høyde
	public float minY = -5f;
	//start høyde
	public float lasX = 0f;
	public float lasY = 0f;

	public float PlrX = 0f;
	public float PlrY = 0f;

	public void RedCube ()
	{
		Vector2 randomPosition = new Vector2 (Random.Range (minX, maxX), Random.Range (minY, maxY));
		Instantiate (redBox, randomPosition, Quaternion.identity);
	}

	public void YellowCube ()
	{
		Vector2 randomPosition = new Vector2 (Random.Range (minX, maxX), Random.Range (minY, maxY));
		Instantiate (yellowBox, randomPosition, Quaternion.identity);
	}

	public void GreenCube ()
	{
		Vector2 randomPosition = new Vector2 (Random.Range (minX, maxX), Random.Range (minY, maxY));
		Instantiate (greenBox, randomPosition, Quaternion.identity);
	}

	public void LaserBox ()
	{
		Vector3 V3laserPosition = new Vector3 (lasX, lasY, -1f);
//		Vector2 laserPosition = new Vector2 (lasX, lasY);
		Instantiate (laserBox, V3laserPosition, Quaternion.identity);
	}

	public void PlayerSpawn ()
	{
		Vector2 PlayerPos = new Vector2 (PlrX, PlrY);
		Instantiate (player, PlayerPos, Quaternion.identity);

	}
}
