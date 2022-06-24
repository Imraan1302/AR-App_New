using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCard : MonoBehaviour
{
    public GameObject InitialChoicesObject;
    public GameObject SelfCardObject;
    public GameObject SituationCardObject;
    public GameObject ChallengeCardObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelfCard()
    {
        SelfCardObject.SetActive(true);
        InitialChoicesObject.SetActive(false);
    }

    public void SituationCard()
    {
        SituationCardObject.SetActive(true);
        InitialChoicesObject.SetActive(false);
    }

    public void ChallengeCard()
    {
        ChallengeCardObject.SetActive(true);
        InitialChoicesObject.SetActive(false);
    }
}
