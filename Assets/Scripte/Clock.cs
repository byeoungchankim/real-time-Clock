using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    //필드 직렬화
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
        //현재시간 DateTime 활성화 할려면 using System 활성화 시켜준다
        DateTime currentTime = DateTime.Now;

        //시곗바늘 회전
        //초침 회전
        float secondsDegree = (currentTime.Second / -60f) * 360f;  
        secondsHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, secondsDegree));
        //분침 회전
        float minutesDegree = (currentTime.Minute / -60f) * 360f;
        minutesHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, minutesDegree));
        //시침 회전
        float hoursDegree = (currentTime.Hour / -12f) * 360f;
        hoursHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, hoursDegree));
    }
}
