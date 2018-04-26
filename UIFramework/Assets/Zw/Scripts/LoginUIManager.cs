using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
public class LoginUIManager : MonoBehaviour {

    public GameObject logoPanel;
    public GameObject loginPanel;
    public GameObject loadingPanel;
    public GameObject selectHeroPanel;
    public GameObject selectWorldPanel;
    public Slider slider;
    public Text sliderText;
    private IEnumerator Start()
    {
        Image image = logoPanel.GetComponent<Image>();
        Tweener tweener = image.DOColor(Color.white, 2f);
        yield return tweener.WaitForCompletion();
        //Debug.Log("DOColor(Color.white, 2f);");
        tweener = image.DOColor(Color.black, 1f);
        yield return tweener.WaitForCompletion();

        logoPanel.SetActive(false);
        loginPanel.SetActive(true);

    }
    /// <summary>
    //////////////////////////////////////////////////登陆界面/////////////////////////////////////////////////////
    /// </summary>
    public void OnLoginButtonClick()
    {
        //SceneManager.LoadScene("HeroSelectScene");
        loginPanel.SetActive(false);
        //loadingPanel.SetActive(true);
        selectHeroPanel.SetActive(true);

        //Tweener tweener = DOTween.To(() => slider.value, x => slider.value = x, 1f, 2f);
        //tweener.OnComplete(() => Debug.Log("100%"));
    }


    /// <summary>
    /////////////////////////////////////////// 选择英雄界面/////////////////////////////////////////////////////
    /// </summary>

    private int heroIndex = 0;
    public int HeroIndex
    {
        get
        {
            return heroIndex;
        }

        set
        {
            heroIndex = value;
        }
    }
    private int heroCount = 5;
    public Transform heroList;
    public void OnReturnButtonClick()
    {
        selectHeroPanel.SetActive(false);
        loginPanel.SetActive(true);
    }

   
    public void OnRandomButtonClick()
    {
        Debug.Log("RandomNumber:" + HeroIndex);
        HeroIndex++;
        if (HeroIndex >= heroCount)
        {
            HeroIndex = 0;
        }
    }

    public void OnSelectWorldButtonClick()
    {
        selectHeroPanel.SetActive(false);
        selectWorldPanel.SetActive(true);
    }

    /// <summary>
    ///////////////////////////////////////// 选择世界界面//////////////////////////////////////////////////////
    /// </summary>
    private int worldIndex = 0;
    //private int worldCount
    public Scrollbar worldSelectScrollbar;
    public GameObject leftButton;
    public GameObject rightButton;

    

    public void OnLeftButtonClick()
    {
        worldSelectScrollbar.value = 0;
        rightButton.SetActive(true);
    }
    public void OnRightButtonClick()
    {
        worldSelectScrollbar.value = 1;
        leftButton.SetActive(true);
    }

    private void Update()
    {
        //sliderText.text = (int)(slider.value*100) + "%";
        if (worldSelectScrollbar.value <= 0.1f)
        {
            leftButton.SetActive(false);
            rightButton.SetActive(true);
        }
        else if (worldSelectScrollbar.value >= 0.9f)
        {
            rightButton.SetActive(false);
            leftButton.SetActive(true);
        }
    }
}