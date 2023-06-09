using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AinasParslegsana : MonoBehaviour {

	public void Sakt () { //piespiesta poga start
		SceneManager.LoadScene("PilsetasKarte"); //sakas speles aina
	}

	public void Atpakal() //atgriezties uz startu
	{
		SceneManager.LoadScene("Starts");
	}

	public void Aizvert() //aizvert aplikaciju
	{
		Application.Quit();
	}
}
