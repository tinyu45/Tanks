using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameover : MonoBehaviour {

	//重新开始游戏
	public void ClickStartGame()
	{
        SceneManager.LoadScene("Main");
	}


	//点击回主界面
	public void ClickReturn()
	{
        SceneManager.LoadScene("Start");
	}


	//点击退出游戏
	public void clickQuitGame()
	{
        Application.Quit();
	}
}
