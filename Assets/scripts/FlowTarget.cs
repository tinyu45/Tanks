using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowTarget : MonoBehaviour {

	public Transform tank1;
	public Transform tank2;

	private Vector3 offset;


	// Use this for initialization
	void Start () {
		offset = transform.position - (tank1.position + tank2.position) / 2;  //相机位置 -  两坦克中点坐标位置
	}
	
	// Update is called once per frame
	void Update () {
		if (!tank1 || !tank2) {
			return;
		}
		transform.position = (tank1.position + tank2.position) / 2 + offset;
		float dis = Vector3.Distance (tank1.position, tank2.position); //坦克间距离
		float size=dis*0.8f;    /// 0.8= camera.size/dis;  此处设定
		if(size<=5)
		{
			size = 5;
		}
		Camera.main.orthographicSize=size;
	}
}
