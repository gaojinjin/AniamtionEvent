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
        Debug.Log("��ʦ�֣�ʦ��������ץ����");
    }
    public void Event1(GameObject go)
    {
        Debug.Log("��ʦ�֣�ʦ��������ץ����"+go.name);
    }
    public void Event2(int go)
    {
        Debug.Log("ɳʦ�ܣ�ʦ��������ץ����" + go);
    }
    public void Event3(float go)
    {
        Debug.Log("��ʦ�֣�ʦ���ֱ�����ץ����" + go);
    }
    public void Event4(string go)
    {
        Debug.Log("ʦ������ʦ�ֱ�����ץ����" + go);
    }
}
