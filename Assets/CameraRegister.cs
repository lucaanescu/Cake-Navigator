using UnityEngine;
using Cinemachine;

public class CameraRegister : MonoBehaviour
{
	private void OnEnable()
	{
		CameraSwitcher.Register(GetComponent<CinemachineVirtualCamera>());
	}

	private void OnDisable()
	{
		CameraSwitcher.UNregister(GetComponent<CinemachineVirtualCamera>());
	}
}
