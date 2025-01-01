using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepoController : MonoBehaviour
{
	[SerializeField] private DroneController droneController;


	private void OnTriggerEnter2D(Collider2D collision)
	{

		droneController.yemekCount = 15;
		droneController.ilacCount = 15;
	}
}
