using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckWord : MonoBehaviour
{
    public InputField InputField;
    public string word;
    public GameObject canvasholder;
    cameraShaker cameraShaker;
    public void checkWord()
    {
        if (InputField.text == word)
        {
            Debug.Log("YES P1");
        }
        else
        {
            cameraShaker = canvasholder.GetComponent<cameraShaker>();
            Debug.Log("HAHA NOOB");
            cameraShaker.StartShaking();
        }
    }
    
}
