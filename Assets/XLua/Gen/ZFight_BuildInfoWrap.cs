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
    public class ZFightBuildInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.BuildInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 7, 7);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "GameVersion", _g_get_GameVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InternalGameVersion", _g_get_InternalGameVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CheckVersionUrl", _g_get_CheckVersionUrl);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "WindowsAppUrl", _g_get_WindowsAppUrl);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MacOSAppUrl", _g_get_MacOSAppUrl);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IOSAppUrl", _g_get_IOSAppUrl);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AndroidAppUrl", _g_get_AndroidAppUrl);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "GameVersion", _s_set_GameVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "InternalGameVersion", _s_set_InternalGameVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CheckVersionUrl", _s_set_CheckVersionUrl);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "WindowsAppUrl", _s_set_WindowsAppUrl);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MacOSAppUrl", _s_set_MacOSAppUrl);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IOSAppUrl", _s_set_IOSAppUrl);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AndroidAppUrl", _s_set_AndroidAppUrl);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new ZFight.BuildInfo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ZFight.BuildInfo constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GameVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.GameVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InternalGameVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.InternalGameVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CheckVersionUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.CheckVersionUrl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WindowsAppUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.WindowsAppUrl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MacOSAppUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.MacOSAppUrl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IOSAppUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.IOSAppUrl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AndroidAppUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.AndroidAppUrl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GameVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.GameVersion = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_InternalGameVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.InternalGameVersion = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CheckVersionUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CheckVersionUrl = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_WindowsAppUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.WindowsAppUrl = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MacOSAppUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MacOSAppUrl = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IOSAppUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IOSAppUrl = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AndroidAppUrl(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuildInfo gen_to_be_invoked = (ZFight.BuildInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AndroidAppUrl = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
