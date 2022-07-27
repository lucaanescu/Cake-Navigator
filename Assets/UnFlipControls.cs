using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnFlipControls : MonoBehaviour
{
	[SerializeField] public Movement move;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            move.flipped = false;
        }
    }
}
