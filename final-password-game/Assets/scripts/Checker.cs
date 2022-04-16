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
    public GameObject num1Color, num2Color, num3Color, num4Color, num5Color, num6Color;
    public int lives; public TMP_Text text;
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
        lives--;
        text.text = lives.ToString();
        switch (lives)
        {
            case 0:
                GameObject.Find("CM vcam1").SetActive(false);
                GameObject.Find("CM vcam3").SetActive(false);
                GameObject.Find("CM vcam4").SetActive(false);
                text.text = 0.ToString();
                break;
            default:
                switch (CheckNumber(curNum1, realnum2) || CheckNumber(curNum1, realnum3) || CheckNumber(curNum1, realnum4) || CheckNumber(curNum1, realnum5) || CheckNumber(curNum1, realnum6))
                {
                    case true:
                        Debug.Log("yellow for 1");
                        num1Color.GetComponent<Image>().color = Color.yellow;
                        break;
                    case false:
                        num1Color.GetComponent<Image>().color = Color.white;
                        break;
                }
                switch (CheckNumber(curNum2, realnum1) || CheckNumber(curNum2, realnum3) || CheckNumber(curNum2, realnum4) || CheckNumber(curNum2, realnum5) || CheckNumber(curNum2, realnum6))
                {
                    case true:
                        Debug.Log("yellow for 2");
                        num2Color.GetComponent<Image>().color = Color.yellow;
                        break;
                    case false:
                        num2Color.GetComponent<Image>().color = Color.white;
                        break;
                }
                switch (CheckNumber(curNum3, realnum2) || CheckNumber(curNum3, realnum1) || CheckNumber(curNum3, realnum4) || CheckNumber(curNum3, realnum5) || CheckNumber(curNum3, realnum6))
                {
                    case true:
                        Debug.Log("yellow for 3");
                        num3Color.GetComponent<Image>().color = Color.yellow;
                        break;
                    case false:
                        num3Color.GetComponent<Image>().color = Color.white;
                        break;
                }
                switch (CheckNumber(curNum4, realnum2) || CheckNumber(curNum4, realnum3) || CheckNumber(curNum4, realnum1) || CheckNumber(curNum4, realnum5) || CheckNumber(curNum4, realnum6))
                {
                    case true:
                        Debug.Log("yellow for 4");
                        num4Color.GetComponent<Image>().color = Color.yellow;
                        break;
                    case false:
                        num4Color.GetComponent<Image>().color = Color.white;
                        break;
                }
                switch (CheckNumber(curNum5, realnum2) || CheckNumber(curNum5, realnum3) || CheckNumber(curNum5, realnum1) || CheckNumber(curNum4, realnum5) || CheckNumber(curNum5, realnum6))
                {
                    case true:
                        Debug.Log("yellow for 5");
                        num5Color.GetComponent<Image>().color = Color.yellow;
                        break;
                    case false:
                        num5Color.GetComponent<Image>().color = Color.white;
                        break;
                }
                switch (CheckNumber(curNum6, realnum2) || CheckNumber(curNum6, realnum3) || CheckNumber(curNum6, realnum1) || CheckNumber(curNum6, realnum5) || CheckNumber(curNum4, realnum6))
                {
                    case true:
                        Debug.Log("yellow for 6");
                        num6Color.GetComponent<Image>().color = Color.yellow;
                        break;
                    case false:
                        num6Color.GetComponent<Image>().color = Color.white;
                        break;
                }
                switch (CheckNumber(curNum1, realnum1))
                {
                    case true:
                        Debug.Log("green for 1");
                        num1Color.GetComponent<Image>().color = Color.green;
                        isNum1 = true;
                        break;
                    case false:
                        break;
                }
                switch (CheckNumber(curNum2, realnum2))
                {
                    case true:
                        Debug.Log("green for 2");
                        num2Color.GetComponent<Image>().color = Color.green;
                        isNum2 = true;
                        break;
                    case false:
                        break;
                }
                switch (CheckNumber(curNum3, realnum3))
                {
                    case true:
                        Debug.Log("green for 3");
                        num3Color.GetComponent<Image>().color = Color.green;
                        isNum3 = true;
                        break;
                    case false:
                        break;
                }
                switch (CheckNumber(curNum4, realnum4))
                {
                    case true:
                        Debug.Log("green for 4");
                        num4Color.GetComponent<Image>().color = Color.green;
                        isNum4 = true;
                        break;
                    case false:
                        break;
                }
                switch (CheckNumber(curNum5, realnum5))
                {
                    case true:
                        Debug.Log("green for 5");
                        num5Color.GetComponent<Image>().color = Color.green;
                        isNum5 = true;
                        break;
                    case false:
                        break;
                }
                switch (CheckNumber(curNum6, realnum6))
                {
                    case true:
                        Debug.Log("green for 6");
                        num6Color.GetComponent<Image>().color = Color.white;
                        isNum6 = true;
                        break;
                    case false:
                        break;
                }
                switch (CheckAllNumbers())
                {
                    case true:

                        switch (WhatIReference)
                        {
                            case "Z":
                                PlayerPrefs.SetString("letter1", "Z");
                                break;
                            case "O":
                                PlayerPrefs.SetString("letter2", "O");
                                break;
                            case "R":
                                PlayerPrefs.SetString("letter3", "R");
                                break;
                            case "L":
                                PlayerPrefs.SetString("letter4", "L");
                                break;
                            case "A":
                                PlayerPrefs.SetString("letter5", "A");
                                break;
                            case "M":
                                PlayerPrefs.SetString("letter6", "M");
                                break;
                            case "A2":
                                PlayerPrefs.SetString("letter7", "A");
                                break;
                            case "K":
                                PlayerPrefs.SetString("letter8", "K");
                                break;

                        }
                        SceneManager.LoadScene("Sections");
                        break;


                }
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
