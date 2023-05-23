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

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Uzklikšķināts uz velkama objekta!");
    }

    //Turpināsim no šīs vietas
    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }
}
