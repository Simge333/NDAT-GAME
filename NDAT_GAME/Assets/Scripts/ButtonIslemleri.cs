using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonIslemleri : MonoBehaviour
{
	public void OnButtonClick()
	{
		// �stenilen sahnenin ad�n� SceneManager ile y�kleyebiliriz.
		// �rne�in, "YeniSahne" adl� bir sahneye ge�mek i�in:
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	
	}

}
