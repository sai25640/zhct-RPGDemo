using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class HeroSclectUIManager : MonoBehaviour {

    public GameObject ImgDescriptionHero1;
    public GameObject ImgDescriptionHero2;
    public Button hero1;
    public Button hero2;
    public void OnHero1ButtonClick()
    {
        ImgDescriptionHero1.SetActive(true);
        ImgDescriptionHero2.SetActive(false);
        //ColorBlock cb = new ColorBlock();
        //cb.normalColor = new Color(255, 100, 100, 255);
        //cb.highlightedColor = new Color(245, 245, 245, 255);
        //cb.pressedColor = new Color(200, 200, 200, 255);
        //cb.disabledColor = new Color(200, 200, 200, 128);
        //cb.colorMultiplier = 1;
        //hero1.colors = cb;
        //ChangeButtonNomalColor(hero1, new Color(255, 100, 100, 255));
        //hero2.color = new Color(255, 255, 255, 255);

    }

    public void  OnHero2ButtonClick()
    {
        ImgDescriptionHero1.SetActive(false);
        ImgDescriptionHero2.SetActive(true);
       // hero1.color = new Color(255, 255, 255, 255);
       // hero2.color = new Color(255, 100, 100, 255);
    }

	public void OnEnterGameButtonClick()
    {
        SceneManager.LoadScene("MainCityScene");
    }

    private void ChangeButtonNomalColor(Button button,Color color)
    {
        ColorBlock cb = new ColorBlock();
        cb.normalColor = color;
        cb.highlightedColor = new Color(245,245,245,255);
        cb.pressedColor = new Color(200, 200, 200, 255);
        cb.disabledColor = new Color(200, 200, 200, 128);
        cb.colorMultiplier = 1;
        button.colors = cb;
    }
}
