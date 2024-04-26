using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public Transform centerPoint; // D�n�� merkezi noktas�
	public float rotationSpeed = 30f; // D�nme h�z� (derece/saniye)

	void Update()
	{
		// Objeyi centerPoint etraf�nda d�nd�r
		transform.RotateAround(centerPoint.position, Vector3.up, rotationSpeed * Time.deltaTime);
	}
}
