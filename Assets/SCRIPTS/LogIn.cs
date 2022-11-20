/*using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class LogIn : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject logInCanvas;
    public GameObject decisionCanvas;
    public float networth = 4.5f;
    public string userName= "Username";
    public string passWord="Admin";
    public TMP_Text outputText;
   // bool isButtonClicked;


    private void Start()
    {
        decisionCanvas.SetActive(false);
    }


    public void CloseLoginCanvas()
    {
        logInCanvas.SetActive(false);
        decisionCanvas.SetActive(true);
    }

    public void CloseDecisionCanvas()
    {
        logInCanvas.SetActive(true);
        decisionCanvas.SetActive(false);
    }

    public void LogInButtonClick()
    {
        if (userName == "Username" && passWord == "Admin" && networth <= 4.5f)
        {
            // mainCamera.transform.Translate(2f * Time.deltaTime, 0, 0);
            Debug.Log("Log in successful");
        }
        else

        {
            outputText.text = "Sorry, come back when you are eligible";
        }
        
    }

    
}
*/