using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour 
{
	#region Atribut
	// Area kontrol layar sentuh
	private Rect leftArea, rightArea, bottomArea;
	private static Controller instance;
	#endregion

	#region Properti
	public static Controller Instance
	{
		get
		{
			if(instance == null)
			{
				instance = FindObjectOfType<Controller>();
			}
			return instance;
		}
	}
	#endregion

	#region Method
	// Mengubah Arah
	public void ChangeDirection(Vector3 pos, Player player)
	{
		// Area Layar sentuh kiri / Belok kiri
		leftArea = new Rect(0, Screen.height * .15f, Screen.width / 2, Screen.height * .72f);
		// Area Layar sentuh kanan / Belok kanan
		rightArea = new Rect(Screen.width / 2, Screen.height * .15f, Screen.width / 2, Screen .height * .72f);
		// Area Layar sentuh bawah / Rem
		bottomArea = new Rect(0, 0, Screen.width, Screen.height * .15f);

		Debug.Log(Input.mousePosition);
		if (leftArea.Contains(pos))
		{
			Debug.Log("Left : " + leftArea);
			player.Vehicle.UpdateDirection(Vector3.left);
		}
		if (rightArea.Contains(pos))
		{
			Debug.Log("Right : " + rightArea);
			player.Vehicle.UpdateDirection(Vector3.right);
		}
		if (bottomArea.Contains(pos))
		{
			Debug.Log("Bottom : " + bottomArea);
			player.Vehicle.UpdateDirection(Vector3.down);
		}
	}
	#endregion
}
