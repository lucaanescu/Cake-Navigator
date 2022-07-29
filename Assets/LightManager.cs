using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
	public Material Sky1;
	public Material Sky2;

	void Awake()
	{
		RenderSettings.skybox = Sky1;
	}
}
