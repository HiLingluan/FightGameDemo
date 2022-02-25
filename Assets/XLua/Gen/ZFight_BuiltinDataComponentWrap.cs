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
    public class ZFightBuiltinDataComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.BuiltinDataComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitBuildInfo", _m_InitBuildInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InitDefaultDictionary", _m_InitDefaultDictionary);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "BuildInfo", _g_get_BuildInfo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "UpdateResourceFormTemplate", _g_get_UpdateResourceFormTemplate);
            
			
			
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
					
					var gen_ret = new ZFight.BuiltinDataComponent();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ZFight.BuiltinDataComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitBuildInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.BuiltinDataComponent gen_to_be_invoked = (ZFight.BuiltinDataComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.InitBuildInfo(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitDefaultDictionary(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.BuiltinDataComponent gen_to_be_invoked = (ZFight.BuiltinDataComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.InitDefaultDictionary(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BuildInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuiltinDataComponent gen_to_be_invoked = (ZFight.BuiltinDataComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.BuildInfo);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpdateResourceFormTemplate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ZFight.BuiltinDataComponent gen_to_be_invoked = (ZFight.BuiltinDataComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.UpdateResourceFormTemplate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
