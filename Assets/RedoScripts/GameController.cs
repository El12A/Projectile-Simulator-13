using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsProjectileSimulator
{
    public class GameController : MonoBehaviour
    {
        public GameComponent gameComponent;
            public Projectile projectile;
            public CameraController cameraController;
        public SceneController sceneController;
            public ProjectileEditor projectileEditor;
            public MainMenu mainMenu;
            public PhysicsSimulator physicsSimulator;

        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

