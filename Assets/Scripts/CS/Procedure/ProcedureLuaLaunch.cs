//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework.Localization;
using GameFramework.Procedure;
using System;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using UnityEngine;

namespace ZFight
{
    public class ProcedureLuaLaunch : ProcedureBase
    {

        public override bool UseNativeDialog => throw new NotImplementedException();

        protected override void OnInit(ProcedureOwner procedureOwner)
        {
            base.OnInit(procedureOwner);
            GameEntry.Lua = new GameObject("LuaLaunch").AddComponent<LuaManager>();
        }

        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            GameEntry.Lua.Init();
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        }

        protected override void OnLeave(ProcedureOwner procedureOwner,bool isShutDown)
        {
            base.OnLeave(procedureOwner,isShutDown);
            //销毁,释放Lua
            GameEntry.Lua.Dispose();
        }
    
    }
}
