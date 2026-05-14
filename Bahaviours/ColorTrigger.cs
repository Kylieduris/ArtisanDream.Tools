using UnityEngine;
using System.Collections;

public class colorChange : MonoBehaviour
{
  
    void OnTriggerEnter(Collider other)

    {
        print(other.name);
        if (other.name == "TriggerZone")

        {
          
                GetComponent<Renderer>().material.color = Color.purple;
              
           
          
        }
    }
}
