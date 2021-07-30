using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{

    public ParticleSystem particleIn;
    public ParticleSystem particlOut;

    public float duration = 3f;

    ParticleSystem.EmissionModule emitIn;
    ParticleSystem.EmissionModule emitOut;

    
    void Start()
    {
        emitIn = particleIn.emission;
        emitOut = particlOut.emission;
        emitIn.enabled = false;
        emitOut.enabled = false;
    }

    
    void Update()
    {
        if (Input.GetButtonDown("XRI_Right_GripButton"))
        {
            emitIn.enabled = true;
            emitOut.enabled = false;
        }
        else if (Input.GetButtonUp("XRI_Right_GripButton"))
        {
           
            emitIn.enabled = false;
            emitOut.enabled = true;
        }
    }

    public void Off(ParticleSystem.EmissionModule emission)
    {
        emission.enabled = false;
    }

}
