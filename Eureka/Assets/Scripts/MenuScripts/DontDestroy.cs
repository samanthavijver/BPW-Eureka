using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class DontDestroy : MonoBehaviour {

    public GameObject[] ChildrenToDestroy;

	void Start()
    {
		DontDestroyOnLoad(this.gameObject);
        SceneManager.activeSceneChanged += OnSceneChange;   
	}

    private void OnSceneChange(Scene arg0, Scene arg1)
    {
        for(int i = 0; i < ChildrenToDestroy.Length; i++)
        {
            Destroy(ChildrenToDestroy[i]);
        }
        SceneManager.activeSceneChanged -= OnSceneChange;
    }
}
