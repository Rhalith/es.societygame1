using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Checker : MonoBehaviour
{   
    public GameObject number1, number2, number3, number4;

    public int realnum1,realnum2,realnum3,realnum4;
    public string statusNum1, statusNum2, statusNum3, statusNum4;
    
    NumberController numberController;
    void Start()
    {
        numberController = number1.GetComponent<NumberController>();
    }

    void Update()
    {
        
    }
}
