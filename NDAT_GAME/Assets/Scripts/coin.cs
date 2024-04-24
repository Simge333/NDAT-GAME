using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

	private int score = 0; // Puan
	public float destroyDelay = 1f; // Yok olma gecikme s�resi (saniye)
	void OnCollisionEnter(Collision collision)
	{
		// �arp��t���m�z nesnenin etiketini kontrol et
		if (collision.gameObject.CompareTag("Player"))
		{
			// E�er �arp���lan nesnenin etiketi "Collectible" ise, 1 puan ekleyelim
			score++;
			Debug.Log("Puan: " + score);
			// E�er �arp���lan nesnenin etiketi "Player" ise, belirli bir s�re sonra yok edelim
			Invoke("DestroyObject", destroyDelay);
		}
	}
	void DestroyObject()
	{
		// Nesneyi yok et
		Destroy(gameObject);
	}
}
