/***
 * 
 *    Title: "SUIFW" UI框架项目
 *           主题： 登陆窗体   
 *    Description: 
 *           功能： 
 *                  
 *    Date: 2017
 *    Version: 0.1版本
 *    Modify Recoder: 
 *    
 *   
 */
using System;
using System.Collections;
using System.Collections.Generic;
using SUIFW;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace DemoProject
{
    public class LogonUIForm : BaseUIForm
    {
        public Text TxtLogonName;                           //登陆名称
        public Text TxtLogonNameByBtn;                      //登陆名称(Button)
        public Text TxtLogonPW;                                  //登陆密码

        public void Awake()
        {
            //定义本窗体的性质(默认数值，可以不写)
            base.CurrentUIType.UIForms_Type = UIFormType.Normal;
            base.CurrentUIType.UIForms_ShowMode = UIFormShowMode.HideOther;
            base.CurrentUIType.UIForm_LucencyType = UIFormLucenyType.Lucency;
            /* 给按钮注册事件 */
            //RigisterButtonObjectEvent("Btn_OK", LogonSys);
            //Lamda表达式写法
            RigisterButtonObjectEvent("Btn_OK",
                p =>
                {
                    SceneManager.LoadScene("SelectHeroScene1");
                    //OpenUIForm(ProConst.SELECT_HERO_FORM);
                    //OpenUIForm(ProConst.HERO_BUSINESSMAN_UIFORM);
                }

                );
        }

        public void Start()
        {
            //string strDisplayInfo = LauguageMgr.GetInstance().ShowText("LogonSystem");

            if (TxtLogonName)
            {
                TxtLogonName.text = Show("LogonName");
            }
            if (TxtLogonNameByBtn)
            {
                TxtLogonNameByBtn.text = Show("Logon");
            }
            if (TxtLogonPW)
            {
                TxtLogonPW.text = Show("LogonPW");
            }
        }

    }
}