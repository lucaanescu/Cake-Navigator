using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
	static List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>();

	public static CinemachineVirtualCamera ActiveCamera = null;

	public static bool isActiveCamera(CinemachineVirtualCamera camera)
	{
		return camera == ActiveCamera;
	}

	public static void SwitchCamera(CinemachineVirtualCamera camera)
	{
		camera.Priority = 10;
		ActiveCamera = camera;

		foreach (CinemachineVirtualCamera c in cameras){
			if (c != camera && c.Priority != 0){
				c.Priority = 0;
			}
		}
	}

	public static void Register(CinemachineVirtualCamera camera)
	{
		cameras.Add(camera);
		Debug.Log("Camera added " + camera);
	}

	public static void UNregister(CinemachineVirtualCamera camera)
	{
		cameras.Remove(camera);
		Debug.Log("Camera removed" + camera);
	}
}
