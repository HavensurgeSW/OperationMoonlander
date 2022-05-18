using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Jetpack jtpk;
    public float val;
    public Text fuelVal;
    public Text velVal;

    void Update(){
        fuelVal.text = "Fuel remaining (S): " + jtpk.getFuel().ToString("0.00");
        velVal.text = "Current speed: " + jtpk.getVel().ToString("0.00");
    }
}
