/***
 * 
 *    Title: "SUIFW" UI框架项目
 *           主题： “商城窗体”   
 *    Description: 
 *           功能：
 *                  
 *    Date: 2017
 *    Version: 0.1版本
 *    Modify Recoder: 
 *    
 *   
 */
using System.Collections;
using System.Collections.Generic;
using SUIFW;
using UnityEngine;
using DG.Tweening;
namespace DemoProject
{
    public class MarketUIFrom : BaseUIForm
    {
		void Awake ()
        {
		    //窗体性质
		    CurrentUIType.UIForms_Type = UIFormType.PopUp;  //弹出窗体
		    CurrentUIType.UIForm_LucencyType = UIFormLucenyType.ImPenetrable;
		    CurrentUIType.UIForms_ShowMode = UIFormShowMode.ReverseChange;

            //注册按钮事件：退出
            RigisterButtonObjectEvent("Btn_Close",
                P=> CloseUIForm()                
                );
            //注册道具事件：神杖 
            RigisterButtonObjectEventEX("BtnTicket", UIEventType.OnEnter,
                P =>
                {
                    //打开子窗体
                    OpenUIForm(ProConst.PRO_DETAIL_UIFORM);
                    //传递数据
                    string[] strArray = new string[] { "神杖详情", "神杖详细介绍。。。" };
                    SendMessage("Props", "ticket", strArray);
                    Debug.Log("OnEnter");
                }
                );
            RigisterButtonObjectEventEX("BtnTicket", UIEventType.OnExit, P => UIManager.GetInstance().CloseUIForms(ProConst.PRO_DETAIL_UIFORM));
        
            //注册道具事件：战靴 
            RigisterButtonObjectEvent("BtnShoe",
                P =>
                {
                    //打开子窗体
                    OpenUIForm(ProConst.PRO_DETAIL_UIFORM);
                    //传递数据
                    string[] strArray = new string[] { "战靴详情", "战靴详细介绍。。。" };
                    SendMessage("Props", "shoes", strArray);
                }
                );

            //注册道具事件：盔甲 
            RigisterButtonObjectEvent("BtnCloth",
                P =>
                {
                    //打开子窗体
                    OpenUIForm(ProConst.PRO_DETAIL_UIFORM);
                    //传递数据
                    string[] strArray = new string[] { "盔甲详情", "盔甲详细介绍。。。" };
                    SendMessage("Props", "cloth", strArray);
                }
                );
        }

        //自定义显示效果
        public override void Display()
        {
            base.Display();
            CanvasGroup cg = this.gameObject.GetComponent<CanvasGroup>();
            cg.alpha = 0;
            cg.DOFade(1f, .5f);
            //Debug.Log("Display");
        }

       
    }
}