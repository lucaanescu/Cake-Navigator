using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipControls : MonoBehaviour
{
	[SerializeField] public Movement move;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            move.flipped = true;
        }
    }
}
