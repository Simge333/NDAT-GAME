using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class coin : MonoBehaviour
{
	public float destroyDelay = 0.5f; // Yok olma gecikme s�resi (saniye)
	
	private void OnTriggerEnter(Collider other)
	{
		// �arp��t���m�z nesnenin etiketini kontrol et
		if (other.gameObject.CompareTag("Player"))
		{
			Invoke("DestroyObject", destroyDelay);
		}
	}
	void DestroyObject()
	{
		// Nesneyi yok et
		Destroy(gameObject);
	}
	
	
}
