using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnTester : MonoBehaviour {

	public GameObject Block;
	public int maxRed;
	public int maxYellow;
	public int maxGreen;
	public float maxX = 5f; 	//slutt bredde
	public float minX = -5f; 	//start bredde
	public float maxY = 5f; 	//slutt høyde
	public float minY = -5f; 	//start høyde

	public void RedCube()
	{
		Vector2 randomPosition = new Vector2 (Random.Range(minX, maxX), Random.Range (minY, maxY));
		Instantiate (Block, randomPosition, Quaternion.identity);
		Block.GetComponent<SpriteRenderer> ().color = Color.red;
	}

	public void YellowCube()
	{
		Vector2 randomPosition = new Vector2 (Random.Range (minX, maxX), Random.Range (minY, maxY));
		Instantiate (Block, randomPosition, Quaternion.identity);
		Block.GetComponent<SpriteRenderer> ().color = Color.yellow;
	}

	public void GreenCube()
	{
		Vector2 randomPosition = new Vector2 (Random.Range (minX, maxX), Random.Range (minY, maxY));
		Instantiate (Block, randomPosition, Quaternion.identity);
		Block.GetComponent<SpriteRenderer> ().color = Color.green;
	}

}
