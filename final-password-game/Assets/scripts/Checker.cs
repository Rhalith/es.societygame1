using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Checker : MonoBehaviour
{
    //Letter is ZORLAMAK
    int fornum1, fornum2, fornum3, fornum4, fornum5, fornum6;
    public int realnum1,realnum2,realnum3,realnum4, realnum5, realnum6;
    public string WhatIReference;
    public string REMEMBER_REAL = "NUMBER_5OR6";
    private int curNum1, curNum2, curNum3, curNum4, curNum5, curNum6;
    private bool isNum1, isNum2, isNum3, isNum4, isNum5, isNum6;
    public GameObject num1Color, num2Color, num3Color, num4Color, num5Color, num6Color;
    public int lives; public TMP_Text text;
    public Animator anim;
    private bool yellow1, yellow2, yellow3, yellow4, yellow5, yellow6;
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
        //switch (lives)
        //{
        //    case 0:
        //        anim.SetTrigger("Close");
        //        if (GameObject.Find("CM vcam1") != null)
        //        {
        //            GameObject.Find("CM vcam1").SetActive(false);
        //        }
        //        if (GameObject.Find("CM vcam4") != null)
        //        {
        //            GameObject.Find("CM vcam4").SetActive(false);
        //        }
        //        if (GameObject.Find("CM vcam3") != null)
        //        {
        //            GameObject.Find("CM vcam3").SetActive(false);
        //        }
        //        GameObject.Find("CanvasForButtons").SetActive(true);
        //        text.text = 0.ToString();
        //        break;
        //    default:
        //        switch (CheckNumber(curNum1, realnum1))
        //        {
        //            case true:
        //                num1Color.GetComponent<Image>().color = Color.green;
        //                isNum1 = true;
        //                break;
        //            case false:
        //                break;
        //        }
        //        switch (CheckNumber(curNum2, realnum2))
        //        {
        //            case true:
        //                num2Color.GetComponent<Image>().color = Color.green;
        //                isNum2 = true;
        //                break;
        //            case false:
        //                break;
        //        }
        //        switch (CheckNumber(curNum3, realnum3))
        //        {
        //            case true:
        //                num3Color.GetComponent<Image>().color = Color.green;
        //                isNum3 = true;
        //                break;
        //            case false:
        //                break;
        //        }
        //        switch (CheckNumber(curNum4, realnum4))
        //        {
        //            case true:
        //                num4Color.GetComponent<Image>().color = Color.green;
        //                isNum4 = true;
        //                break;
        //            case false:
        //                break;
        //        }
        //        switch (CheckNumber(curNum5, realnum5))
        //        {
        //            case true:
        //                num5Color.GetComponent<Image>().color = Color.green;
        //                isNum5 = true;
        //                break;
        //            case false:
        //                break;
        //        }
        //        switch (CheckNumber(curNum6, realnum6))
        //        {
        //            case true:
        //                num6Color.GetComponent<Image>().color = Color.white;
        //                isNum6 = true;
        //                break;
        //            case false:
        //                break;
        //        }
        //        if (CheckNumber(curNum1, realnum2) && !yellow2 && !isNum1)
        //        {
        //            if (!isNum2){ yellow2 = true; num1Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum1, realnum3) && !yellow3 && !isNum1)
        //        {
        //            if (!isNum3){ yellow3 = true; num1Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum1, realnum4) && !yellow4 && !isNum1)
        //        {
        //            if (!isNum4) { yellow4 = true; num1Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum1, realnum5) && !yellow5 && !isNum1)
        //        {
        //            if (!isNum5){ yellow5 = true; num1Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum1, realnum6) && !yellow6 && !isNum1)
        //        {
        //            if (!isNum6){ yellow6 = true; num1Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (!isNum1)
        //        {
        //            num1Color.GetComponent<Image>().color = Color.white;
        //        }
        //        //switch (CheckNumber(curNum1, realnum2) || CheckNumber(curNum1, realnum3) || CheckNumber(curNum1, realnum4) || CheckNumber(curNum1, realnum5) || CheckNumber(curNum1, realnum6))
        //        //{
        //        //    case true:
        //        //        Debug.Log("yellow for 1");
        //        //        num1Color.GetComponent<Image>().color = Color.yellow;
        //        //        break;
        //        //    case false:
        //        //        num1Color.GetComponent<Image>().color = Color.white;
        //        //        break;
        //        //}
        //        if (CheckNumber(curNum2, realnum1) && !yellow1 && !isNum2)
        //        {
        //            if (!isNum1){ yellow1 = true; num2Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum2, realnum3) && !yellow3 && !isNum2)
        //        {
        //            if (!isNum3){ yellow3 = true; num2Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum2, realnum4) && !yellow4 && !isNum2)
        //        {
        //            if (!isNum4){ yellow4 = true; num2Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum2, realnum5) && !yellow5 && !isNum2)
        //        {
        //            if (!isNum5){ yellow5 = true; num2Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum2, realnum6) && !yellow6 && !isNum2)
        //        {
        //            if (!isNum6){ yellow6 = true; num2Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (!isNum2)
        //        {
        //            num2Color.GetComponent<Image>().color = Color.white;
        //        }
        //        //switch (CheckNumber(curNum2, realnum1) || CheckNumber(curNum2, realnum3) || CheckNumber(curNum2, realnum4) || CheckNumber(curNum2, realnum5) || CheckNumber(curNum2, realnum6))
        //        //{
        //        //    case true:
        //        //        Debug.Log("yellow for 2");
        //        //        num2Color.GetComponent<Image>().color = Color.yellow;
        //        //        break;
        //        //    case false:
        //        //        num2Color.GetComponent<Image>().color = Color.white;
        //        //        break;
        //        //}
        //        if (CheckNumber(curNum3, realnum1) && !yellow1 && !isNum3)
        //        {
        //            if (!isNum1){ yellow1 = true; num3Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum2, realnum3) && !yellow2 && !isNum3)
        //        {
        //            if (!isNum2){ yellow2 = true; num3Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum3, realnum4) && !yellow4 && !isNum3)
        //        {
        //            if (!isNum4){ yellow4 = true; num3Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum3, realnum5) && !yellow5 && !isNum3)
        //        {
        //            if (!isNum5){ yellow5 = true; num3Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum3, realnum6) && !yellow6 && !isNum3)
        //        {
        //            if (!isNum6){ yellow6 = true; num3Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (!isNum3)
        //        {
        //            num3Color.GetComponent<Image>().color = Color.white;
        //        }
        //        //switch (CheckNumber(curNum3, realnum2) || CheckNumber(curNum3, realnum1) || CheckNumber(curNum3, realnum4) || CheckNumber(curNum3, realnum5) || CheckNumber(curNum3, realnum6))
        //        //{
        //        //    case true:
        //        //        Debug.Log("yellow for 3");
        //        //        num3Color.GetComponent<Image>().color = Color.yellow;
        //        //        break;
        //        //    case false:
        //        //        num3Color.GetComponent<Image>().color = Color.white;
        //        //        break;
        //        //}
        //        if (CheckNumber(curNum4, realnum1) && !yellow1 && !isNum4)
        //        {
        //            if (!isNum1){ yellow1 = true; num4Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum4, realnum2) && !yellow2 && !isNum4)
        //        {
        //            if (!isNum2){ yellow2 = true; num4Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum3, realnum4) && !yellow3 && !isNum4)
        //        {
        //            if (!isNum3){ yellow3 = true; num4Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum4, realnum5) && !yellow5 && !isNum4)
        //        {
        //            if (!isNum5){ yellow5 = true; num4Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum4, realnum6) && !yellow6 && !isNum4)
        //        {
        //            if (!isNum6){ yellow6 = true; num4Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (!isNum4)
        //        {
        //            num4Color.GetComponent<Image>().color = Color.white;
        //        }
        //        //switch (CheckNumber(curNum4, realnum2) || CheckNumber(curNum4, realnum3) || CheckNumber(curNum4, realnum1) || CheckNumber(curNum4, realnum5) || CheckNumber(curNum4, realnum6))
        //        //{
        //        //    case true:
        //        //        Debug.Log("yellow for 4");
        //        //        num4Color.GetComponent<Image>().color = Color.yellow;
        //        //        break;
        //        //    case false:
        //        //        num4Color.GetComponent<Image>().color = Color.white;
        //        //        break;
        //        //}
        //        if (CheckNumber(curNum5, realnum2) && !yellow2 && !isNum5)
        //        {
        //            if (!isNum2){ yellow2 = true; num5Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum5, realnum3) && !yellow3 && !isNum5)
        //        {
        //            if (!isNum3){ yellow3 = true; num5Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum5, realnum4) && !yellow4 && !isNum5)
        //        {
        //            if (!isNum4){ yellow4 = true; num5Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum1, realnum5) && !yellow1 && !isNum5)
        //        {
        //            if (!isNum1){ yellow1 = true; num5Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum5, realnum6) && !yellow6 && !isNum5)
        //        {
        //            if (!isNum6){ yellow6 = true; num5Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (!isNum5)
        //        {
        //            num5Color.GetComponent<Image>().color = Color.white;
        //        }
        //        //switch (CheckNumber(curNum5, realnum2) || CheckNumber(curNum5, realnum3) || CheckNumber(curNum5, realnum1) || CheckNumber(curNum4, realnum5) || CheckNumber(curNum5, realnum6))
        //        //{
        //        //    case true:
        //        //        Debug.Log("yellow for 5");
        //        //        num5Color.GetComponent<Image>().color = Color.yellow;
        //        //        break;
        //        //    case false:
        //        //        num5Color.GetComponent<Image>().color = Color.white;
        //        //        break;
        //        //}
        //        if (CheckNumber(curNum6, realnum2) && !yellow2 && !isNum6)
        //        {
        //            if (!isNum2){ yellow2 = true; num6Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum6, realnum3) && !yellow3 &&!isNum6)
        //        {
        //            if (!isNum3){ yellow3 = true; num6Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum6, realnum4) && !yellow4 &&!isNum6)
        //        {
        //            if (!isNum4){ yellow4 = true; num6Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum6, realnum5) && !yellow5 &&!isNum6)
        //        {
        //            if (!isNum5){ yellow5 = true; num6Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (CheckNumber(curNum1, realnum6) && !yellow1 &&!isNum6)
        //        {
        //            if (!isNum1){ yellow1 = true; num6Color.GetComponent<Image>().color = Color.yellow; }
        //        }
        //        else if (!isNum6)
        //        {
        //            num6Color.GetComponent<Image>().color = Color.white;
        //        }
        //        //switch (CheckNumber(curNum6, realnum2) || CheckNumber(curNum6, realnum3) || CheckNumber(curNum6, realnum1) || CheckNumber(curNum6, realnum5) || CheckNumber(curNum4, realnum6))
        //        //{
        //        //    case true:
        //        //        Debug.Log("yellow for 6");
        //        //        num6Color.GetComponent<Image>().color = Color.yellow;
        //        //        break;
        //        //    case false:
        //        //        num6Color.GetComponent<Image>().color = Color.white;
        //        //        break;
        //        //}

                //switch (CheckAllNumbers())
                //{
                //    case true:

                //        switch (WhatIReference)
                //        {
                //            case "Z":
                //                PlayerPrefs.SetString("letter1", "Z");
                //                break;
                //            case "O":
                //                PlayerPrefs.SetString("letter2", "O");
                //                break;
                //            case "R":
                //                PlayerPrefs.SetString("letter3", "R");
                //                break;
                //            case "L":
                //                PlayerPrefs.SetString("letter4", "L");
                //                break;
                //            case "A":
                //                PlayerPrefs.SetString("letter5", "A");
                //                break;
                //            case "M":
                //                PlayerPrefs.SetString("letter6", "M");
                //                break;
                //            case "A2":
                //                PlayerPrefs.SetString("letter7", "A");
                //                break;
                //            case "K":
                //                PlayerPrefs.SetString("letter8", "K");
                //                break;

                //        }
                //        SceneManager.LoadScene("Sections");
                //        break;


                //}
                //break;
        //}
        
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
    public void setYellowTrueColorWhite()
    {
        fornum1 = 0;
        fornum2 = 0;
        fornum3 = 0;
        fornum4 = 0;
        fornum5 = 0;
        fornum6 = 0;
        num1Color.GetComponent<Image>().color = Color.white;
        num2Color.GetComponent<Image>().color = Color.white;
        num3Color.GetComponent<Image>().color = Color.white;
        num4Color.GetComponent<Image>().color = Color.white;
        num5Color.GetComponent<Image>().color = Color.white;
        num6Color.GetComponent<Image>().color = Color.white;

    }
    public void CheckNumberIfTrue()
    {
        
        if (realnum1 == curNum1)
        {
            isNum1 = true;
            num1Color.GetComponent<Image>().color = Color.green;
        }
        else if (realnum1 == curNum2 || realnum1 == curNum3 || realnum1 == curNum4 || realnum1 == curNum5 || realnum1 == curNum6)
        {
            
            if (fornum1 == 0)
            {
                fornum1++;
                num1Color.GetComponent <Image>().color = Color.yellow;
            }
        }
        else
        {
            num1Color.GetComponent<Image>().color = Color.white;
        }
        if (realnum2 == curNum2)
        {
            isNum2 = true;
            num2Color.GetComponent<Image>().color = Color.green;
        }
        else if (realnum2 == curNum1 || realnum2 == curNum3 || realnum2 == curNum4 || realnum2 == curNum5 || realnum2 == curNum6)
        {

            if (fornum2 == 0)
            {
                fornum2++;
                num2Color.GetComponent<Image>().color = Color.yellow;
            }
        }
        else
        {
            num2Color.GetComponent<Image>().color = Color.white;
        }
        if (realnum3 == curNum3)
        {
            isNum3 = true;
            num3Color.GetComponent<Image>().color = Color.green;
        }
        else if (realnum3 == curNum1 || realnum3 == curNum2 || realnum3 == curNum4 || realnum3 == curNum5 || realnum3 == curNum6)
        {

            if (fornum3 == 0)
            {
                fornum3++;
                num3Color.GetComponent<Image>().color = Color.yellow;
            }
        }
        else
        {
            num3Color.GetComponent<Image>().color = Color.white;
        }
        if (realnum4 == curNum4)
        {
            isNum4 = true;
            num4Color.GetComponent<Image>().color = Color.green;
        }
        else if (realnum4 == curNum1 || realnum4 == curNum2 || realnum4 == curNum3 || realnum4 == curNum5 || realnum4 == curNum6)
        {

            if (fornum4 == 0)
            {
                fornum4++;
                num4Color.GetComponent<Image>().color = Color.yellow;
            }
        }
        else
        {
            num4Color.GetComponent<Image>().color = Color.white;
        }
        if (realnum5 == curNum5)
        {
            isNum5 = true;
            num5Color.GetComponent<Image>().color = Color.green;
        }
        else if (realnum5 == curNum1 || realnum5 == curNum2 || realnum5 == curNum3 || realnum5 == curNum4 || realnum5 == curNum6)
        {

            if (fornum5 == 0)
            {
                fornum5++;
                num5Color.GetComponent<Image>().color = Color.yellow;
            }
        }
        else
        {
            num5Color.GetComponent<Image>().color = Color.white;
        }
        if (realnum6 == curNum6)
        {
            isNum6 = true;
            num6Color.GetComponent<Image>().color = Color.green;
        }
        else if (realnum6 == curNum1 || realnum6 == curNum2 || realnum6 == curNum3 || realnum6 == curNum5 || realnum6 == curNum4)
        {

            if (fornum6 == 0)
            {
                fornum6++;
                num6Color.GetComponent<Image>().color = Color.yellow;
            }
        }
        else
        {
            num4Color.GetComponent<Image>().color = Color.white;
        }
    } 
}
