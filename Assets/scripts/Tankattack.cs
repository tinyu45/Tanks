using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankattack : MonoBehaviour {

	public Transform shellPoint;                           //炮弹发射点
	public GameObject shellPrefab;
    public KeyCode key = KeyCode.Space;                     //发射子弹的按键
	public float shellSpeed=18;
	public AudioClip shotFiringAudio;  //发射子弹音效


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (key)) 
		{
			//发射炮弹；
			AudioSource.PlayClipAtPoint(shotFiringAudio, transform.position);
			GameObject shell=Instantiate(shellPrefab, shellPoint.position, shellPoint.rotation);
			shell.GetComponent<Rigidbody> ().velocity = transform.forward * shellSpeed;                     //给炮弹添加向前的速度
		}
	}
}
