using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalieDialogue : MonoBehaviour {


    public GameObject BalieDialogueUI;
    public GameObject HelloText;
    public GameObject GetCoffeeText;
    public GameObject GetCoffeeButton;
    public GameObject NoButton;
    public GameObject ThankYouButton;

    //Trigger
    private void OnTriggerEnter(Collider other)
    {

        BalieDialogueUI.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {

        BalieDialogueUI.SetActive(false);
    }

    //Button Options
    public void GetCoffeeInfo()
    {

        //false
        HelloText.SetActive(false);
        GetCoffeeButton.SetActive(false);
        NoButton.SetActive(false);

        //true
        GetCoffeeText.SetActive(true);
        ThankYouButton.SetActive(true);
    }

    public void no()
    {  
        BalieDialogueUI.SetActive(false);
    }
}
