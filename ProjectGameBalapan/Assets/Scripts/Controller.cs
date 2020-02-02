using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour 
{
	#region Atribut
	// Area kontrol layar sentuh
	private Rect leftArea, rightArea, bottomArea;
	// Objek yang dikendalikan
	private Player player;
	private static Controller instance;
	#endregion

	#region Properti
	public static Controller Instance
	{
		set
		{
			if(instance == null)
			{
				instance = FindObjectOfType<Controller>();
				instance.Init();
			}
		}
	}
	#endregion

	#region Method
	// Menginisialisasi
	private void Init() 
	{
	}
	// Mengubah Arah
	private void Update ()
	{
		// Mencari Gameobject yang terdapat Class Player
		player = FindObjectOfType<Player>();
		// Area Layar sentuh kiri / Belok kiri
		leftArea = new Rect(0, Screen.height * .15f, Screen.width / 2, Screen.height * .72f);
		// Area Layar sentuh kanan / Belok kanan
		rightArea = new Rect(Screen.width / 2, Screen.height * .15f, Screen.width / 2, Screen .height * .72f);
		// Area Layar sentuh bawah / Rem
		bottomArea = new Rect(0, 0, Screen.width, Screen.height * .15f);
		
		if(Input.GetMouseButtonDown(0))
		{
			Debug.Log(Input.mousePosition);
			if (leftArea.Contains(Input.mousePosition))
			{
				Debug.Log("Left : " + leftArea);
			}
			if (rightArea.Contains(Input.mousePosition))
			{
				Debug.Log("Right : " + rightArea);
			}
			if (bottomArea.Contains(Input.mousePosition))
			{
				Debug.Log("Bottom : " + bottomArea);
			}
		}
	}
	#endregion
}
