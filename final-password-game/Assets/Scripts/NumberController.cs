using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberController : MonoBehaviour
{
    public Button upButton;
    public Button downButton;
    public TextMeshPro text;
    public int currentNumber = 0;
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
}

