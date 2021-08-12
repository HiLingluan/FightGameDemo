using GameFramework.Fsm;
using UnityGameFramework.Runtime;
namespace ZFight.Logic
{
    /// <summary>
    /// 技能逻辑层
    /// </summary>
    public class SkillState : FsmState<Actor>
    {
        protected override void OnInit(IFsm<Actor> fsm)
        {
            base.OnInit(fsm);
            Log.Info("创建技能状态。");
        }

        protected override void OnDestroy(IFsm<Actor> fsm)
        {
            base.OnDestroy(fsm);
            Log.Info("销毁技能状态。");
        }

        protected override void OnEnter(IFsm<Actor> fsm)
        {
            base.OnEnter(fsm);
            Log.Info("进入技能状态。");
        }

        protected override void OnLeave(IFsm<Actor> fsm, bool isShutdown)
        {
            base.OnLeave(fsm, isShutdown);
            Log.Info("离开技能状态。");
        }

        protected override void OnUpdate(IFsm<Actor> fsm, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
            Log.Info("轮询技能状态。");
        }
    }
}