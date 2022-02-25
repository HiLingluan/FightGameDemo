#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class ZFightConstantLayerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.Constant.Layer);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultLayerName", ZFight.Constant.Layer.DefaultLayerName);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultLayerId", ZFight.Constant.Layer.DefaultLayerId);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UILayerName", ZFight.Constant.Layer.UILayerName);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UILayerId", ZFight.Constant.Layer.UILayerId);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TargetableObjectLayerName", ZFight.Constant.Layer.TargetableObjectLayerName);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TargetableObjectLayerId", ZFight.Constant.Layer.TargetableObjectLayerId);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ZFight.Constant.Layer does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
