using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(ObjectPool))]//自动挂上对象池
[RequireComponent(typeof(StaticData))]
public class Game : ApplicationBase<Game>
{
    [HideInInspector]
    public ObjectPool ObjectPool = null;
    [HideInInspector]
    public StaticData StaticData = null;
    public void LoadSence(int level)
    {
        SceneArgs e = new SceneArgs();
        e.SceneIndex = SceneManager.GetActiveScene().buildIndex;
        SendEvend(Consts.E_ExistScence,e);
        SceneManager.LoadScene(level,LoadSceneMode.Single);//跳转场景
    }
    private void OnLevelWasLoaded(int level)
    {
        SceneArgs e = new SceneArgs();
        e.SceneIndex = level;
        SendEvend(Consts.E_EnterScence,e);
    }
    // Start is called before the first frame update
    void Start()
    {

        Object.DontDestroyOnLoad(this.gameObject);
        ObjectPool = ObjectPool.T_Instatic;
        StaticData = StaticData.T_Instatic;
         
        RegisterController(Consts.E_StartUp,typeof(StartUpCommand));
        SendEvend(Consts.E_StartUp);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
