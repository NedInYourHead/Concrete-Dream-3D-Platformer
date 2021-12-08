using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivate : MonoBehaviour
{
	
	public bool isActive = true;
	
	void OnTriggerStay(Collider other)
	{
		isActive = true;
	}
	void OnTriggerExit(Collider other)
	{
		isActive = false;
	}
}
