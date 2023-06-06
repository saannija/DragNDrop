using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject cementuMasina;
	public GameObject e46;
	public GameObject e61;
	public GameObject ekskavators;
	public GameObject policija;
	public GameObject traktors;
	public GameObject traktors2;
	public GameObject ugunsdzeseji;

	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 cemenMKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 e61Koord;
	[HideInInspector]
	public Vector2 ekskavKoord;
	[HideInInspector]
	public Vector2 policijaKoord;
	[HideInInspector]
	public Vector2 traktorsKoord;
	[HideInInspector]
	public Vector2 traktors2Koord;
	[HideInInspector]
	public Vector2 ugunsKoord;

	public Canvas kanva;

	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	void Start() {
		atkrMKoord =
        atkritumuMasina.GetComponent<RectTransform>().localPosition;
        
		atrPKoord =
        atraPalidziba.GetComponent<RectTransform>().localPosition;

        bussKoord =
		autobuss.GetComponent<RectTransform>().localPosition;

		b2Koord =
		b2.GetComponent<RectTransform>().localPosition;

		cemenMKoord =
		cementuMasina.GetComponent<RectTransform>().localPosition;

		e46Koord =
		e46.GetComponent<RectTransform>().localPosition;

		e61Koord =
		e61.GetComponent<RectTransform>().localPosition;

		ekskavKoord =
		ekskavators.GetComponent<RectTransform>().localPosition;

		policijaKoord =
		policija.GetComponent<RectTransform>().localPosition;

		traktorsKoord =
		traktors.GetComponent<RectTransform>().localPosition;

		traktors2Koord =
		traktors2.GetComponent<RectTransform>().localPosition;

		ugunsKoord =
		ugunsdzeseji.GetComponent<RectTransform>().localPosition;
    }
}
