using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
	public Material Sky1;
	public Material Sky2;

	public Light light1;
	public Light light2;

	public bool sky1 = true;
	public bool sky2 = false;

	private float timer = 0.02f;
	private float timeleft = 0.02f;
	private bool TimerOn = false;

	[SerializeField] public CanvasGroup Fade;

	void Awake()
	{
		RenderSettings.skybox = Sky1;
		Fade.alpha = 0f;
	}

	public void Update()
	{

		Debug.Log(timeleft);

		if(Input.GetButtonDown("Switch"))
		{
			TimerOn = true;
		}

		if(TimerOn == true && timeleft > 0f)
			{
				timeleft -= Time.deltaTime;
				Time.timeScale = 0.01f;
				Fade.alpha += Time.deltaTime;

				if(timeleft < 0.01f && sky2 == false)
				{
					
					sky2 = true;
					light1.enabled = true;
					light2.enabled = false;
					sky1 = false;
					RenderSettings.skybox = Sky2;

				}
				else if(timeleft < 0.01f && sky2 == true)
				{
					sky2 = false;
					light1.enabled = false;
					light2.enabled = true;
					sky1 = true;
					RenderSettings.skybox = Sky1;

				}
			}
		if(timeleft <= 0f)
		{
			timeleft = timer;
			TimerOn = false;
			Time.timeScale = 1f;
			Fade.alpha = 0f;
		}

	}

}
