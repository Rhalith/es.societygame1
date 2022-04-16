using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Checker : MonoBehaviour
{
    //Letter is ZORLAMAK
    public int realnum1,realnum2,realnum3,realnum4, realnum5, realnum6;
    public string WhatIReference;
    public string REMEMBER_REAL = "NUMBER_5OR6";
    private int curNum1, curNum2, curNum3, curNum4, curNum5, curNum6;
    private bool isNum1, isNum2, isNum3, isNum4, isNum5, isNum6;
    TMP_Text text; 
    public void setNum(int controlnum, int curnum)
    {
        if (controlnum == 1)
        {
            curNum1 = curnum;
        }
        else if (controlnum == 2)
        {
            curNum2 = curnum;
        }
        else if (controlnum == 3)
        {
            curNum3 = curnum;
        }
        else
        {
            curNum4 = curnum;
        }
    }
    public void Submit()
    {
        switch(CheckNumber(curNum1,realnum2) || CheckNumber(curNum1,realnum3) || CheckNumber(curNum1, realnum4) || CheckNumber(curNum1,realnum5) || CheckNumber(curNum1, realnum6))
        {
            case true:
                Debug.Log("yellow for 1");
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum2, realnum1) || CheckNumber(curNum2, realnum3) || CheckNumber(curNum2, realnum4) || CheckNumber(curNum2, realnum5) || CheckNumber(curNum2, realnum6))
        {
            case true:
                Debug.Log("yellow for 2");
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum3, realnum2) || CheckNumber(curNum3, realnum1) || CheckNumber(curNum3, realnum4) || CheckNumber(curNum3, realnum5) || CheckNumber(curNum3, realnum6))
        {
            case true:
                Debug.Log("yellow for 3");
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum4, realnum2) || CheckNumber(curNum4, realnum3) || CheckNumber(curNum4, realnum1) || CheckNumber(curNum4, realnum5) || CheckNumber(curNum4, realnum6))
        {
            case true:
                Debug.Log("yellow for 4");
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum5, realnum2) || CheckNumber(curNum5, realnum3) || CheckNumber(curNum5, realnum1) || CheckNumber(curNum4, realnum5) || CheckNumber(curNum5, realnum6))
        {
            case true:
                Debug.Log("yellow for 5");
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum6, realnum2) || CheckNumber(curNum6, realnum3) || CheckNumber(curNum6, realnum1) || CheckNumber(curNum6, realnum5) || CheckNumber(curNum4, realnum6))
        {
            case true:
                Debug.Log("yellow for 6");
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum1, realnum1))
        {
            case true:
                Debug.Log("green for 1");
                isNum1 = true;
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum2, realnum2))
        {
            case true:
                Debug.Log("green for 2");
                isNum2 = true;
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum3, realnum3))
        {
            case true:
                Debug.Log("green for 3");
                isNum3 = true;
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum4, realnum4))
        {
            case true:
                Debug.Log("green for 4");
                isNum4 = true;
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum5, realnum5))
        {
            case true:
                Debug.Log("green for 5");
                isNum5 = true;
                break;
            case false:
                break;
        }
        switch (CheckNumber(curNum6, realnum6))
        {
            case true:
                Debug.Log("green for 6");
                isNum6 = true;
                break;
            case false:
                break;
        }
        switch (CheckAllNumbers())
        {
            case true:
                GameObject[] goArray = SceneManager.GetSceneByName("Sections").GetRootGameObjects();
                switch (WhatIReference)
                {
                    case "Z":
                        for (int i = 0; i < goArray.Length; i++)
                        {
                            if (goArray[i].tag == "letter1")
                            {
                                goArray[i].GetComponent<TextMeshPro>().text = "Z";
                            }
                        }
                        break;
                    case "O":
                        for (int i = 0; i < goArray.Length; i++)
                        {
                            if (goArray[i].tag == "letter2")
                            {
                                goArray[i].GetComponent<TextMeshPro>().text = "Z";
                            }
                        }
                        break;
                    case "R":
                        for (int i = 0; i < goArray.Length; i++)
                        {
                            if (goArray[i].tag == "letter3")
                            {
                                goArray[i].GetComponent<TextMeshPro>().text = "Z";
                            }
                        }
                        break;
                }
                SceneManager.LoadScene("Sections");
                break;

                
        }
    }
    public bool CheckNumber(int curnum, int realnum)
    {
        if (curnum == realnum)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool CheckAllNumbers()
    {
        switch (realnum6)
        {
            case -1:
                switch (isNum4 && isNum3 && isNum2 && isNum1)
                {
                    case true:
                        return true;
                    case false:
                        return false;
                }
                break;
            default:
                switch (isNum6 && isNum5 && isNum4 && isNum3 && isNum2 && isNum1)
                {
                    case true:
                        return true;
                    case false:
                        return false;
                }
                break;

        }

    }
}
