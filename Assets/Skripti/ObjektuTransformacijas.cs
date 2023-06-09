using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacijas : MonoBehaviour {
	public Objekti objektuSkripts;

	void Update()
	{
		if (objektuSkripts.pedejaisVilktais != null) //ja pedejais vilktais objekts nav null
		{
			if (Input.GetKey(KeyCode.Z)) //z poga
			{
				objektuSkripts.pedejaisVilktais.
				GetComponent<RectTransform>().Rotate(0, 0, Time.deltaTime * 50f); //rote pa kreisi
			}

			if (Input.GetKey(KeyCode.X)) //x poga
			{
				objektuSkripts.pedejaisVilktais.
				GetComponent<RectTransform>().Rotate(0, 0, -Time.deltaTime * 50f); //rote pa labi
			}

			if (Input.GetKey(KeyCode.UpArrow)) //bulitna uz augsu
			{
				if (objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().transform.localScale.y <= 0.8f) //parbauda izmeru
				{
					objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale =
						new Vector2(objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale.x,
						objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale.y + 0.005f); //palielina garumu
				}
			}

			if (Input.GetKey(KeyCode.DownArrow))
			{
				if (objektuSkripts.pedejaisVilktais.
					GetComponent<RectTransform>().transform.localScale.y >= 0.35f) //parbauda izmeru
				{
					objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale =
						new Vector2(objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale.x,
						objektuSkripts.pedejaisVilktais.
						GetComponent<RectTransform>().transform.localScale.y - 0.005f); //samazina garumu
				}
			}


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x >= 0.35f)
                {
                    objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale.x - 0.005f,
                        objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale.y); //samazina platumu
                }
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuSkripts.pedejaisVilktais.
                    GetComponent<RectTransform>().transform.localScale.x <= 0.8f)
                {
                    objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale =
                        new Vector2(objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale.x + 0.005f,
                        objektuSkripts.pedejaisVilktais.
                        GetComponent<RectTransform>().transform.localScale.y); //palielina platumu
                }
            }
        }
	}
}
