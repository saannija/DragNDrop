using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler
{
	private float vietasZRot, velkObjZRot, rotacijasStarpiba; //rotacijas mainigie
	private Vector2 vietasIzm, velkObjIzm; //izmera mainigie
	private float xIzmStarpiba, yIzmStarpiba; //pozicijas mainigie
    public Objekti objektuSkripts; //objekts, kas satur skriptu Objekti

	[HideInInspector]
    public static int pareizaPoz = 0; //cik objekti ir nomesti pareizaja pozicija

	public Uzvara uzv; //objekts, kas satur skriptu Uzvara

	//nav nepieciesams, bija vajadzigs problemu noversanai! :)
    private void Start() 
    {
        // Find the GameObject with the Uzvara script and assign it to the uzv variable
        uzv = GameObject.FindObjectOfType<Uzvara>(); //atrod uzvaras skriptu (radas problemas bez sis rindinas, tadel pievienota)

        if (uzv == null) // ja uzvara ir null (kludas noversanai)
        {
            Debug.LogError("Nevareja atrast Uzvaras skriptu");
        }
    }
    public void OnDrop(PointerEventData eventData) // objekta nomesana
	{
		Debug.Log("OnDrop");
		if (eventData.pointerDrag != null) // ja velkamais objekts nav null
		{
			if (eventData.pointerDrag.tag.Equals(tag)) //objekta tag sakrit ar vietas tag
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform>().transform.eulerAngles.z; //vietas rotacija

				velkObjZRot =
				GetComponent<RectTransform>().transform.eulerAngles.z; //objekta rotacija

				rotacijasStarpiba =
				Mathf.Abs(vietasZRot - velkObjZRot); //rotacijas starpiba (lai noteiktu snapping opciju)

				vietasIzm =
				eventData.pointerDrag.
				GetComponent<RectTransform>().localScale; //vietas izmers

				velkObjIzm =
					GetComponent<RectTransform>().localScale; //objekta izmers

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y); // garuma un platuma sarpība (lai noteiktu snapping)

				Debug.Log("Objektu rotācijas starpība: " + rotacijasStarpiba
					+ "\nPlatuma starpība: " + xIzmStarpiba +
					"\nAugstuma starpība: " + yIzmStarpiba);

				//ja sakrit rotacija, garums un platums
				if ((rotacijasStarpiba <= 6 ||
					(rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{

                    objektuSkripts.vaiIstajaVieta = true; //objektu skripta parada, ka ir istaja vieta (lai tur var notikt talakas darbibas)
         
                    pareizaPoz++; //pieskaita pie objektu skaita, kas ir pareizaja pozicija
                    if (pareizaPoz == 12) //ja visas masinas pareizaja pozicija
                    {
                        uzv.speleBeidzas(); //uzvaras ui
                    }
                    Debug.Log("Correct Object Count: " + pareizaPoz);

					//objekts paliek tada pasa izmera un rotacija, ka paredzeta vieta
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
						= GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
						GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale =
						GetComponent<RectTransform>().localScale;

					//lai atrastu pareizo skanu, kuru spelet, kad nomests konkrets objekts
					switch (eventData.pointerDrag.tag) {
						case "atkritumi":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[1]);
							break;

						case "atrie":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[2]);
							break;

						case "buss":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[3]);
							break;

						case "masina1":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[4]);
							break;

						case "masina2":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[5]);
							break;

						case "masina3":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[6]);
							break;

						case "policija":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[7]);
							break;

						case "traktors1":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[8]);
							break;

						case "traktors2":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[9]);
							break;

						case "traktors3":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[10]);
							break;

						case "traktors4":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[11]);
							break;

						case "ugunsdzeseji":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[12]);
							break;

						default:
							Debug.Log("Tags nav definēts!");
							break;
					}
				}

				//Ja tagi nesakrīt, tātad nepareizajā vietā
			} else	{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(
					objektuSkripts.skanasKoAtskanot[0]);

				//atgriez masinu sakuma vieta, ja novietota nepareizi
				switch (eventData.pointerDrag.tag){
					case "atkritumi":
						objektuSkripts.atkritumuMasina.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.atkrMKoord;
						break;

					case "atrie":
						objektuSkripts.atraPalidziba.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.atrPKoord;
						break;

					case "buss":
						objektuSkripts.autobuss.
						 GetComponent<RectTransform>().localPosition =
						 objektuSkripts.bussKoord;
						break;

					case "masina1":
						objektuSkripts.b2.
						 GetComponent<RectTransform>().localPosition =
						 objektuSkripts.b2Koord;
						break;

					case "masina2":
						objektuSkripts.e46.
						 GetComponent<RectTransform>().localPosition =
						 objektuSkripts.e46Koord;
						break;

					case "masina3":
						objektuSkripts.e61.
						 GetComponent<RectTransform>().localPosition =
						 objektuSkripts.e61Koord;
						break;

					case "policija":
						objektuSkripts.policija.
						 GetComponent<RectTransform>().localPosition =
						 objektuSkripts.policijaKoord;
						break;

					case "traktors1":
						objektuSkripts.cementuMasina.
						 GetComponent<RectTransform>().localPosition =
						 objektuSkripts.cemenMKoord;
						break;

					case "traktors2":
						objektuSkripts.ekskavators.
						 GetComponent<RectTransform>().localPosition =
						 objektuSkripts.ekskavKoord;
						break;

					case "traktors3":
						objektuSkripts.traktors.
						 GetComponent<RectTransform>().localPosition =
						 objektuSkripts.traktorsKoord;
						break;

					case "traktors4":
						objektuSkripts.traktors2.
						 GetComponent<RectTransform>().localPosition =
						 objektuSkripts.traktors2Koord;
						break;

					case "ugunsdzeseji":
						objektuSkripts.ugunsdzeseji.
						 GetComponent<RectTransform>().localPosition =
						 objektuSkripts.ugunsKoord;
						break;

					default:
						Debug.Log("Tags nav definēts!");
						break;
				}
			}
		}
		
	}
}
