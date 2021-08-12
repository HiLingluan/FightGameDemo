using GameFramework.Fsm;
using UnityGameFramework.Runtime;

namespace ZFight.Show
{
    /// <summary>
    /// 角色表现层
    /// </summary>
    public class Actor
    {
        public static string FsmName = "ShowActorFsm";
        private IFsm<Actor> fsm = null;

        public Actor()
        {
            FsmComponent fsmComponent = GameEntry.GetComponent<FsmComponent>();
            fsm = fsmComponent.CreateFsm(Actor.FsmName, this, new IdleState(), new MoveState(),new SkillState(),new DeadState());
        }

        public void Run()
        {
            fsm.Start<IdleState>();

        }
    }
}
