using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//visas masinas
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
	//masinu koordinates
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

	public Canvas kanva; //kanva, kur ir ui elementi

	public AudioSource skanasAvots; //fona muzika
	public AudioClip[] skanasKoAtskanot; //visas masinu skanas

	[HideInInspector]
	public bool vaiIstajaVieta = false; // vai objekts ir pareizaja vieta

	public GameObject pedejaisVilktais = null; //pedejais vilktais (lai mainitu izmeru/rotaciju)


	void Start() {
		//masinu sakuma pozicijas
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
