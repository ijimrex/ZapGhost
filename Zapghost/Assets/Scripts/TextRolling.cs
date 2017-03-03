using UnityEngine;
using System.Collections;

public class TextRolling : MonoBehaviour
{
	private  float speed=2.5f;
	void Update ()
	{
		if (speed != 0)
		{
			float y= transform.localPosition.y + speed * Time.deltaTime;
			transform.localPosition =  new Vector3(0,y,0);
		}
	}
}