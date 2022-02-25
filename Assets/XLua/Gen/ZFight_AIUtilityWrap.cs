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
    public class ZFightAIUtilityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.AIUtility);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRelation", _m_GetRelation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCamps", _m_GetCamps_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDistance", _m_GetDistance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PerformCollision", _m_PerformCollision_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ZFight.AIUtility does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRelation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    ZFight.CampType _first;translator.Get(L, 1, out _first);
                    ZFight.CampType _second;translator.Get(L, 2, out _second);
                    
                        var gen_ret = ZFight.AIUtility.GetRelation( _first, _second );
                        translator.PushZFightRelationType(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCamps_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    ZFight.CampType _camp;translator.Get(L, 1, out _camp);
                    ZFight.RelationType _relation;translator.Get(L, 2, out _relation);
                    
                        var gen_ret = ZFight.AIUtility.GetCamps( _camp, _relation );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDistance_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    ZFight.Entity _fromEntity = (ZFight.Entity)translator.GetObject(L, 1, typeof(ZFight.Entity));
                    ZFight.Entity _toEntity = (ZFight.Entity)translator.GetObject(L, 2, typeof(ZFight.Entity));
                    
                        var gen_ret = ZFight.AIUtility.GetDistance( _fromEntity, _toEntity );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PerformCollision_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    ZFight.TargetableObject _entity = (ZFight.TargetableObject)translator.GetObject(L, 1, typeof(ZFight.TargetableObject));
                    ZFight.Entity _other = (ZFight.Entity)translator.GetObject(L, 2, typeof(ZFight.Entity));
                    
                    ZFight.AIUtility.PerformCollision( _entity, _other );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
