using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jāieimportē, lai varētu lietot visus I interfeisus
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour, 
    IPointerDownHandler, IBeginDragHandler, 
    IDragHandler, IEndDragHandler {
    //Uzglabā norādi uz Objekti skriptu
    public Objekti objektuSkripts;
    //Velkamam objektam piestiprinātā CanvasGoup komponente
    private CanvasGroup kanvasGrupa;
    //Objekta atrašanās vieta, kurš tiek pārvietots
    private RectTransform velkObjRectTransf;

    void Start()
    {
        //Piekļūst objektam piestiprinātajai CanvasGroup
        //komponentei
        kanvasGrupa = GetComponent<CanvasGroup>();
        //Piekļūst objeta RectTransform komponentei
        velkObjRectTransf = GetComponent<RectTransform>();
    }
    //uzsak vilksanu
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Uzklikšķināts uz velkama objekta!");
        objektuSkripts.pedejaisVilktais = null; //pedejais vilktais ir null
        kanvasGrupa.alpha = 0.6f; 
        kanvasGrupa.blocksRaycasts = false;
    }
    //vilksana
    public void OnDrag(PointerEventData eventData)
    {
        velkObjRectTransf.anchoredPosition +=
        eventData.delta / objektuSkripts.kanva.scaleFactor; 
    }
    //beidzas vilksana (nomet)
    public void OnEndDrag(PointerEventData eventData)
    {
        objektuSkripts.pedejaisVilktais =
             eventData.pointerDrag; //samaina pedejo vilkto objektu
        kanvasGrupa.alpha = 1f; 

        if(objektuSkripts.vaiIstajaVieta == false) { //ja nav istaja vieta nekas
            kanvasGrupa.blocksRaycasts = true;

        } else {
            objektuSkripts.pedejaisVilktais = null; //ja ir tad pedejais vilktais ir null
        }

        objektuSkripts.vaiIstajaVieta = false; //nomaina ka objekts nav istaja vieta, lai var parbaudit nakamo
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }
}
