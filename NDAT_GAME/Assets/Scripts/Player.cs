using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float moveSpeed = 5f; // Karakterin hareket hýzý
	public float jumpForce = 10f; // Zýplama kuvveti
	
	private Rigidbody rb;
	void Start()
	{
		// Rigidbody bileþenini al
		rb = GetComponent<Rigidbody>();
	}
	void Update()
	{
		
		// Klavyeden giriþ al
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		// Hareket yönünü oluþtur
		Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

		// Hareketi uygula
		transform.Translate(movement);

		// Zýplama iþlevselliði
		if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
		{
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}
	}
	bool IsGrounded()
	{
		// Karakterin yerde olup olmadýðýný kontrol et
		return Physics.Raycast(transform.position, Vector3.down, 1f);
	}

}
