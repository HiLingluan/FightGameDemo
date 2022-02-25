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
    public class ZFightAircraftDataWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.AircraftData);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 5, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetThrusterData", _m_GetThrusterData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllWeaponDatas", _m_GetAllWeaponDatas);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AttachWeaponData", _m_AttachWeaponData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DetachWeaponData", _m_DetachWeaponData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAllArmorDatas", _m_GetAllArmorDatas);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AttachArmorData", _m_AttachArmorData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DetachArmorData", _m_DetachArmorData);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "MaxHP", _g_get_MaxHP);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Defense", _g_get_Defense);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Speed", _g_get_Speed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DeadEffectId", _g_get_DeadEffectId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DeadSoundId", _g_get_DeadSoundId);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ZFight.AircraftData does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetThrusterData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetThrusterData(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllWeaponDatas(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetAllWeaponDatas(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AttachWeaponData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ZFight.WeaponData _weaponData = (ZFight.WeaponData)translator.GetObject(L, 2, typeof(ZFight.WeaponData));
                    
                    gen_to_be_invoked.AttachWeaponData( _weaponData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DetachWeaponData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ZFight.WeaponData _weaponData = (ZFight.WeaponData)translator.GetObject(L, 2, typeof(ZFight.WeaponData));
                    
                    gen_to_be_invoked.DetachWeaponData( _weaponData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllArmorDatas(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetAllArmorDatas(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AttachArmorData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ZFight.ArmorData _armorData = (ZFight.ArmorData)translator.GetObject(L, 2, typeof(ZFight.ArmorData));
                    
                    gen_to_be_invoked.AttachArmorData( _armorData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DetachArmorData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ZFight.ArmorData _armorData = (ZFight.ArmorData)translator.GetObject(L, 2, typeof(ZFight.ArmorData));
                    
                    gen_to_be_invoked.DetachArmorData( _armorData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxHP(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.MaxHP);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Defense(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Defense);
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
			
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.Speed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DeadEffectId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.DeadEffectId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DeadSoundId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.AircraftData gen_to_be_invoked = (ZFight.AircraftData)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.DeadSoundId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
