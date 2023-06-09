using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

public class Timer : MonoBehaviour {

    public static float taimeris;
    public GameObject teksts;
    private static string laiks;

	// Use this for initialization
	void Start () 
    {
        taimeris = 0;
        laiks = hronometrs(false);
        teksts.GetComponent<Text>().text = laiks;
	}

    public static string hronometrs(bool sek)
    {
        int s, min, h;
        s = Mathf.RoundToInt(taimeris);

        h = s / (60 * 60);
        s -= h * (60 * 60);
        min = s / 60;
        s -= min * 60;

        string sekund, minut, stund;

        if (s < 10)
            sekund = ":0" + s;
        else
            sekund = ":" + s;

        if (min < 10)
            minut = ":0" + min;
        else
            minut = ":" + min;

        if (h < 10)
            stund = "0" + h;
        else
            stund = "" + h;

        laiks = stund + minut + sekund;

        return laiks;
    }
    // Update is called once per frame
    void Update () {
        taimeris += Time.deltaTime;
        laiks = hronometrs(false);
        teksts.GetComponent<Text>().text = laiks;
	}
}
