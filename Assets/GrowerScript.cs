﻿using UnityEngine;
using System.Collections;

public class GrowerScript : MonoBehaviour {
	private Grower grower;
	
	void Start () {
		this.grower = new Grower(this.gameObject);
	}
	
	void OnCollisionEnter (Collision col)
	{
		GameObject collider = col.gameObject;
		if (collider.name == "SnakeHead")
		{
			this.grower.GoToRandomly();
		}
	}
}
