using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPage : MonoBehaviour
{
    public void Next()
    {
		if (SceneManager.GetActiveScene().buildIndex != 10)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}


	public void Previous()
	{
		if (SceneManager.GetActiveScene().buildIndex != 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
		}
	}
}
