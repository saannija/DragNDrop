using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

public class Timer : MonoBehaviour {

    public static float taimeris; //taimeris
    public GameObject teksts; //teksta laucins, kur var redzet laiku
    private static string laiks; //tiek uzglabats laiks

	// Use this for initialization
	void Start () 
    {
        taimeris = 0;
        laiks = hronometrs(false); 
        teksts.GetComponent<Text>().text = laiks;
	}

    //tiek skaitits laiks (parveidots, sarekinats)
    public static string hronometrs(bool sek)
    {
        int s, min, h;
        s = Mathf.RoundToInt(taimeris); //noapalo

        h = s / (60 * 60); //aprekina stundas
        s -= h * (60 * 60); //cik sekundes paliek
        min = s / 60; //aprekina minutes
        s -= min * 60; //cik sekundes paliek, beigas iegust laiku stundas, minutes un sekundes

        string sekund, minut, stund; //laika pierakstisanai teksta lodzina

        if (s < 10) //ja sekundes <10 vajag 0 prieksa
            sekund = ":0" + s;
        else //nevajag
            sekund = ":" + s;

        if (min < 10)
            minut = ":0" + min;
        else
            minut = ":" + min;

        if (h < 10)
            stund = "0" + h;
        else
            stund = "" + h;

        laiks = stund + minut + sekund; //saskaita string vertibas, lai iegutu vienu

        return laiks; //atgriez laiku
    }
    // Update is called once per frame
    void Update () {
        taimeris += Time.deltaTime; //laika starpiba
        laiks = hronometrs(false); //formatesana
        teksts.GetComponent<Text>().text = laiks; //izvadisana ekrana
	}
}
