using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    public class DisplayCurrentVariables : PhysicsSimulator
    {
        [SerializeField] private TMP_Text displacementText;
        [SerializeField] private TMP_Text velocityText;
        [SerializeField] private TMP_Text accelerationText;
        [SerializeField] private TMP_Text timeText;
        private float time;

        // Update is called once per frame
        void Update()
        {
            // start updating the text for current variables only when the projectile is in motion;
            if (projectileMotion.inMotion == true)
            {
                time += Time.deltaTime;
                // show displacement by getting string version of current position and taking it away from current rigidbody component position
                displacementText.text = "Displacement: " + (projectile.projectileRb.position - projectile.initialPosition).ToString();

                velocityText.text = "Velocity: " + (projectile.projectileRb.GetPointVelocity(projectile.projectileRb.position)).ToString();
                // use F = ma to get acceleration and 
                accelerationText.text = "Acceleration: " + (projectile.projectileRb.GetAccumulatedForce() / projectile.projectileRb.mass).ToString();
                timeText.text = "Time: " + time.ToString();
            }
            // when projectile is reset so is the text of the current variables
            if (Input.GetKeyDown(KeyCode.R))
            {
                time = 0;
                timeText.text = "Time: ";
                velocityText.text = "Velocity: ";
                accelerationText.text = "Acceleration: ";
                displacementText.text = "Displacement: ";
            }
        }
    }
}

