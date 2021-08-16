using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBindler : MonoBehaviour
{
    [Header("结束时需要隐藏的节点")]
    public GameObject[] hideObjects;
    [Header("延迟隐藏时间")]
    public float delayHideTime;
    [Header("生命时长")]
    public float lifeTime;
    public void play()
    {
        foreach (var item in hideObjects)
        {
            item.SetActive(true);
        }
    }

    public void stop(Action<object> cb)
    {
        if (delayHideTime <= 0) cb(null);
        else
        {
            foreach (var item in hideObjects)
            {
                item.SetActive(false);
            }
            //Timmer.instance.addDelayCallBack(delayHideTime, cb);
        }
    }

    /// <summary>
    /// 设置特效信息
    /// </summary>
    /// <param name="fetter"></param>
    /// <param name="lv"></param>
    /// <param name="isUp">负数降级 正数升级 0不变</param>
    public void setHeadData(Texture2D fetter, Texture2D lv, int isUp, uint level)
    {
        if (isUp > 0)
        {
            Renderer rendererFetter = transform.Find("UI_jiban_1/A").GetComponent<Renderer>();
            if (rendererFetter == null) return;
            Renderer rendererLv = transform.Find("UI_jiban_1/B").GetComponent<Renderer>();
            if (rendererLv == null) return;
            rendererFetter.material.SetTexture("_MainTex", fetter);
            rendererLv.material.SetTexture("_MainTex", lv);
        }
        else if (isUp < 0)
        {
            Renderer rendererFetter = transform.Find("A").GetComponent<Renderer>();
            if (rendererFetter == null) return;
            rendererFetter.material.SetTexture("_MainTex", fetter);
            if (level <= 0)
            {
                transform.Find("B").gameObject.SetActive(false);
                return;
            }
            transform.Find("B").gameObject.SetActive(true);
            Renderer rendererLv = transform.Find("B").GetComponent<Renderer>();
            if (rendererLv == null) return;
            rendererLv.material.SetTexture("_MainTex", lv);
        }
        else
        {

        }
    }
}
