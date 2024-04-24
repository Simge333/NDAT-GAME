using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float moveSpeed = 5f; // Karakterin hareket h�z�
	public float jumpForce = 10f; // Z�plama kuvveti
	
	private Rigidbody rb;
	void Start()
	{
		// Rigidbody bile�enini al
		rb = GetComponent<Rigidbody>();
	}
	void Update()
	{
		
		// Klavyeden giri� al
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		// Hareket y�n�n� olu�tur
		Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

		// Hareketi uygula
		transform.Translate(movement);

		// Z�plama i�levselli�i
		if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
		{
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}
	}
	bool IsGrounded()
	{
		// Karakterin yerde olup olmad���n� kontrol et
		return Physics.Raycast(transform.position, Vector3.down, 1f);
	}

}
