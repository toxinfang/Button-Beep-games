using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SettingsButton : MonoBehaviour
{
    public void PlaySettingsButton()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
