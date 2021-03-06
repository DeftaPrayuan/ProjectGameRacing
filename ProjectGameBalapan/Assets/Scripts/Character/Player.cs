﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  #region Atribut
	[SerializeField] private string name;
  [SerializeField] private int rank;
  [SerializeField] private int laps;
  [SerializeField] private Vehicle vehicle;
  [SerializeField] private Skill[] skill;
  #endregion
  
  #region  Property
  public string Name
  {
    get
    {
      return name;
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
  public int Rank 
  {
    get
    {
      return rank;
    }
    set
    {
      rank = value;
    }
  }
  public int Laps 
  {
    get
    {
      return laps;
    }
    set
    {
      laps = value;
    }
  }
  #endregion

  #region  Method
  public Player(string _name)
  {
    name = _name;
  }
  public void UseSkill(int index)
  {

  }
  #endregion
}
