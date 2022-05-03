using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainScene : MonoBehaviour
{
    [SerializeField] int money;
    public Text moneyText;
    public int totalMoney;
    public void Buttonclick()
    {
        totalMoney++;
        PlayerPrefs.SetInt("totalMoney", totalMoney); // сохранение денег в памяти
    }

    
    public void moveToAchivements() // Переход на сцену достижений
    {
        SceneManager.LoadScene(1);
    }
    private void Start()
    {
        //PlayerPrefs.SetInt("isFitstAchive", 0); //Чтобы обнулить 1ю ачивку
        //PlayerPrefs.SetInt("totalMoney", 0);  // Это для сброса кол-ва денег
        totalMoney = PlayerPrefs.GetInt("totalMoney");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        moneyText.text = totalMoney.ToString();
        
    }
}
