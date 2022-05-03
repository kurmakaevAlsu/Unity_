using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AchScene : MonoBehaviour
{
    public int totalMoney; // общее число очков
    [SerializeField] Button firstAchive;
    [SerializeField] bool isFitstAchive;

    // Start is called before the first frame update
    void Start()
    {

        

        totalMoney = PlayerPrefs.GetInt("totalMoney"); 
        isFitstAchive = PlayerPrefs.GetInt("isFitstAchive") == 1 ? true : false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (totalMoney >= 10 && !isFitstAchive)
        {
            firstAchive.interactable = true; // Если условие выполнено, то на кнопку можно нажать
        }
        else
        {
            firstAchive.interactable = false;
        }
    }

    public void GetFirstAchive()
    {
        int total_Money = PlayerPrefs.GetInt("totalMoney");
        total_Money += 10;
        PlayerPrefs.SetInt("totalMoney", total_Money);
        isFitstAchive = true;
        PlayerPrefs.SetInt("isFitstAchive", isFitstAchive ? 1 : 0);
    }
    public void moveToMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
