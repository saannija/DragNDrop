using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking.NetworkSystem;

public class Uzvara : MonoBehaviour {

	public GameObject uzvara; //uzvaras ui
	public Text uzvarasLaiks; //uzvaras laiks prieks ui
	public GameObject laiks; //laiks no speles

    public GameObject zvaigzne1; // zvaigznes, kuras paradisies pec izpilditajiem nosacijumiem
	public GameObject zvaigzne2;
	public GameObject zvaigzne3;

    void Start () {
		uzvara.SetActive(false); //nerada uzvaras ui
	}

	//iespeja velreiz soelet
	public void Atkartot()
	{
		SceneManager.LoadScene("PilsetasKarte"); //parada speli no jauna
		laiks.SetActive(true); //starte laiku no jauna
	}

	//kad ir uzvarets
	public void speleBeidzas()
	{
		NomesanasVieta.pareizaPoz = 0; //sak skaititaju no jauna (gadijuma, ja grib velreiz spelet)
        laiks.SetActive(false); //apstajas laiks
		uzvara.SetActive(true); //paradas uzvaras ui
		uzvarasLaiks.text = Timer.hronometrs(false); //iegust laiku, cik speleja

		int s = Convert.ToInt32(Timer.hronometrs(true)); //iegust sekundes

		if (s < 60 * 2) // 3 zvaigznes, ja < par 2min
		{
			zvaigzne1.SetActive(true);
			zvaigzne2.SetActive(true);
			zvaigzne3.SetActive(true);
		}
		else if (s < 60 * 3) //2 zvaigznes, ja < par 3min
		{
			zvaigzne1.SetActive(true);
			zvaigzne2.SetActive(true);
			zvaigzne3.SetActive(false);
		}
		else //1 zvaigzne, ja > par 3min
		{
			zvaigzne1.SetActive(true);
			zvaigzne2.SetActive(false);
			zvaigzne3.SetActive(false);
		}
	}
	
}
