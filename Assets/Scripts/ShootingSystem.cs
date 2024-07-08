using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{


    [SerializeField] ParticleSystem inkParticle;

    void Start()
    {
    }

    void Update()
    {
        bool pressing = Input.GetMouseButton(0);

        if (Input.GetMouseButtonDown(0))
            inkParticle.Play();
        else if (Input.GetMouseButtonUp(0))
            inkParticle.Stop();

    }
}
