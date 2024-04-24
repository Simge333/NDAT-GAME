using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
	public Transform target; // Takip edilecek karakterin Transform bileþeni
	public float distance = 5.0f; // Kameranýn karakterden uzaklýðý
	public float height = 2.0f; // Kameranýn yüksekliði
	public float smoothSpeed = 2.0f; // Kameranýn yumuþaklýk hýzý

	void LateUpdate()
	{
		// Kameranýn hedef konumu
		Vector3 targetPosition = target.position - target.forward * distance + Vector3.up * height;

		// Kameranýn yavaþ hareket etmesini saðla
		transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);

		// Kameranýn hedefi izlemesini saðla
		transform.LookAt(target.position);
	}
}
