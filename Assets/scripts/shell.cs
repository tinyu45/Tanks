using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell : MonoBehaviour {

	public GameObject shellExplosion;                  //子弹爆炸效果
	public AudioClip shellExplosionAudio;              //子弹爆炸音效

	// Use this for initialization
	void Start () {
		
	}
		
	//触发处理
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Tank") {
			other.GetComponent<TankHealth> ().getDamage ();
		}
		GameObject shell=Instantiate(shellExplosion, this.transform.position, this.transform.rotation);

		//播放炮弹爆炸音效    //声音太小 需要调整
		AudioSource.PlayClipAtPoint (shellExplosionAudio, transform.position);

		Destroy (this.gameObject);
	}
}
