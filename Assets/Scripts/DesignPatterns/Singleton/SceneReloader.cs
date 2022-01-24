using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DesignPatterns.Singleton
{
    public class SceneReloader : MonoBehaviour
    {
        private void Update()
        {
            ReloadScene();
        }

        private void ReloadScene()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
    }
}