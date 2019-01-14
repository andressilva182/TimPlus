using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrintFPS : MonoBehaviour {
    public int Granularity = 5; // how many frames to wait until you re-calculate the FPS
    List<double> times;
    int counter = 5;
    public Text _UIText;

    public void Start()
    {
        times = new List<double>();
    }

    public void Update()
    {
        if (counter <= 0)
        {
            CalcFPS();
            counter = Granularity;
        }

        times.Add(Time.deltaTime);
        counter--;
    }

    public void CalcFPS()
    {
        double sum = 0;
        foreach (double F in times)
        {
            sum += F;
        }

        double average = sum / times.Count;
        double fps = 1 / average;
        _UIText.text = fps+ "";
        // update a GUIText or something
    }
}
