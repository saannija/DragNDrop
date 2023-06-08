using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, 
	IDropHandler{
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;
    private int pareizajaVieta = 0;

    public void OnDrop(PointerEventData eventData)
    {
		if (eventData.pointerDrag != null)
		{
			if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot =
				GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba =
				Mathf.Abs(vietasZRot - velkObjZRot);

				vietasIzm =
				eventData.pointerDrag.
				GetComponent<RectTransform>().localScale;

				velkObjIzm =
					GetComponent<RectTransform>().localScale;

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

				Debug.Log("Objektu rotācijas starpība: " + rotacijasStarpiba
					+ "\nPlatuma starpība: " + xIzmStarpiba +
					"\nAugstuma starpība: " + yIzmStarpiba);


				if ((rotacijasStarpiba <= 6 ||
					(rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{
					Debug.Log("Nomests pareizajā vietā!"); ///////////////////////
                    objektuSkripts.vaiIstajaVieta = true;
                    pareizajaVieta++;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
						= GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
						GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale =
						GetComponent<RectTransform>().localScale;

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
                                objektuSkripts.skanasKoAtskanot[4]);
                            break;

                        case "policija":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[6]);
                            break;

                        case "traktors1":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[7]);
                            break;

                        case "traktors2":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[8]);
                            break;

                        case "traktors3":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[9]);
                            break;

                        case "traktors4":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[10]);
                            break;

                        case "ugunsdzeseji":
                            objektuSkripts.skanasAvots.PlayOneShot(
                                objektuSkripts.skanasKoAtskanot[11]);
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
