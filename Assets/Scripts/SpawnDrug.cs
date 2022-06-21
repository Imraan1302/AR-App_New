using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDrug : MonoBehaviour
{
    private Touch SpawnDrugTouch;
    public GameObject DrugUI;
    public bool DrugActive;


    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && !DrugActive)
        {
            SpawnDrugTouch = Input.GetTouch(0);
            DrugUI.SetActive(true);
            DrugActive = true;
        }
        if(Input.touchCount > 0 && DrugActive)
        {
            SpawnDrugTouch = Input.GetTouch(0);
            DrugUI.SetActive(false);
            DrugActive = false;
        }
    }
}
