using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; using UnityEngine.SceneManagement;
public class CheckWord : MonoBehaviour
{
    public TMPro.TMP_InputField InputField;
    public string word;
    public GameObject canvasholder;
    cameraShaker cameraShaker;
    public void checkWord()
    {
        if (InputField.text == word)
        {
            SceneManager.LoadScene("finishscreen");
        }
        else
        {
            cameraShaker = canvasholder.GetComponent<cameraShaker>();
            Debug.Log("HAHA NOOB");
            cameraShaker.StartShaking();
        }
    }
    
}
