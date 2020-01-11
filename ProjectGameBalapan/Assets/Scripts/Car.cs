using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
	[SerializeField]	private float speed, healthPoint;
	[SerializeField]	private string name;

  public string Name
  {
    get
    {
      return name;
    }
  }
}
