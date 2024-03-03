using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    // This is the Physics Simulator Scene Script 
    // Index of this scene is 1
    public class PhysicsSimulator : SceneController
    {
        public ProjectileMotion projectileMotion;
        public VariableController variableController;

        public GameObject physicsSimulatorObject;

        public void OnExitButtonClick()
        {
            ChangeScene(0);
        }

        public void OnProjectileEditorButtonClick()
        {
            ChangeScene(2);
        }
    }
}

