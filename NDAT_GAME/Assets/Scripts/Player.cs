using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	private int score = 0; // Puan
	[SerializeField] Text ScoreText;
	public float moveSpeed = 5f; // Karakterin hareket h�z�
	public float jumpForce = 10f; // Z�plama kuvveti
	private int health=100;
	[SerializeField] Text HText;

	private Rigidbody rb;
	void Start()
	{
		// Rigidbody bile�enini al
		rb = GetComponent<Rigidbody>();
	}
	
	#region Hareket Islemleri
	void Update()
	{
		ScoreText.text = "Score : " + ((int)score).ToString();
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
		#region CAN
		HText.text = "Can : " + ((int)health).ToString();


		#endregion
	}
	bool IsGrounded()
	{
		// Karakterin yerde olup olmad���n� kontrol et
		return Physics.Raycast(transform.position, Vector3.down, 1f);
	}
	#endregion

	#region Enemy Islemleri

	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("enemy"))
		{
			health -= 10;
			Debug.Log(health);
			if (health<=0)
			{
				Destroy(this.gameObject);
			}
		}
	}

	#endregion

	private void OnTriggerEnter(Collider other)
	{
		// �arp��t���m�z nesnenin etiketini kontrol et
		if (other.gameObject.CompareTag("coin"))
		{
			// E�er �arp���lan nesnenin etiketi "Collectible" ise, 1 puan ekleyelim
			score++;
				
		}
	}

}
