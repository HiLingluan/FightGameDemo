using GameFramework.Fsm;
using UnityGameFramework.Runtime;
namespace ZFight.Show
{
    /// <summary>
    /// 死亡状态显示层
    /// </summary>
    public class DeadState : FsmState<Actor>
    {
        protected override void OnInit(IFsm<Actor> fsm)
        {
            base.OnInit(fsm);
            Log.Info("创建死亡状态。");
        }

        protected override void OnDestroy(IFsm<Actor> fsm)
        {
            base.OnDestroy(fsm);
            Log.Info("销毁死亡状态。");
        }

        protected override void OnEnter(IFsm<Actor> fsm)
        {
            base.OnEnter(fsm);
            Log.Info("进入死亡状态。");
        }

        protected override void OnLeave(IFsm<Actor> fsm, bool isShutdown)
        {
            base.OnLeave(fsm, isShutdown);
            Log.Info("离开死亡状态。");
        }

        protected override void OnUpdate(IFsm<Actor> fsm, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
            Log.Info("轮询死亡状态。");
        }
    }
}