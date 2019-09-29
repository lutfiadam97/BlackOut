using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
	public AudioSource klik;
	public AudioSource duar;

	public void PlayKlik()
	{
		klik.Play();
	}
}
