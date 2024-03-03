using PhysicsProjectileSimulator;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    public class InitialHeightInputFieldController : VariableController
    {
        [SerializeField] private GameObject projectileShooter;
        public InputFieldRestrictor inputFieldRestrictor;

        public void OnInputHeightEndEdit()
        {
            // calls the onEndEdit function attached to the InputField of InitialHeight 
            inputFieldRestrictor.OnEndEdit();
            float initialHeight = float.Parse(inputFieldRestrictor.inputField.text);

            if (initialHeight < 50 && initialHeight >= 1)
            {
                Vector3 shooter = projectileShooter.transform.position;
                // set new height of the projectile shooter gameobject based on input
                projectileShooter.transform.position = new Vector3(shooter.x, shooter.y + initialHeight - 1, shooter.z);
                // set new height of projectile aswell to that of the projectile shooter
                Vector3 proj = projectile.initialPosition;
                projectile.initialPosition = new Vector3(proj.x, proj.y + initialHeight - 1, proj.z);
                projectile.projectileObject.transform.position = projectile.initialPosition;
            }
            else
            {
                ErrorMessageText.text = "InputHeight Must be atleast 1m and no more than 50m";
            }
        }
    }
}

