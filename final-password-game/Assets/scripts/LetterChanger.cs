using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterChanger : MonoBehaviour
{
    public GameObject letter1, letter2, letter3, letter4, letter5, letter6, letter7, letter8, letter9;

    public void letterChanger(int i, string letter)
    {
        switch (i)
        {
            case 1:
                letter1.GetComponent<Text>().text = letter;
                break;
            case 2:
                letter2.GetComponent<Text>().text = letter;
                break ;
            case 3:
                letter3.GetComponent<Text>().text = letter;
                break;
            case 4:
                letter4.GetComponent<Text>().text = letter;
                break;
            case 5:
                letter5.GetComponent<Text>().text = letter;
                break;
            case 6:
                letter6.GetComponent<Text>().text = letter;
                break;
            case 7:
                letter7.GetComponent<Text>().text = letter;
                break;
            case 8:
                letter8.GetComponent<Text>().text = letter;
                break;
            case 9:
                letter9.GetComponent<Text>().text = letter;
                break;
        }
    }
}
