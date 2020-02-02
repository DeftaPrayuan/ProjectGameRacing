using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum VehicleType
{
  Ocean, Hell, Sky
}

public class Vehicle : MonoBehaviour
{
  #region Atribut
  // Nama Kendaraan
  [SerializeField] private string name;
  // Kecepatan, Kekuatan, Pertahanan dari Kendaraan
  [SerializeField] private int speed, power, defense;
  // Poin Darah dari Kendaraan
  [SerializeField] private float healthPoint;
  // Tipe Kendaraan
  [SerializeField] private VehicleType vehicleType;
  // Objek Kendaraan
  [SerializeField] private GameObject vehicle;
  #endregion

  #region Properti
  public string Name
  {
    get
    {
      return name;
    }
  }
  #endregion

  #region Method
  // Mengurangi Kecepatan hingga berhenti
  public void Rem()
  {
  }
  // Menjalankan Objek Kendaraan Secara Otomatis
  public void Run()
  {
  }

  public void UpdateDirection(Vector3 direction)
  {
  }

  #endregion
}
