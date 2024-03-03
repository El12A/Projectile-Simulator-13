using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PhysicsProjectileSimulator
{
    public class MainMenu : SceneController
    {
        public GameObject MainMenuObject;
        public GameObject SettingsMenuObject;
        public GameObject InstructionsMenuObject;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnPlayButtonClick()
        {
            ChangeScene(1);
        }
        public void OnSettingsButtonClick()
        {
            MainMenuObject.SetActive(false);
            SettingsMenuObject.SetActive(true);
        }
        public void OnInstructionsButtonClick()
        {
            MainMenuObject.SetActive(false);
            InstructionsMenuObject.SetActive(true);
        }
        public void OnQuitButtonClick()
        {
            Application.Quit();
        }
    }
}

