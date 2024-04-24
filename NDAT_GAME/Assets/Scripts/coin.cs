using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

	private int score = 0; // Puan
	public float destroyDelay = 1f; // Yok olma gecikme süresi (saniye)
	void OnCollisionEnter(Collision collision)
	{
		// Çarpýþtýðýmýz nesnenin etiketini kontrol et
		if (collision.gameObject.CompareTag("Player"))
		{
			// Eðer çarpýþýlan nesnenin etiketi "Collectible" ise, 1 puan ekleyelim
			score++;
			Debug.Log("Puan: " + score);
			// Eðer çarpýþýlan nesnenin etiketi "Player" ise, belirli bir süre sonra yok edelim
			Invoke("DestroyObject", destroyDelay);
		}
	}
	void DestroyObject()
	{
		// Nesneyi yok et
		Destroy(gameObject);
	}
}
