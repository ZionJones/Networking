using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer: MonoBehaviour 
{
 
 public int timeLeft = 45;
 public Text coutdownText ;
	
	// Use this for initialization
	void Start () 
	{
	 coutdownText.text = "";
	 StartCoroutine("LoseTime");	
	}
	
	// Update is called once per frame
	void Update () 
  {
	  coutdownText.text = ("Time Left:" + timeLeft);
    if(timeLeft <= 0)
	{
		StopCoroutine("LoseTime");
		coutdownText.text = "YOU LOSE !!!! ";
	}	
  }	
	IEnumerator LoseTime()
	{
		while(true)
		{
			yield return new WaitForSeconds(1);
			timeLeft--;
		}
	}
  
}
