using UnityEngine;

public class ScreenControl : MonoBehaviour
{
    // Start is called before the first frame update
    //開始方法:遊戲開始時執行一次
    void Start()
    {
	//設定螢幕(寬，高，是否全螢幕)
        Screen.SetResolution(576,1024,false);
    }
}
