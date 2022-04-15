using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberController : MonoBehaviour
{
    public Button upButton;
    public Button downButton;
    public TMP_Text text;
    public int currentNumber = 0;
    public int whatIAm;
    Checker checker;
    public GameObject password;
    private void Start()
    {
        checker = password.GetComponent<Checker>();
    }
    public void AddNumber()
    {
        if (currentNumber == 9)
        {
            currentNumber = 0;
        }
        else
        {
            currentNumber++;
        }
        text.text = currentNumber.ToString();
    }

    public void SubtractNumber()
    {
        if (currentNumber == 0)
        {
            currentNumber = 9;
        }
        else
        {
            currentNumber--;
        }
        text.text = currentNumber.ToString();
    }

    public int GetCurrent()
    {
        return currentNumber;
    }
    public void CheckNumber()
    {
        switch (whatIAm)
        {
            case 1: 
                if (currentNumber == checker.realnum2 || currentNumber == checker.realnum3 || currentNumber == checker.realnum4)
                {
                    checker.statusNum1 = "yellow";
                }
                else if (currentNumber == checker.realnum1)
                {
                    checker.statusNum1 = "green";
                }
                break;
            case 2:
                if (currentNumber == checker.realnum1 || currentNumber == checker.realnum3 || currentNumber == checker.realnum4)
                {
                    checker.statusNum2 = "yellow";
                }
                else if (currentNumber == checker.realnum2)
                {
                    checker.statusNum2 = "green";
                }
                break;
            case 3:
                if (currentNumber == checker.realnum1 || currentNumber == checker.realnum2 || currentNumber == checker.realnum4)
                {
                    checker.statusNum3 = "yellow";
                }
                else if (currentNumber == checker.realnum3)
                {
                    checker.statusNum3 = "green";
                }
                break;
            case 4:
                if (currentNumber == checker.realnum1 || currentNumber == checker.realnum2 || currentNumber == checker.realnum3)
                {
                    checker.statusNum4 = "yellow";
                }
                else if (currentNumber == checker.realnum4)
                {
                    checker.statusNum4 = "green";
                }
                break;


        }
    }
}

