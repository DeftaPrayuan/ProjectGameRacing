using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  // Attribute
	[SerializeField] private string name;
  [SerializeField] private Vehicle vehicle;
  [SerializeField] private Skill[] skill;
  // Property
  public string Name
  {
    get
    {
      return name;
    }
    set
    {
      name = value;
    }
  }
  public Vehicle Vehicle
  {
    get
    {
      return vehicle;
    }
    set
    {
      vehicle = value;
    }
  }
  // Method
  public void UseSkill(int index)
  {

  }
}
