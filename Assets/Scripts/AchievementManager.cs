using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    
    public static AchievementManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void CheckAchievements()
    {
        	    if(GameManager.instance.score > 0 || PlayerPrefs.GetInt("HighScore") > 0)
                {
                    Debug.Log("Collected 1 of 25");
                    NGHelper.instance.unlockMedal(84696);
                }
                if (GameManager.instance.score > 1 || PlayerPrefs.GetInt("HighScore") > 1)
                {
                    Debug.Log("Collected 2 of 25");
                    NGHelper.instance.unlockMedal(84697);
                }
                if (GameManager.instance.score > 2 || PlayerPrefs.GetInt("HighScore") > 2)
                {
                    Debug.Log("Collected 3 of 25");
                    NGHelper.instance.unlockMedal(84698);
                }
                if (GameManager.instance.score > 3 || PlayerPrefs.GetInt("HighScore") > 3)
                {
                    Debug.Log("Collected 4 of 25");
                    NGHelper.instance.unlockMedal(84699);
                }
                if (GameManager.instance.score > 4 || PlayerPrefs.GetInt("HighScore") > 4)
                {
                    Debug.Log("Collected 5 of 25");
                    NGHelper.instance.unlockMedal(84700);
                }
                if (GameManager.instance.score > 5 || PlayerPrefs.GetInt("HighScore") > 5)
                {
                    Debug.Log("Collected 6 of 25");
                    NGHelper.instance.unlockMedal(84701);
                }
                if (GameManager.instance.score > 6 || PlayerPrefs.GetInt("HighScore") > 6)
                {
                    Debug.Log("Collected 7 of 25");
                    NGHelper.instance.unlockMedal(84702);
                }
                if (GameManager.instance.score > 7 || PlayerPrefs.GetInt("HighScore") > 7)
                {
                    Debug.Log("Collected 8 of 25");
                    NGHelper.instance.unlockMedal(84703);
                }
                if (GameManager.instance.score > 8 || PlayerPrefs.GetInt("HighScore") > 8)
                {
                    Debug.Log("Collected 9 of 25");
                    NGHelper.instance.unlockMedal(84704);
                }
                if (GameManager.instance.score > 9 || PlayerPrefs.GetInt("HighScore") > 9)
                {
                    Debug.Log("Collected 10 of 25");
                    NGHelper.instance.unlockMedal(84705);
                }
                if (GameManager.instance.score > 10 || PlayerPrefs.GetInt("HighScore") > 10)
                {
                    Debug.Log("Collected 11 of 25");
                    NGHelper.instance.unlockMedal(84706);
                }
                if (GameManager.instance.score > 11 || PlayerPrefs.GetInt("HighScore") > 11)
                {
                    Debug.Log("Collected 12 of 25");
                    NGHelper.instance.unlockMedal(84707);
                }
                if (GameManager.instance.score > 12 || PlayerPrefs.GetInt("HighScore") > 12)
                {
                    Debug.Log("Collected 13 of 25");
                    NGHelper.instance.unlockMedal(84708);
                }
                if (GameManager.instance.score > 13 || PlayerPrefs.GetInt("HighScore") > 13)
                {
                    Debug.Log("Collected 14 of 25");
                    NGHelper.instance.unlockMedal(84709);
                }
                if (GameManager.instance.score > 14 || PlayerPrefs.GetInt("HighScore") > 14)
                {
                    Debug.Log("Collected 15 of 25");
                    NGHelper.instance.unlockMedal(84710);
                }
                if (GameManager.instance.score > 15 || PlayerPrefs.GetInt("HighScore") > 15)
                {
                    Debug.Log("Collected 16 of 25");
                    NGHelper.instance.unlockMedal(84711);
                }
                if (GameManager.instance.score > 16 || PlayerPrefs.GetInt("HighScore") > 16)
                {
                    Debug.Log("Collected 17 of 25");
                    NGHelper.instance.unlockMedal(84712);
                }
                if (GameManager.instance.score > 17 || PlayerPrefs.GetInt("HighScore") > 17)
                {
                    Debug.Log("Collected 18 of 25");
                    NGHelper.instance.unlockMedal(84713);
                }
                if (GameManager.instance.score > 18 || PlayerPrefs.GetInt("HighScore") > 18)
                {
                    Debug.Log("Collected 19 of 25");
                    NGHelper.instance.unlockMedal(84714);
                }
                if (GameManager.instance.score > 19 || PlayerPrefs.GetInt("HighScore") > 19)
                {
                    Debug.Log("Collected 20 of 25");
                    NGHelper.instance.unlockMedal(84715);
                }
                if (GameManager.instance.score > 20 || PlayerPrefs.GetInt("HighScore") > 20)
                {
                    Debug.Log("Collected 21 of 25");
                    NGHelper.instance.unlockMedal(84716);
                }
                if (GameManager.instance.score > 21 || PlayerPrefs.GetInt("HighScore") > 21)
                {
                    Debug.Log("Collected 22 of 25");
                    NGHelper.instance.unlockMedal(84717);
                }
                if (GameManager.instance.score > 22 || PlayerPrefs.GetInt("HighScore") > 22)
                {
                    Debug.Log("Collected 23 of 25");
                    NGHelper.instance.unlockMedal(84718);
                }
                if (GameManager.instance.score > 23 || PlayerPrefs.GetInt("HighScore") > 23)
                {
                    Debug.Log("Collected 24 of 25");
                    NGHelper.instance.unlockMedal(84719);
                }
                if (GameManager.instance.score > 24 || PlayerPrefs.GetInt("HighScore") > 24)
                {
                    Debug.Log("Collected 25 of 25");
                    NGHelper.instance.unlockMedal(84720);
                    NGHelper.instance.unlockMedal(84721);
                }
    }
}
