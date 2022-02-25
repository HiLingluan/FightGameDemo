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
    public class ZFightBulletDataWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.BulletData);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 0);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "OwnerId", _g_get_OwnerId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OwnerCamp", _g_get_OwnerCamp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Attack", _g_get_Attack);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Speed", _g_get_Speed);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<ZFight.CampType>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7))
				{
					int _entityId = LuaAPI.xlua_tointeger(L, 2);
					int _typeId = LuaAPI.xlua_tointeger(L, 3);
					int _ownerId = LuaAPI.xlua_tointeger(L, 4);
					ZFight.CampType _ownerCamp;translator.Get(L, 5, out _ownerCamp);
					int _attack = LuaAPI.xlua_tointeger(L, 6);
					float _speed = (float)LuaAPI.lua_tonumber(L, 7);
					
					var gen_ret = new ZFight.BulletData(_entityId, _typeId, _ownerId, _ownerCamp, _attack, _speed);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ZFight.BulletData constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OwnerId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BulletData gen_to_be_invoked = (ZFight.BulletData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.OwnerId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OwnerCamp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BulletData gen_to_be_invoked = (ZFight.BulletData)translator.FastGetCSObj(L, 1);
                translator.PushZFightCampType(L, gen_to_be_invoked.OwnerCamp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Attack(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BulletData gen_to_be_invoked = (ZFight.BulletData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Attack);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Speed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BulletData gen_to_be_invoked = (ZFight.BulletData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.Speed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
