using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JobType
{
    Arist,
    Painter,
    Expert,
    Word,
    Technicist,
    Craftsman,
    Businessman,
    Superman
}
public class JobSelectToggleGroup : MonoBehaviour {
	
    //private JobType mJobType;
    public HeroList heroList;
    public void OnAristToggleValueChanged()
    {
       // Debug.Log("Arist");
        heroList.JobExchange(JobType.Arist);
    }

    public void OnPainterToggleValueChanged()
    {
       // Debug.Log("Painter");
        heroList.JobExchange(JobType.Painter);
    }

    public void OnExpertToggleValueChanged()
    {
       // Debug.Log("Expert");
        heroList.JobExchange(JobType.Expert);
    }

    public void OnWordToggleValueChanged()
    {
        //Debug.Log("Word");
        heroList.JobExchange(JobType.Word);
    }

    public void OnTechnicistToggleValueChanged()
    {
        //Debug.Log("Technicist");
        heroList.JobExchange(JobType.Technicist);
    }

    public void OnCraftsmanToggleValueChanged()
    {
       // Debug.Log("Craftsman");
        heroList.JobExchange(JobType.Craftsman);
    }

    public void OnBusinessmanToggleValueChanged()
    {
        //Debug.Log("Businessman");
        heroList.JobExchange(JobType.Businessman);
    }

    public void OnSupermanToggleValueChanged()
    {
        //Debug.Log("Superman");
        heroList.JobExchange(JobType.Superman);
    }

}
