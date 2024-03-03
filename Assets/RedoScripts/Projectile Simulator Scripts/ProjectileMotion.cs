using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsProjectileSimulator
{

    public class ProjectileMotion : PhysicsSimulator
    {
        public bool reset;
        public bool inMotion;
        public bool isPaused;

        private Vector3 accelerationForce;
        public GameObject trajectoryObject;

        private Rigidbody projectileRb;
        private Vector3 velocityToReapply;

        // Start is called before the first frame update
        void Start()
        {
            projectileRb = projectile.projectileRb;
            projectileRb.isKinematic = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && reset == true)
            {
                inMotion = true;
                reset = false;
                projectile.projectileRb.isKinematic = false;
                accelerationForce = variableController.acceleration;
                projectile.projectileRb.velocity = variableController.initialVelocity;
            }

            // when R is pressed the projectile is reset.
            if (Input.GetKeyDown(KeyCode.R) && reset == false)
            {
                ResetProjectile();
            }

            if (inMotion == true)
            {
                //To apply the right force need to use F = ma as in order to have the same acceleration on any object we need to apply a force proportional to the mass.s
                projectileRb.AddForce(accelerationForce * projectileRb.mass, ForceMode.Force);
            }
        }

        // reseting the velocity and angular velocity to zero, making the projectile kinematic so it no longer moves and also reseting its position to its initial start position (inside the projectile shooter cannon object as you can see in the scene).
        private void ResetProjectile()
        {
            projectileRb.velocity = Vector3.zero;
            projectileRb.angularVelocity = Vector3.zero;
            projectileRb.isKinematic = true;
            projectileRb.transform.position = projectile.initialPosition;
            reset = true;
            inMotion = false;
        }

        // when the pause/play button is clicked then depending on the state it will either pause the projectile motion or allow it to contiue moving
        public void OnPausePlayButtonClick()
        {
            // if the simulation is not paused save the current velocity for the unpause and then set the rigidbogy to kinematic so it cannot move
            if (isPaused == false)
            {
                velocityToReapply = projectileRb.GetPointVelocity(projectileRb.position);
                projectileRb.isKinematic = true;
                isPaused = true;
                inMotion = false;
            }
            //else set kinematic to false so it can move and apply teh previous velocity saved in velocityToReapply
            else
            {
                projectileRb.isKinematic = false;
                projectileRb.velocity = velocityToReapply;
                isPaused = false;
                inMotion = true;
            }
        }
        // this is attached to Move Button Click event
        // it moves the targetGameObject to the displacement entered by the user only if its a successfull user input
        public void OnDisplacementChange()
        {
            if (variableController.ErrorMessageText.text == "Successfull Input")
            {
                trajectoryObject.transform.position = GameControl.control.initialPosition + GameControl.control.displacement;
            }
        }
    }
}

