using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking.NetworkSystem;

public class Uzvara : MonoBehaviour {

	public GameObject uzvara;
	public Text uzvarasLaiks;
	public GameObject laiks;

    public GameObject zvaigzne1;
	public GameObject zvaigzne2;
	public GameObject zvaigzne3;

    void Start () {
		uzvara.SetActive(false);
	}

	public void Atkartot()
	{
		SceneManager.LoadScene("PilsetasKarte");
		laiks.SetActive(true);
	}

	public void speleBeidzas()
	{
		NomesanasVieta.correctObjectCount = 0;
        laiks.SetActive(false);
		uzvara.SetActive(true);
		uzvarasLaiks.text = Timer.hronometrs(false);

		int s = Convert.ToInt32(Timer.hronometrs(true));

		if (s < 60 * 2) //3 zvaigznes, ja patereja < 2 minutes
		{
			zvaigzne1.SetActive(true);
			zvaigzne2.SetActive(true);
			zvaigzne3.SetActive(true);
		}
		else if (s < 60 * 3) //2 zvaigznes
		{
			zvaigzne1.SetActive(true);
			zvaigzne2.SetActive(true);
			zvaigzne3.SetActive(false);
		}
		else //1 zvaigzne
		{
			zvaigzne1.SetActive(true);
			zvaigzne2.SetActive(false);
			zvaigzne3.SetActive(false);
		}
	}
	
}
