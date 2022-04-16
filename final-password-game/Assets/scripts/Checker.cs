using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Checker : MonoBehaviour
{   

    public int realnum1,realnum2,realnum3,realnum4;
    public string statusNum1, statusNum2, statusNum3, statusNum4;
    private int curnum1, curnum2,curnum3,curnum4;
    
    void Start()
    {

    }

    void Update()
    {
        
    }
    public void Submit()
    {
        
    }
    public void setNum(int i, int j)
    {
        if (i == 1)
        {
            curnum1 = j;
        }
        else if (i == 2)
        {
            curnum2 = j;
        }
        else if (i == 3)
        {
            curnum3 = j;
        }
        else
        {
            curnum4 = j;
        }
    }
}
