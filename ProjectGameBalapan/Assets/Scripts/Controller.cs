using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour 
{
	// Atribut
	private Rect leftArea, rightArea, bottomArea;
	private static Controller instance;

	// Properti
	public static Controller Instance
	{
		set
		{
			if(instance == null)
			{
				instance = FindObjectOfType<Controller>();
				instance.Initialize();
			}
		}
	}

	// Method
	private void Initialize() 
	{
		// Area Layar sentuh kiri / Belok kiri
		leftArea = new Rect(0, Screen.height * .15f, Screen.width / 2, Screen.height * .72f);
		// Area Layar sentuh kanan / Belok kanan
		rightArea = new Rect(Screen.width / 2, Screen.height * .15f, Screen.width / 2, Screen .height * .72f);
		// Area Layar sentuh bawah / Rem
		bottomArea = new Rect(0, 0, Screen.width, Screen.height * .15f);
	}
	
	public void ChangeDirection (Vector3 input)
	{
		Debug.Log(input);
		if (leftArea.Contains(input))
		{
			Debug.Log("Left : " + leftArea);
		}
		if (rightArea.Contains(input))
		{
			Debug.Log("Right : " + rightArea);
		}
		if (bottomArea.Contains(input))
		{
			Debug.Log("Bottom : " + bottomArea);
		}
	}
}
