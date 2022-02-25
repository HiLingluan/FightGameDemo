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
    public class ZFightAssetUtilityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.AssetUtility);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetConfigAsset", _m_GetConfigAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDataTableAsset", _m_GetDataTableAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDictionaryAsset", _m_GetDictionaryAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetFontAsset", _m_GetFontAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSceneAsset", _m_GetSceneAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMusicAsset", _m_GetMusicAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSoundAsset", _m_GetSoundAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetEntityAsset", _m_GetEntityAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUIFormAsset", _m_GetUIFormAsset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUISoundAsset", _m_GetUISoundAsset_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ZFight.AssetUtility does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetConfigAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 1);
                    bool _fromBytes = LuaAPI.lua_toboolean(L, 2);
                    
                        var gen_ret = ZFight.AssetUtility.GetConfigAsset( _assetName, _fromBytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDataTableAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 1);
                    bool _fromBytes = LuaAPI.lua_toboolean(L, 2);
                    
                        var gen_ret = ZFight.AssetUtility.GetDataTableAsset( _assetName, _fromBytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDictionaryAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 1);
                    bool _fromBytes = LuaAPI.lua_toboolean(L, 2);
                    
                        var gen_ret = ZFight.AssetUtility.GetDictionaryAsset( _assetName, _fromBytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFontAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = ZFight.AssetUtility.GetFontAsset( _assetName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSceneAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = ZFight.AssetUtility.GetSceneAsset( _assetName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMusicAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = ZFight.AssetUtility.GetMusicAsset( _assetName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSoundAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = ZFight.AssetUtility.GetSoundAsset( _assetName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEntityAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = ZFight.AssetUtility.GetEntityAsset( _assetName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUIFormAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = ZFight.AssetUtility.GetUIFormAsset( _assetName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUISoundAsset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = ZFight.AssetUtility.GetUISoundAsset( _assetName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
