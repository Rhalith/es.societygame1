using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterChanger : MonoBehaviour
{
    public GameObject letter1, letter2, letter3, letter4, letter5, letter6, letter7, letter8;
    private static bool isFirst = true;
    //private void Awake()
    //{
    //    DontDestroyOnLoad(this);
    //}
    private void Start()
    {
        switch (isFirst)
        {
            case true:
                isFirst = false;
                PlayerPrefs.DeleteAll();
                break;
            case false:
                break;
        }
        switch (PlayerPrefs.GetString("letter1"))
        {
            case "Z":
                letter1.GetComponent<Text>().text = "Z";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter2"))
        {
            case "O":
                letter2.GetComponent<Text>().text = "O";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter3"))
        {
            case "R":
                letter3.GetComponent<Text>().text = "O";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter4"))
        {
            case "L":
                letter4.GetComponent<Text>().text = "O";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter5"))
        {
            case "A":
                letter5.GetComponent<Text>().text = "O";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter6"))
        {
            case "M":
                letter6.GetComponent<Text>().text = "O";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter7"))
        {
            case "A":
                letter7.GetComponent<Text>().text = "O";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter8"))
        {
            case "K":
                letter8.GetComponent<Text>().text = "O";
                break;
            case null:
                break;
        }
    }
}
