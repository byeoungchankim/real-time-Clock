using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    //�ʵ� ����ȭ
    [SerializeField]
    GameObject secondsHand;

    [SerializeField]
    GameObject minutesHand;

    [SerializeField]
    GameObject hoursHand;

    void Start ()
    {
       // secondsHand = GameObject.Find("SecondsHand");
    }

    void Update()
    {
        //����ð� DateTime Ȱ��ȭ �ҷ��� using System Ȱ��ȭ �����ش�
        DateTime currentTime = DateTime.Now;

        //�ð�ٴ� ȸ��
        //��ħ ȸ��
        float secondsDegree = (currentTime.Second / -60f) * 360f;  
        secondsHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, secondsDegree));
        //��ħ ȸ��
        float minutesDegree = (currentTime.Minute / -60f) * 360f;
        minutesHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, minutesDegree));
        //��ħ ȸ��
        float hoursDegree = (currentTime.Hour / -12f) * 360f;
        hoursHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, hoursDegree));
    }
}
