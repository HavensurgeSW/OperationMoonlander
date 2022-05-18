using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Jetpack jtpk;
    public Text statusVal;
    public Text gradeVal;

    // Update is called once per frame
    public void OnEnable(){
        if(jtpk.winstatus)
            statusVal.text = "Status: Success";
        else{
             statusVal.text = "Status: Failure";
             gradeVal.text = "Grade: D";
        }

        if(jtpk.getFuel()<(jtpk.maxFuel/4))
            gradeVal.text = "Grade: D";

        if(jtpk.getFuel()>(jtpk.maxFuel/4))
            gradeVal.text = "Grade: C";
        
        if(jtpk.getFuel()>(jtpk.maxFuel/4)*2)
            gradeVal.text = "Grade: B";

        if(jtpk.getFuel()>(jtpk.maxFuel/4)*3)
            gradeVal.text = "Grade: A";

    }

    
}
