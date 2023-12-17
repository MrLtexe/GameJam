using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerHolder : MonoBehaviour
{

    public float timer = 0;
    bool switchedScene = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2 && !switchedScene)
        {
            switchedScene = true;
            SceneManager.LoadScene("Level 2");
        }
    }
}
