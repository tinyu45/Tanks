using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

	public int maxhp=100;
	public int hp;   //坦克血量
	public Slider hpslider;
	public GameObject tankExploprefab;  //坦克爆炸效果
	public AudioClip tankexpAudio;      //坦克爆炸音效
	// Use this for initialization
	void Start () {
		hp = maxhp;
		hpslider.maxValue = maxhp;
		hpslider.value = maxhp;
	}
	
	//收到伤害的方法
	public void getDamage()
	{
		if (hp > 0) {
			hp -= Random.Range (10, 20); //随机伤害
			hpslider.value=hp;
		}	
		else
		{
			Instantiate (tankExploprefab, transform.position + Vector3.up, transform.rotation);
			AudioSource.PlayClipAtPoint (tankexpAudio, transform.position);
			Destroy (this.gameObject);
		}
	}
}
