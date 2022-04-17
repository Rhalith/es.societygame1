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
    AudioSource audioSource;
    private void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("change").GetComponent<AudioSource>();
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
        CheckNumber();
        audioSource.Play();
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
        CheckNumber();
        audioSource.Play();
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
                checker.setNum(1, currentNumber);
                break;
            case 2:
                checker.setNum(2, currentNumber);
                break;
            case 3:
                checker.setNum(3, currentNumber);
                break;
            case 4:
                checker.setNum(4, currentNumber);
                break;
            case 5:
                checker.setNum(5, currentNumber);
                break;
            case 6:
                checker.setNum(6, currentNumber);
                break;

        }
        checker.num1Color.GetComponent<Image>().color = Color.white;
        checker.num2Color.GetComponent<Image>().color = Color.white;
        checker.num3Color.GetComponent<Image>().color = Color.white;
        checker.num4Color.GetComponent<Image>().color = Color.white;
        checker.num5Color.GetComponent<Image>().color = Color.white;
        checker.num6Color.GetComponent<Image>().color = Color.white;
    }
}

