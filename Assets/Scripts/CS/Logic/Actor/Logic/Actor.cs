using GameFramework.Fsm;
using UnityGameFramework.Runtime;

namespace ZFight.Logic
{
    /// <summary>
    /// 角色逻辑层
    /// </summary>
    public class Actor
    {
        public static string FsmName = "LogicActorFsm";
        private IFsm<Actor> fsm = null;

        public Actor()
        {
            FsmComponent fsmComponent = GameEntry.GetComponent<FsmComponent>();
            fsm = fsmComponent.CreateFsm(Actor.FsmName, this, new IdleState(), new MoveState(), new SkillState(), new DeadState());
            
        }

        public void Run()
        {
            fsm.Start<IdleState>();
        }
    }
}
