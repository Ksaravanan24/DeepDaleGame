using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPos : MonoBehaviour
{
   public Transform startPos;
   
   private void onTriggerEnter(Collider other)
   {
     if (other.gameObject.CompareTag("Player"))
     {
        other.gameObject.transform.position =startPos.position;
     }
   }
}
