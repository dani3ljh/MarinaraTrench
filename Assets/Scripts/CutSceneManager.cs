using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour
{
    [SerializeField] private UnityEngine.Video.VideoPlayer videoPlayer;
    [SerializeField] private int MenuSceneNumber;

    private SceneLoader sl;

    void Start()
    {
        sl = GetComponent<SceneLoader>();

        videoPlayer.loopPointReached += LoadMenu;
    }

    void LoadMenu(UnityEngine.Video.VideoPlayer vp) {
        sl.LoadScene(MenuSceneNumber);
    }
}
