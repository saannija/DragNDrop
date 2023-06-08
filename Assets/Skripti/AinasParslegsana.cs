using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AinasParslegsana : MonoBehaviour {

	public void Sakt () {
		SceneManager.LoadScene("PilsetasKarte");
	}

	public void Atpakal()
	{
		SceneManager.LoadScene("Starts");
	}

	public void Aizvert()
	{
		Application.Quit();
	}
}
