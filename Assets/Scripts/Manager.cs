using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Fool;
    public GameObject FoolInverted;
    public GameObject Magic;
    public GameObject MagicInverted;
    public GameObject HP;
    public GameObject HPInverted; 
    public GameObject Empress;
    public GameObject EmpressInverted;
    public GameObject Emperor;
    public GameObject EmperorInverted;
    int CardValue;
    public GameObject ThreeDeeUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CardRNG()
    {
        CardValue = Random.Range(0,10); 

        if(CardValue == 1)
        {
            ThreeDeeUI.SetActive(false);
            Fool.SetActive(true);
        }
        if (CardValue == 2)
        {
            ThreeDeeUI.SetActive(false);
            FoolInverted.SetActive(true);
        }
        if (CardValue == 3)
        {
            ThreeDeeUI.SetActive(false);
            Magic.SetActive(true);
        }
        if (CardValue == 4)
        {
            ThreeDeeUI.SetActive(false);
            MagicInverted.SetActive(true);
        }
        if (CardValue == 5)
        {
            ThreeDeeUI.SetActive(false);
            HP.SetActive(true);
        }
        if (CardValue == 6)
        {
            ThreeDeeUI.SetActive(false);
            HPInverted.SetActive(true);
        }
        if (CardValue == 7)
        {
            ThreeDeeUI.SetActive(false);
            Empress.SetActive(true);
        }
        if (CardValue == 8)
        {
            ThreeDeeUI.SetActive(false);
            EmpressInverted.SetActive(true);
        }
        if (CardValue == 9)
        {
            ThreeDeeUI.SetActive(false);
            Emperor.SetActive(true);
        }
        if (CardValue == 10)
        {
            ThreeDeeUI.SetActive(false);
            EmperorInverted.SetActive(true);
        }
    }

}
