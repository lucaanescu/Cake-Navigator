using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
	public Material Sky1;
	public Material Sky2;

	public bool sky1 = true;
	public bool sky2 = false;

	void Awake()
	{
		RenderSettings.skybox = Sky1;
	}

	public void Update()
	{
		if(Input.GetButtonDown("Switch") && sky2 == false)
		{
			sky2 = true;
			sky1 = false;
			RenderSettings.skybox = Sky2;
			
		}
		else if(Input.GetButtonDown("Switch") && sky2 == true)
		{
			sky2 = false;
			sky1 = true;
			RenderSettings.skybox = Sky1;
			
		}
	}

}
