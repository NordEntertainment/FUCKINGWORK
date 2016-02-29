using UnityEngine;
using System.Collections;

public class LasCol : MonoBehaviour
{
	public bool HitBox = false;
	public Collision2D col;
	public int dick;

	public void OnCollisionEnter2D (Collision2D col)
	{

		if (col.gameObject.tag.Equals ("Blocks")) {
			//DestroyImmediate (this.gameObject);
			HitBox = true;
			dick = 0;
			print ("dickbag");

			/*} else {
			dick = 1;
			HitBox = false;
		*/
		}
	}
}
