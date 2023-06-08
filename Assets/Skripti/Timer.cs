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

       /* if (sek)
        {
            return "" + s;
        }*/

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
    //https://www.youtube.com/watch?v=27uKJvOpdYw
    //https://youtu.be/ijAN0QI70UU
    //https://www.youtube.com/watch?v=N_wVaKRr42M
    //https://www.youtube.com/watch?v=YUcvy9PHeXs
    //https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/

    //UI https://www.youtube.com/watch?v=_RIsfVOqTaE
    //https://www.youtube.com/watch?v=lF26yGJbsQk
    // Update is called once per frame
    void Update () {
        taimeris += Time.deltaTime;
        laiks = hronometrs(false);
        teksts.GetComponent<Text>().text = laiks;
	}
}
