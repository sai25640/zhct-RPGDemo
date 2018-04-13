using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MainCityUIManager : MonoBehaviour {

    public GameObject taskPanel;        //任务界面
    public GameObject marketPanel;   //商城界面
    public GameObject gridGroup1;    //商城道具栏
    public GameObject gridGroup2;    //商城装扮栏

    public void OnTaskButtonClick()
    {
        //taskPanel.SetActive(true);
        //marketPanel.SetActive(false);
        taskPanel.transform.DOScale(Vector3.one,.5f);
        marketPanel.transform.DOScale(Vector3.zero, .5f);
        
    }

    public void OnTaskPanelCloseButtonClick()
    {
        //taskPanel.SetActive(false);
        taskPanel.transform.DOScale(Vector3.zero, .5f);
        
    }

    public void OnTab1ButtonClick()
    {
        gridGroup1.SetActive(true);
        gridGroup2.SetActive(false);
    }

    public void OnTab2ButtonClick()
    {
        gridGroup1.SetActive(false);
        gridGroup2.SetActive(true);
    }

    public void OnMarketButtonClick()
    {
        //marketPanel.SetActive(true);
        //taskPanel.SetActive(false);
        marketPanel.transform.DOScale(Vector3.one, .5f);
        taskPanel.transform.DOScale(Vector3.zero, .5f);
       
    }

    public void OnMarketPanelCloseButtonClick()
    {
        //marketPanel.SetActive(false);
        marketPanel.transform.DOScale(Vector3.zero, .5f);
   
    }
}
