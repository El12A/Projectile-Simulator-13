using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    public class CylinderProjectile : Shape
    {
        [SerializeField] private Mesh cylinderMesh;

        public override float CalculateVolume()
        {
            //volume formula for Cylinder: 
            volume = Mathf.PI * height * radius * radius;
            return volume;
        }
        public override void SetScale()
        {
            // cylinder model has default of 0.5m radius, and 2m height so we do this scale to make it accurate in m to what the user enters
            projectile.transform.localScale = new Vector3(radius * 2, (height / 2), radius * 2);
        }
        public void SetMesh()
        {
            mesh = cylinderMesh;
            // rotate the cylinder so it is upright as the 3d mesh spawns tilted
            Quaternion newRotation = Quaternion.Euler(0f, 90f, 0f);
            projectileObject.transform.localRotation = newRotation;
        }
        public override void UpdateRigidbody()
        {
            projectileRb.mass = mass;
            projectileRb.drag = drag;
        }
    }
}

