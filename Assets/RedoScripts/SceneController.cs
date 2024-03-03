using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PhysicsProjectileSimulator
{
    // this class is used to manage all the scenes
    // It has three children classes each representing the different scenes
    // Scene 1 (index 0 in SceneManger) is the MainMenu, Scene 2 (index 1) is the PhysicsSimulator, Scene 3 (index 2) is the ProjectileEditor
    public class SceneController : GameController
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        // scene manager has scenes in a list. This project has my three scenes: main menu, physics simulator, projectile editor.
        // on call of this function the scene with the specific index referenced by the inputted indexOfScene integer, will be loaded.
        public void ChangeScene(int indexOfScene)
        {
            SceneManager.LoadScene(indexOfScene);
        }
    }
}

