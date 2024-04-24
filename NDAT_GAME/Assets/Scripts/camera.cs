using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
	public Transform target; // Takip edilecek karakterin Transform bile�eni
	public float distance = 5.0f; // Kameran�n karakterden uzakl���
	public float height = 2.0f; // Kameran�n y�ksekli�i
	public float smoothSpeed = 2.0f; // Kameran�n yumu�akl�k h�z�

	void LateUpdate()
	{
		// Kameran�n hedef konumu
		Vector3 targetPosition = target.position - target.forward * distance + Vector3.up * height;

		// Kameran�n yava� hareket etmesini sa�la
		transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);

		// Kameran�n hedefi izlemesini sa�la
		transform.LookAt(target.position);
	}
}
