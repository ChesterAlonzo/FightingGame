using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAfterTimeAdditive : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading;
    [SerializeField]
    private string sceneNameToLoad;

    private float TimeElapsed;
    private void Update()
    {
        TimeElapsed += Time.deltaTime;

        if (TimeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad, LoadSceneMode.Additive);
        }
    }
}
 