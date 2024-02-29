using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject VFXBumper;
    public GameObject VFXSwitch;


    public void PlayVFXBumper(Vector3 spawnPosition)
    {
        GameObject.Instantiate(VFXBumper, spawnPosition, Quaternion.identity);
    }
    public void PlayVFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(VFXSwitch, spawnPosition, Quaternion.identity);
    }
}
