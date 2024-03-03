using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    public class TeardropProjectile : Shape
    {
        [SerializeField] private Mesh teardropMesh;

        public override float CalculateVolume()
        {
            //volume formula for Teardrop: 
            volume = ((2 / 3) * Mathf.PI * radius * radius * radius) + ((height / 3) * Mathf.PI * radius * radius);
            return volume;
        }
        public override void SetScale()
        {
            //teardrop model has default of 0.5m radius, height (5/3)m, so we do this scale to make it accurate in m to what the user enters
            projectile.transform.localScale = new Vector3(radius * 2, radius * 2, height * 0.6f);
        }
        public void SetMesh()
        {
            mesh = teardropMesh;
            // teardrop mesh is tilted on spawn so need to adjust rotation
            Quaternion newRotation = Quaternion.Euler(-90f, 0f, 0f);
            projectile.transform.localRotation = newRotation;
        }
        public override void UpdateRigidbody()
        {
            projectileRb.mass = mass;
            projectileRb.drag = drag;
        }
    }
}

