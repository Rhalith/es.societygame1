using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterChanger : MonoBehaviour
{
    public GameObject Z, O, R, L, A, M, A2;
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
                Z.GetComponent<Text>().text = "Z";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter2"))
        {
            case "O":
                O.GetComponent<Text>().text = "O";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter3"))
        {
            case "R":
                R.GetComponent<Text>().text = "R";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter4"))
        {
            case "L":
                L.GetComponent<Text>().text = "L";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter5"))
        {
            case "A":
                A.GetComponent<Text>().text = "A";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter6"))
        {
            case "M":
                M.GetComponent<Text>().text = "M";
                break;
            case null:
                break;
        }
        switch (PlayerPrefs.GetString("letter7"))
        {
            case "A":
                A2.GetComponent<Text>().text = "A";
                break;
            case null:
                break;
        }
    }
}
