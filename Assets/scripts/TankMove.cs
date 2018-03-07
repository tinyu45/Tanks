using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour {

	public float mSpeed=5;          //前进速度
	public float mRotateSpeed=18;   //旋转速度18°
	public int number=1;            //坦克编号  区分敌方和我方


	Rigidbody mRi;

	void Awake()
	{
		mRi = GetComponent < Rigidbody> ();
	}


	void FixedUpdate()
	{
		float v = Input.GetAxis ("VerticalTank"+number);           //移动方向 w s
		mRi.velocity = transform.forward * v * mSpeed;  //添加速度   前进
 	
		float h=Input.GetAxis("HorizontalTank"+number);
		mRi.angularVelocity=transform.up*h*mRotateSpeed;  //旋转
	}
}
