using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer 
{
    SimpleAnimation player;
    
    public AnimationPlayer(SimpleAnimation player)
    {
        this.player = player;
    }

    public void Idle()
    {
        player?.Play("idle_1");
    }

    public void Death()
    {
        player?.Play("death");
    }
    /// <summary>
    /// 播放动画
    /// </summary>
    /// <param name="actionName"></param>
    /// <param name="loop"></param>
    /// <param name="onComplete"></param>
    /// <param name="onHit">打击帧</param>
    public void Play(string actionName, bool loop = false, Action<string> onComplete = null, Action<string> onHit = null)
    {
        player?.Play(actionName, onComplete, onHit);
    }

    public void Stop()
    {
        player?.Stop();
    }

    public void destory()
    {
         player?.Stop();
    }
}
