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
    public class ZFightConstantSettingWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.Constant.Setting);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Language", ZFight.Constant.Setting.Language);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SoundGroupMuted", ZFight.Constant.Setting.SoundGroupMuted);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SoundGroupVolume", ZFight.Constant.Setting.SoundGroupVolume);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MusicMuted", ZFight.Constant.Setting.MusicMuted);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MusicVolume", ZFight.Constant.Setting.MusicVolume);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SoundMuted", ZFight.Constant.Setting.SoundMuted);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SoundVolume", ZFight.Constant.Setting.SoundVolume);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UISoundMuted", ZFight.Constant.Setting.UISoundMuted);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UISoundVolume", ZFight.Constant.Setting.UISoundVolume);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ZFight.Constant.Setting does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
