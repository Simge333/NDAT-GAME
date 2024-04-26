using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public Transform centerPoint; // Dönüþ merkezi noktasý
	public float rotationSpeed = 30f; // Dönme hýzý (derece/saniye)

	void Update()
	{
		// Objeyi centerPoint etrafýnda döndür
		transform.RotateAround(centerPoint.position, Vector3.up, rotationSpeed * Time.deltaTime);
	}
}
