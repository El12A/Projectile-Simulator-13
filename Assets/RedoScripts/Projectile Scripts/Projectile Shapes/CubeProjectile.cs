using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace PhysicsProjectileSimulator
{
    public class CubeProjectile : Shape
    {
        [SerializeField] private Mesh cubeMesh;

        public override float CalculateVolume()
        {
            //volume formula for cube
            volume = length * width * height;
            return volume;
        }
        public override void SetScale()
        {
            projectile.transform.localScale = new Vector3(width, height, length);
        }
        public void SetMesh()
        {
            mesh = cubeMesh;
        }
        public override void UpdateRigidbody()
        {
            projectileRb.mass = mass;
            projectileRb.drag = drag;
        }
    }
}

