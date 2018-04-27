using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeroList : MonoBehaviour {

    public LoginUIManager loginUIManager;
    public Image heroImage;
    public Sprite hero1;
    public Sprite hero2;
    public Sprite hero3;
    public Sprite hero4;
    public Sprite hero5;

    /// <summary>
    /// 变更职业
    /// </summary>
    public void JobExchange(JobType type)
    {
        Debug.Log("JobType:" + type);
        switch (type)
        {
            case JobType.Arist:
                heroImage.sprite = hero3;
                break;
            case JobType.Painter:
                heroImage.sprite = hero2;
                break;
            case JobType.Expert:
                heroImage.sprite = hero4;
                break;
            case JobType.Word:
                heroImage.sprite = hero1;
                break;
            case JobType.Technicist:
                heroImage.sprite = hero5;
                break;
            case JobType.Craftsman:
                heroImage.sprite = hero2;
                break;
            case JobType.Businessman:
                heroImage.sprite = hero3;
                break;
            case JobType.Superman:
                heroImage.sprite = hero1;
                break;
            default:
                Debug.Log("没有这个职业类型");
                break;
        }
    }

    public void JobRandomExchange()
    {
        int random = Random.Range(0, 5);
        switch (random)
        {
            case 0:
                heroImage.sprite = hero1;
                break;
            case 1:
                heroImage.sprite = hero2;
                break;
            case 2:
                heroImage.sprite = hero3;
                break;
            case 3:
                heroImage.sprite = hero4;
                break;
            case 4:
                heroImage.sprite = hero5;
                break;
            default:
                break;
        }
    }
    
}
