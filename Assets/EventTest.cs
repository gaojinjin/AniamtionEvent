using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Event0() {
        Debug.Log("大师兄，师傅被妖怪抓走了");
    }
    public void Event1(GameObject go)
    {
        Debug.Log("二师兄，师傅被妖怪抓走了"+go.name);
    }
    public void Event2(int go)
    {
        Debug.Log("沙师弟，师傅被妖怪抓走了" + go);
    }
    public void Event3(float go)
    {
        Debug.Log("大师兄，师傅又被妖怪抓走了" + go);
    }
    public void Event4(string go)
    {
        Debug.Log("师傅，大师兄被妖怪抓走了" + go);
    }
}
