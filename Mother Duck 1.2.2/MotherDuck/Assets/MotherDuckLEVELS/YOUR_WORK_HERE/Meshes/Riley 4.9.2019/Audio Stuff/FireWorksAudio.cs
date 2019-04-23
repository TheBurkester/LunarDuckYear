using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWorksAudio : MonoBehaviour {
// picks number from 1-3
	public AudioSource audio;
	public AudioClip [] audioClip; 
	float timer;
	public float minRate =1;
	public float maxRate =3;

	
	void Start () {
		audio=GetComponent<AudioSource>();
	}
	
	// Randomly Picks audio which is 0-3
	void Update () {
		timer -= Time.deltaTime;

	if (timer <0 )
	{
		timer = Random.RandomRange (minRate,maxRate);
		
		audio.PlayOneShot(audioClip[Random.RandomRange(0,audioClip.Length)]);

	}
	}
}
