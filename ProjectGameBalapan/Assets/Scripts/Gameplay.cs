using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
	#region Atribut
	[SerializeField] private Player player;
	#endregion

	#region Properti
	#endregion

	#region Method
	// Use this for initialization
	private void Start ()
	{
		
	}
	
	// Update is called once per frame
	private void Update ()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Controller.Instance.ChangeDirection(Input.mousePosition, player);
		}
	}
	#endregion
}
