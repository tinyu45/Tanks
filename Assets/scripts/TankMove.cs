using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour {

	public float mSpeed=5;          //前进速度
	public float mRotateSpeed=18;   //旋转速度18°
	public int number=1;            //坦克编号  区分敌方和我方

	public AudioClip idelClip;   //静止音效
	public AudioClip drivClip;   //移动音效
	AudioSource tankAudio;

	Rigidbody mRi;

	void Awake()
	{
		mRi = GetComponent < Rigidbody> ();
		tankAudio = GetComponent<AudioSource> ();
	}


	void FixedUpdate()
	{
		float v = Input.GetAxis ("VerticalTank"+number);           //移动方向 w s
		mRi.velocity = transform.forward * v * mSpeed;  //添加速度   前进
 	
		float h=Input.GetAxis("HorizontalTank"+number);
		mRi.angularVelocity=transform.up*h*mRotateSpeed;  //旋转

		//abs绝对值
		if (Mathf.Abs (v) > 0.1f || Mathf.Abs (h) > 0.1f) {
			//移动中
			tankAudio.clip = drivClip;
			if(!tankAudio.isPlaying){
				tankAudio.Play ();
			}
		} else {
			tankAudio.clip = idelClip;
			if(!tankAudio.isPlaying){
				tankAudio.Play ();
			}
		}
	}
}
