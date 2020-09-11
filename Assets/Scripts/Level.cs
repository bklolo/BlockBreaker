using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    [SerializeField] int breakableBlocks;   // serialized for debugging purposes

    SceneLoader sceneLoader;
    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLoader = FindObjectOfType<SceneLoader>();
            sceneLoader.LoadNextScene();
        }
    }

}
