using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{
    public void teleport(Vector3 location)
    {
        
        this.transform.position = location;
    }
}
