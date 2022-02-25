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
    public class ZFightSettingFormWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.SettingForm);
			Utils.BeginObjectRegister(type, L, translator, 0, 11, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnMusicMuteChanged", _m_OnMusicMuteChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnMusicVolumeChanged", _m_OnMusicVolumeChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSoundMuteChanged", _m_OnSoundMuteChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSoundVolumeChanged", _m_OnSoundVolumeChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUISoundMuteChanged", _m_OnUISoundMuteChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnUISoundVolumeChanged", _m_OnUISoundVolumeChanged);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnEnglishSelected", _m_OnEnglishSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnChineseSimplifiedSelected", _m_OnChineseSimplifiedSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnChineseTraditionalSelected", _m_OnChineseTraditionalSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnKoreanSelected", _m_OnKoreanSelected);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnSubmitButtonClick", _m_OnSubmitButtonClick);
			
			
			
			
			
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
					
					var gen_ret = new ZFight.SettingForm();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ZFight.SettingForm constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnMusicMuteChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isOn = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.OnMusicMuteChanged( _isOn );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnMusicVolumeChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _volume = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.OnMusicVolumeChanged( _volume );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnSoundMuteChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isOn = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.OnSoundMuteChanged( _isOn );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnSoundVolumeChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _volume = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.OnSoundVolumeChanged( _volume );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnUISoundMuteChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isOn = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.OnUISoundMuteChanged( _isOn );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnUISoundVolumeChanged(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _volume = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.OnUISoundVolumeChanged( _volume );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnEnglishSelected(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isOn = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.OnEnglishSelected( _isOn );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnChineseSimplifiedSelected(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isOn = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.OnChineseSimplifiedSelected( _isOn );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnChineseTraditionalSelected(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isOn = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.OnChineseTraditionalSelected( _isOn );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnKoreanSelected(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isOn = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.OnKoreanSelected( _isOn );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnSubmitButtonClick(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ZFight.SettingForm gen_to_be_invoked = (ZFight.SettingForm)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnSubmitButtonClick(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
