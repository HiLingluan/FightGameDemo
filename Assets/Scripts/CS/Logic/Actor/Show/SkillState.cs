using GameFramework.Fsm;
using UnityGameFramework.Runtime;
namespace ZFight.Show
{
    /// <summary>
    /// 技能表现层
    /// </summary>
    public class SkillState : FsmState<Actor>
    {
        protected override void OnInit(IFsm<Actor> fsm)
        {
            // 创建有限状态机时调用
            base.OnInit(fsm);
            Log.Info("创建技能表现状态。");
        }

        protected override void OnDestroy(IFsm<Actor> fsm)
        {
            // 销毁有限状态机时调用
            base.OnDestroy(fsm);
            Log.Info("销毁技能表现状态。");
        }

        protected override void OnEnter(IFsm<Actor> fsm)
        {
            // 进入本状态时调用
            base.OnEnter(fsm);
            Log.Info("进入技能表现状态。");
        }

        protected override void OnLeave(IFsm<Actor> fsm, bool isShutdown)
        {
            // 离开本状态时调用
            base.OnLeave(fsm, isShutdown);
            Log.Info("离开技能表现状态。");
        }

        protected override void OnUpdate(IFsm<Actor> fsm, float elapseSeconds, float realElapseSeconds)
        {
            // 本状态被轮询时调用
            base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
            Log.Info("轮询技能表现状态。");
        }
    }
}