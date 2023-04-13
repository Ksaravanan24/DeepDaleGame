
using System;
using UnityEngine;


public class LookAtTarget : MonoBehaviour
{
     public Transform Player;


  void Update()
  {
       if(Player != null)
       {
            transform.LookAt(Player);
       }
  }

}