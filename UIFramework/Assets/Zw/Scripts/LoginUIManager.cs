using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginUIManager : MonoBehaviour {

    public void OnLoginButtonClick()
    {
        SceneManager.LoadScene("HeroSelectScene");
    }
      
}