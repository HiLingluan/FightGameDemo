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
    public class ZFightVersionInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.VersionInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 9, 9);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ForceUpdateGame", _g_get_ForceUpdateGame);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LatestGameVersion", _g_get_LatestGameVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InternalGameVersion", _g_get_InternalGameVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InternalResourceVersion", _g_get_InternalResourceVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdatePrefixUri", _g_get_UpdatePrefixUri);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VersionListLength", _g_get_VersionListLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VersionListHashCode", _g_get_VersionListHashCode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VersionListCompressedLength", _g_get_VersionListCompressedLength);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "VersionListCompressedHashCode", _g_get_VersionListCompressedHashCode);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ForceUpdateGame", _s_set_ForceUpdateGame);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "LatestGameVersion", _s_set_LatestGameVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "InternalGameVersion", _s_set_InternalGameVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "InternalResourceVersion", _s_set_InternalResourceVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "UpdatePrefixUri", _s_set_UpdatePrefixUri);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "VersionListLength", _s_set_VersionListLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "VersionListHashCode", _s_set_VersionListHashCode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "VersionListCompressedLength", _s_set_VersionListCompressedLength);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "VersionListCompressedHashCode", _s_set_VersionListCompressedHashCode);
            
			
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
					
					var gen_ret = new ZFight.VersionInfo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ZFight.VersionInfo constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ForceUpdateGame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ForceUpdateGame);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LatestGameVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.LatestGameVersion);
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
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.InternalGameVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InternalResourceVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.InternalResourceVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdatePrefixUri(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.UpdatePrefixUri);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_VersionListLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.VersionListLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_VersionListHashCode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.VersionListHashCode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_VersionListCompressedLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.VersionListCompressedLength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_VersionListCompressedHashCode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.VersionListCompressedHashCode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ForceUpdateGame(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ForceUpdateGame = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LatestGameVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LatestGameVersion = LuaAPI.lua_tostring(L, 2);
            
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
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.InternalGameVersion = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_InternalResourceVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.InternalResourceVersion = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UpdatePrefixUri(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.UpdatePrefixUri = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_VersionListLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.VersionListLength = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_VersionListHashCode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.VersionListHashCode = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_VersionListCompressedLength(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.VersionListCompressedLength = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_VersionListCompressedHashCode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.VersionInfo gen_to_be_invoked = (ZFight.VersionInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.VersionListCompressedHashCode = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
