﻿using UnityEngine;
using System.Collections;

public class TextRolling : MonoBehaviour
{
	private  float speed=6f;
	void Update ()
	{
		if (speed != 0)
		{
			float y= transform.localPosition.y + speed * Time.deltaTime;
			transform.localPosition =  new Vector3(-30,y,-290);
		}
	}
}