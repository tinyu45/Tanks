using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStart : MonoBehaviour {

	public GameObject gameIntroPanel; //游戏说明

	//开始游戏
	public void StartGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Main");	
	}

	//打开游戏说明界面
	public void OpenGameIntro()
	{   
		if(!gameIntroPanel.activeSelf)
		gameIntroPanel.SetActive (true);
	}


	//关闭游戏说明界面
	public void CloseGameIntro()
	{
		if(gameIntroPanel.activeSelf)
		gameIntroPanel.SetActive (false);
	}


	//退出游戏‘
	public void QuitGame()
	{

		Application.Quit ();   //退出
	}



	void Awake()
	{
		gameIntroPanel.SetActive (false);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
