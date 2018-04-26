using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroList : MonoBehaviour {

    public LoginUIManager loginUIManager;
    public GameObject hero1;
    public GameObject hero2;
    public GameObject hero3;
    public GameObject hero4;
    public GameObject hero5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (loginUIManager.HeroIndex ==0)
        {
            hero1.SetActive(true);
            hero2.SetActive(false);
            hero3.SetActive(false);
            hero4.SetActive(false);
            hero5.SetActive(false);
        }
        else if (loginUIManager.HeroIndex == 1)
        {
            hero1.SetActive(false);
            hero2.SetActive(true);
            hero3.SetActive(false);
            hero4.SetActive(false);
            hero5.SetActive(false);
        }
        else if (loginUIManager.HeroIndex == 2)
        {
            hero1.SetActive(false);
            hero2.SetActive(false);
            hero3.SetActive(true);
            hero4.SetActive(false);
            hero5.SetActive(false);
        }
        else if (loginUIManager.HeroIndex == 3)
        {
            hero1.SetActive(false);
            hero2.SetActive(false);
            hero3.SetActive(false);
            hero4.SetActive(true);
            hero5.SetActive(false);
        }
        else if (loginUIManager.HeroIndex == 4)
        {
            hero1.SetActive(false);
            hero2.SetActive(false);
            hero3.SetActive(false);
            hero4.SetActive(false);
            hero5.SetActive(true);
        }
    }
}
