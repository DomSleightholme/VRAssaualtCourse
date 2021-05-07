using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTheCamera : MonoBehaviour {

	[SerializeField]
	Vector3 axis;
	[SerializeField]
	float speed;

	private void Update()
	{
		transform.Rotate(axis * speed);
	}
}
