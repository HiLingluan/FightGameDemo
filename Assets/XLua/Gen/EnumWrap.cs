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
    
    public class TutorialTestEnumWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Tutorial.TestEnum), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Tutorial.TestEnum), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Tutorial.TestEnum), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E1", Tutorial.TestEnum.E1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E2", Tutorial.TestEnum.E2);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Tutorial.TestEnum), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushTutorialTestEnum(L, (Tutorial.TestEnum)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "E1"))
                {
                    translator.PushTutorialTestEnum(L, Tutorial.TestEnum.E1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E2"))
                {
                    translator.PushTutorialTestEnum(L, Tutorial.TestEnum.E2);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Tutorial.TestEnum!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Tutorial.TestEnum! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XLuaTestMyEnumWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XLuaTest.MyEnum), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XLuaTest.MyEnum), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XLuaTest.MyEnum), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E1", XLuaTest.MyEnum.E1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E2", XLuaTest.MyEnum.E2);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XLuaTest.MyEnum), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXLuaTestMyEnum(L, (XLuaTest.MyEnum)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "E1"))
                {
                    translator.PushXLuaTestMyEnum(L, XLuaTest.MyEnum.E1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E2"))
                {
                    translator.PushXLuaTestMyEnum(L, XLuaTest.MyEnum.E2);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XLuaTest.MyEnum!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XLuaTest.MyEnum! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class TutorialDerivedClassTestEnumInnerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E3", Tutorial.DerivedClass.TestEnumInner.E3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E4", Tutorial.DerivedClass.TestEnumInner.E4);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushTutorialDerivedClassTestEnumInner(L, (Tutorial.DerivedClass.TestEnumInner)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "E3"))
                {
                    translator.PushTutorialDerivedClassTestEnumInner(L, Tutorial.DerivedClass.TestEnumInner.E3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E4"))
                {
                    translator.PushTutorialDerivedClassTestEnumInner(L, Tutorial.DerivedClass.TestEnumInner.E4);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Tutorial.DerivedClass.TestEnumInner!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Tutorial.DerivedClass.TestEnumInner! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasUpdateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasUpdate), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasUpdate), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasUpdate), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Prelayout", UnityEngine.UI.CanvasUpdate.Prelayout);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Layout", UnityEngine.UI.CanvasUpdate.Layout);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PostLayout", UnityEngine.UI.CanvasUpdate.PostLayout);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PreRender", UnityEngine.UI.CanvasUpdate.PreRender);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LatePreRender", UnityEngine.UI.CanvasUpdate.LatePreRender);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxUpdateValue", UnityEngine.UI.CanvasUpdate.MaxUpdateValue);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasUpdate), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasUpdate(L, (UnityEngine.UI.CanvasUpdate)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Prelayout"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.Prelayout);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Layout"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.Layout);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PostLayout"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.PostLayout);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PreRender"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.PreRender);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LatePreRender"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.LatePreRender);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaxUpdateValue"))
                {
                    translator.PushUnityEngineUICanvasUpdate(L, UnityEngine.UI.CanvasUpdate.MaxUpdateValue);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasUpdate!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasUpdate! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEventSystemsEventHandleWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.EventHandle), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.EventHandle), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.EventHandle), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unused", UnityEngine.EventSystems.EventHandle.Unused);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Used", UnityEngine.EventSystems.EventHandle.Used);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EventSystems.EventHandle), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEventSystemsEventHandle(L, (UnityEngine.EventSystems.EventHandle)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unused"))
                {
                    translator.PushUnityEngineEventSystemsEventHandle(L, UnityEngine.EventSystems.EventHandle.Unused);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Used"))
                {
                    translator.PushUnityEngineEventSystemsEventHandle(L, UnityEngine.EventSystems.EventHandle.Used);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EventSystems.EventHandle!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EventSystems.EventHandle! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEventSystemsEventTriggerTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.EventTriggerType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.EventTriggerType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.EventTriggerType), L, null, 18, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PointerEnter", UnityEngine.EventSystems.EventTriggerType.PointerEnter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PointerExit", UnityEngine.EventSystems.EventTriggerType.PointerExit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PointerDown", UnityEngine.EventSystems.EventTriggerType.PointerDown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PointerUp", UnityEngine.EventSystems.EventTriggerType.PointerUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PointerClick", UnityEngine.EventSystems.EventTriggerType.PointerClick);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Drag", UnityEngine.EventSystems.EventTriggerType.Drag);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Drop", UnityEngine.EventSystems.EventTriggerType.Drop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Scroll", UnityEngine.EventSystems.EventTriggerType.Scroll);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpdateSelected", UnityEngine.EventSystems.EventTriggerType.UpdateSelected);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Select", UnityEngine.EventSystems.EventTriggerType.Select);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Deselect", UnityEngine.EventSystems.EventTriggerType.Deselect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Move", UnityEngine.EventSystems.EventTriggerType.Move);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InitializePotentialDrag", UnityEngine.EventSystems.EventTriggerType.InitializePotentialDrag);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BeginDrag", UnityEngine.EventSystems.EventTriggerType.BeginDrag);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EndDrag", UnityEngine.EventSystems.EventTriggerType.EndDrag);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Submit", UnityEngine.EventSystems.EventTriggerType.Submit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Cancel", UnityEngine.EventSystems.EventTriggerType.Cancel);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EventSystems.EventTriggerType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEventSystemsEventTriggerType(L, (UnityEngine.EventSystems.EventTriggerType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "PointerEnter"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.PointerEnter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PointerExit"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.PointerExit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PointerDown"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.PointerDown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PointerUp"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.PointerUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PointerClick"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.PointerClick);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Drag"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Drag);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Drop"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Drop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Scroll"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Scroll);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpdateSelected"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.UpdateSelected);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Select"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Select);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Deselect"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Deselect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Move"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Move);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InitializePotentialDrag"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.InitializePotentialDrag);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BeginDrag"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.BeginDrag);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EndDrag"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.EndDrag);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Submit"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Submit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Cancel"))
                {
                    translator.PushUnityEngineEventSystemsEventTriggerType(L, UnityEngine.EventSystems.EventTriggerType.Cancel);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EventSystems.EventTriggerType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EventSystems.EventTriggerType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEventSystemsMoveDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.MoveDirection), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.MoveDirection), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.MoveDirection), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.EventSystems.MoveDirection.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Up", UnityEngine.EventSystems.MoveDirection.Up);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.EventSystems.MoveDirection.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Down", UnityEngine.EventSystems.MoveDirection.Down);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.EventSystems.MoveDirection.None);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EventSystems.MoveDirection), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEventSystemsMoveDirection(L, (UnityEngine.EventSystems.MoveDirection)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineEventSystemsMoveDirection(L, UnityEngine.EventSystems.MoveDirection.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Up"))
                {
                    translator.PushUnityEngineEventSystemsMoveDirection(L, UnityEngine.EventSystems.MoveDirection.Up);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineEventSystemsMoveDirection(L, UnityEngine.EventSystems.MoveDirection.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Down"))
                {
                    translator.PushUnityEngineEventSystemsMoveDirection(L, UnityEngine.EventSystems.MoveDirection.Down);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineEventSystemsMoveDirection(L, UnityEngine.EventSystems.MoveDirection.None);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EventSystems.MoveDirection!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EventSystems.MoveDirection! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGraphicRaycasterBlockingObjectsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.GraphicRaycaster.BlockingObjects.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TwoD", UnityEngine.UI.GraphicRaycaster.BlockingObjects.TwoD);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ThreeD", UnityEngine.UI.GraphicRaycaster.BlockingObjects.ThreeD);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "All", UnityEngine.UI.GraphicRaycaster.BlockingObjects.All);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, (UnityEngine.UI.GraphicRaycaster.BlockingObjects)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, UnityEngine.UI.GraphicRaycaster.BlockingObjects.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TwoD"))
                {
                    translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, UnityEngine.UI.GraphicRaycaster.BlockingObjects.TwoD);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ThreeD"))
                {
                    translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, UnityEngine.UI.GraphicRaycaster.BlockingObjects.ThreeD);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "All"))
                {
                    translator.PushUnityEngineUIGraphicRaycasterBlockingObjects(L, UnityEngine.UI.GraphicRaycaster.BlockingObjects.All);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GraphicRaycaster.BlockingObjects!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GraphicRaycaster.BlockingObjects! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Type), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Type), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Type), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Simple", UnityEngine.UI.Image.Type.Simple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sliced", UnityEngine.UI.Image.Type.Sliced);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tiled", UnityEngine.UI.Image.Type.Tiled);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Filled", UnityEngine.UI.Image.Type.Filled);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Type), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageType(L, (UnityEngine.UI.Image.Type)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Simple"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Simple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sliced"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Sliced);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tiled"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Tiled);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Filled"))
                {
                    translator.PushUnityEngineUIImageType(L, UnityEngine.UI.Image.Type.Filled);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Type!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Type! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageFillMethodWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.FillMethod), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.FillMethod), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.FillMethod), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.UI.Image.FillMethod.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.UI.Image.FillMethod.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial90", UnityEngine.UI.Image.FillMethod.Radial90);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial180", UnityEngine.UI.Image.FillMethod.Radial180);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial360", UnityEngine.UI.Image.FillMethod.Radial360);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.FillMethod), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageFillMethod(L, (UnityEngine.UI.Image.FillMethod)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial90"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Radial90);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial180"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Radial180);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial360"))
                {
                    translator.PushUnityEngineUIImageFillMethod(L, UnityEngine.UI.Image.FillMethod.Radial360);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.FillMethod!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.FillMethod! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOriginHorizontalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.UI.Image.OriginHorizontal.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.UI.Image.OriginHorizontal.Right);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.OriginHorizontal), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOriginHorizontal(L, (UnityEngine.UI.Image.OriginHorizontal)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineUIImageOriginHorizontal(L, UnityEngine.UI.Image.OriginHorizontal.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineUIImageOriginHorizontal(L, UnityEngine.UI.Image.OriginHorizontal.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.OriginHorizontal!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.OriginHorizontal! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOriginVerticalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.UI.Image.OriginVertical.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.UI.Image.OriginVertical.Top);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.OriginVertical), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOriginVertical(L, (UnityEngine.UI.Image.OriginVertical)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineUIImageOriginVertical(L, UnityEngine.UI.Image.OriginVertical.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineUIImageOriginVertical(L, UnityEngine.UI.Image.OriginVertical.Top);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.OriginVertical!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.OriginVertical! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOrigin90Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Origin90), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Origin90), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Origin90), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomLeft", UnityEngine.UI.Image.Origin90.BottomLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopLeft", UnityEngine.UI.Image.Origin90.TopLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopRight", UnityEngine.UI.Image.Origin90.TopRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomRight", UnityEngine.UI.Image.Origin90.BottomRight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Origin90), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOrigin90(L, (UnityEngine.UI.Image.Origin90)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "BottomLeft"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.BottomLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopLeft"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.TopLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopRight"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.TopRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomRight"))
                {
                    translator.PushUnityEngineUIImageOrigin90(L, UnityEngine.UI.Image.Origin90.BottomRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Origin90!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Origin90! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOrigin180Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Origin180), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Origin180), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Origin180), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.UI.Image.Origin180.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.UI.Image.Origin180.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.UI.Image.Origin180.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.UI.Image.Origin180.Right);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Origin180), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOrigin180(L, (UnityEngine.UI.Image.Origin180)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineUIImageOrigin180(L, UnityEngine.UI.Image.Origin180.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Origin180!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Origin180! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIImageOrigin360Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Image.Origin360), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Image.Origin360), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Image.Origin360), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", UnityEngine.UI.Image.Origin360.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.UI.Image.Origin360.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UnityEngine.UI.Image.Origin360.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.UI.Image.Origin360.Left);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Image.Origin360), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIImageOrigin360(L, (UnityEngine.UI.Image.Origin360)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineUIImageOrigin360(L, UnityEngine.UI.Image.Origin360.Left);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Image.Origin360!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Image.Origin360! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldContentTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.ContentType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.ContentType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.ContentType), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Standard", UnityEngine.UI.InputField.ContentType.Standard);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Autocorrected", UnityEngine.UI.InputField.ContentType.Autocorrected);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IntegerNumber", UnityEngine.UI.InputField.ContentType.IntegerNumber);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DecimalNumber", UnityEngine.UI.InputField.ContentType.DecimalNumber);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alphanumeric", UnityEngine.UI.InputField.ContentType.Alphanumeric);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Name", UnityEngine.UI.InputField.ContentType.Name);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EmailAddress", UnityEngine.UI.InputField.ContentType.EmailAddress);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Password", UnityEngine.UI.InputField.ContentType.Password);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pin", UnityEngine.UI.InputField.ContentType.Pin);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", UnityEngine.UI.InputField.ContentType.Custom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.ContentType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldContentType(L, (UnityEngine.UI.InputField.ContentType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Standard"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Standard);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Autocorrected"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Autocorrected);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IntegerNumber"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.IntegerNumber);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DecimalNumber"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.DecimalNumber);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alphanumeric"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Alphanumeric);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Name"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Name);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EmailAddress"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.EmailAddress);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Password"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Password);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pin"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Pin);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom"))
                {
                    translator.PushUnityEngineUIInputFieldContentType(L, UnityEngine.UI.InputField.ContentType.Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.ContentType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.ContentType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldInputTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.InputType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.InputType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.InputType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Standard", UnityEngine.UI.InputField.InputType.Standard);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoCorrect", UnityEngine.UI.InputField.InputType.AutoCorrect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Password", UnityEngine.UI.InputField.InputType.Password);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.InputType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldInputType(L, (UnityEngine.UI.InputField.InputType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Standard"))
                {
                    translator.PushUnityEngineUIInputFieldInputType(L, UnityEngine.UI.InputField.InputType.Standard);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoCorrect"))
                {
                    translator.PushUnityEngineUIInputFieldInputType(L, UnityEngine.UI.InputField.InputType.AutoCorrect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Password"))
                {
                    translator.PushUnityEngineUIInputFieldInputType(L, UnityEngine.UI.InputField.InputType.Password);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.InputType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.InputType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldCharacterValidationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.InputField.CharacterValidation.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Integer", UnityEngine.UI.InputField.CharacterValidation.Integer);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Decimal", UnityEngine.UI.InputField.CharacterValidation.Decimal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alphanumeric", UnityEngine.UI.InputField.CharacterValidation.Alphanumeric);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Name", UnityEngine.UI.InputField.CharacterValidation.Name);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EmailAddress", UnityEngine.UI.InputField.CharacterValidation.EmailAddress);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.CharacterValidation), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldCharacterValidation(L, (UnityEngine.UI.InputField.CharacterValidation)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Integer"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Integer);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Decimal"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Decimal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alphanumeric"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Alphanumeric);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Name"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.Name);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EmailAddress"))
                {
                    translator.PushUnityEngineUIInputFieldCharacterValidation(L, UnityEngine.UI.InputField.CharacterValidation.EmailAddress);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.CharacterValidation!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.CharacterValidation! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIInputFieldLineTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.InputField.LineType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.InputField.LineType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.InputField.LineType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SingleLine", UnityEngine.UI.InputField.LineType.SingleLine);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MultiLineSubmit", UnityEngine.UI.InputField.LineType.MultiLineSubmit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MultiLineNewline", UnityEngine.UI.InputField.LineType.MultiLineNewline);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.InputField.LineType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIInputFieldLineType(L, (UnityEngine.UI.InputField.LineType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "SingleLine"))
                {
                    translator.PushUnityEngineUIInputFieldLineType(L, UnityEngine.UI.InputField.LineType.SingleLine);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MultiLineSubmit"))
                {
                    translator.PushUnityEngineUIInputFieldLineType(L, UnityEngine.UI.InputField.LineType.MultiLineSubmit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MultiLineNewline"))
                {
                    translator.PushUnityEngineUIInputFieldLineType(L, UnityEngine.UI.InputField.LineType.MultiLineNewline);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.InputField.LineType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.InputField.LineType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIAspectRatioFitterAspectModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.AspectRatioFitter.AspectMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WidthControlsHeight", UnityEngine.UI.AspectRatioFitter.AspectMode.WidthControlsHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HeightControlsWidth", UnityEngine.UI.AspectRatioFitter.AspectMode.HeightControlsWidth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FitInParent", UnityEngine.UI.AspectRatioFitter.AspectMode.FitInParent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EnvelopeParent", UnityEngine.UI.AspectRatioFitter.AspectMode.EnvelopeParent);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, (UnityEngine.UI.AspectRatioFitter.AspectMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WidthControlsHeight"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.WidthControlsHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HeightControlsWidth"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.HeightControlsWidth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FitInParent"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.FitInParent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EnvelopeParent"))
                {
                    translator.PushUnityEngineUIAspectRatioFitterAspectMode(L, UnityEngine.UI.AspectRatioFitter.AspectMode.EnvelopeParent);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.AspectRatioFitter.AspectMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.AspectRatioFitter.AspectMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerScaleModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPixelSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleWithScreenSize", UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPhysicalSize", UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerScaleMode(L, (UnityEngine.UI.CanvasScaler.ScaleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPixelSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPixelSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleWithScreenSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPhysicalSize"))
                {
                    translator.PushUnityEngineUICanvasScalerScaleMode(L, UnityEngine.UI.CanvasScaler.ScaleMode.ConstantPhysicalSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScaleMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScaleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerScreenMatchModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchWidthOrHeight", UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Expand", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shrink", UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, (UnityEngine.UI.CanvasScaler.ScreenMatchMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "MatchWidthOrHeight"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.MatchWidthOrHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Expand"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Expand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shrink"))
                {
                    translator.PushUnityEngineUICanvasScalerScreenMatchMode(L, UnityEngine.UI.CanvasScaler.ScreenMatchMode.Shrink);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.ScreenMatchMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.ScreenMatchMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUICanvasScalerUnitWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Centimeters", UnityEngine.UI.CanvasScaler.Unit.Centimeters);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Millimeters", UnityEngine.UI.CanvasScaler.Unit.Millimeters);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Inches", UnityEngine.UI.CanvasScaler.Unit.Inches);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Points", UnityEngine.UI.CanvasScaler.Unit.Points);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Picas", UnityEngine.UI.CanvasScaler.Unit.Picas);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.CanvasScaler.Unit), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUICanvasScalerUnit(L, (UnityEngine.UI.CanvasScaler.Unit)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Centimeters"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Centimeters);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Millimeters"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Millimeters);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Inches"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Inches);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Points"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Points);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Picas"))
                {
                    translator.PushUnityEngineUICanvasScalerUnit(L, UnityEngine.UI.CanvasScaler.Unit.Picas);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.CanvasScaler.Unit!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.CanvasScaler.Unit! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIContentSizeFitterFitModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unconstrained", UnityEngine.UI.ContentSizeFitter.FitMode.Unconstrained);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MinSize", UnityEngine.UI.ContentSizeFitter.FitMode.MinSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PreferredSize", UnityEngine.UI.ContentSizeFitter.FitMode.PreferredSize);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIContentSizeFitterFitMode(L, (UnityEngine.UI.ContentSizeFitter.FitMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unconstrained"))
                {
                    translator.PushUnityEngineUIContentSizeFitterFitMode(L, UnityEngine.UI.ContentSizeFitter.FitMode.Unconstrained);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MinSize"))
                {
                    translator.PushUnityEngineUIContentSizeFitterFitMode(L, UnityEngine.UI.ContentSizeFitter.FitMode.MinSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PreferredSize"))
                {
                    translator.PushUnityEngineUIContentSizeFitterFitMode(L, UnityEngine.UI.ContentSizeFitter.FitMode.PreferredSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.ContentSizeFitter.FitMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.ContentSizeFitter.FitMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupCornerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperLeft", UnityEngine.UI.GridLayoutGroup.Corner.UpperLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpperRight", UnityEngine.UI.GridLayoutGroup.Corner.UpperRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerLeft", UnityEngine.UI.GridLayoutGroup.Corner.LowerLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LowerRight", UnityEngine.UI.GridLayoutGroup.Corner.LowerRight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Corner), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupCorner(L, (UnityEngine.UI.GridLayoutGroup.Corner)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "UpperLeft"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.UpperLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpperRight"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.UpperRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerLeft"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.LowerLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LowerRight"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupCorner(L, UnityEngine.UI.GridLayoutGroup.Corner.LowerRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Corner!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Corner! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupAxisWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.UI.GridLayoutGroup.Axis.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.UI.GridLayoutGroup.Axis.Vertical);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Axis), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupAxis(L, (UnityEngine.UI.GridLayoutGroup.Axis)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupAxis(L, UnityEngine.UI.GridLayoutGroup.Axis.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupAxis(L, UnityEngine.UI.GridLayoutGroup.Axis.Vertical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Axis!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Axis! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIGridLayoutGroupConstraintWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Flexible", UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FixedColumnCount", UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FixedRowCount", UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIGridLayoutGroupConstraint(L, (UnityEngine.UI.GridLayoutGroup.Constraint)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Flexible"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.Flexible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FixedColumnCount"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.FixedColumnCount);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FixedRowCount"))
                {
                    translator.PushUnityEngineUIGridLayoutGroupConstraint(L, UnityEngine.UI.GridLayoutGroup.Constraint.FixedRowCount);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.GridLayoutGroup.Constraint!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.GridLayoutGroup.Constraint! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUINavigationModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Navigation.Mode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Navigation.Mode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Navigation.Mode), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.Navigation.Mode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", UnityEngine.UI.Navigation.Mode.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", UnityEngine.UI.Navigation.Mode.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Automatic", UnityEngine.UI.Navigation.Mode.Automatic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Explicit", UnityEngine.UI.Navigation.Mode.Explicit);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Navigation.Mode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUINavigationMode(L, (UnityEngine.UI.Navigation.Mode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Automatic"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Automatic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Explicit"))
                {
                    translator.PushUnityEngineUINavigationMode(L, UnityEngine.UI.Navigation.Mode.Explicit);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Navigation.Mode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Navigation.Mode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIScrollRectMovementTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unrestricted", UnityEngine.UI.ScrollRect.MovementType.Unrestricted);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Elastic", UnityEngine.UI.ScrollRect.MovementType.Elastic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Clamped", UnityEngine.UI.ScrollRect.MovementType.Clamped);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.ScrollRect.MovementType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIScrollRectMovementType(L, (UnityEngine.UI.ScrollRect.MovementType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unrestricted"))
                {
                    translator.PushUnityEngineUIScrollRectMovementType(L, UnityEngine.UI.ScrollRect.MovementType.Unrestricted);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Elastic"))
                {
                    translator.PushUnityEngineUIScrollRectMovementType(L, UnityEngine.UI.ScrollRect.MovementType.Elastic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Clamped"))
                {
                    translator.PushUnityEngineUIScrollRectMovementType(L, UnityEngine.UI.ScrollRect.MovementType.Clamped);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.ScrollRect.MovementType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.ScrollRect.MovementType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIScrollRectScrollbarVisibilityWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Permanent", UnityEngine.UI.ScrollRect.ScrollbarVisibility.Permanent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoHide", UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHide);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoHideAndExpandViewport", UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, (UnityEngine.UI.ScrollRect.ScrollbarVisibility)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Permanent"))
                {
                    translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, UnityEngine.UI.ScrollRect.ScrollbarVisibility.Permanent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoHide"))
                {
                    translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHide);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoHideAndExpandViewport"))
                {
                    translator.PushUnityEngineUIScrollRectScrollbarVisibility(L, UnityEngine.UI.ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.ScrollRect.ScrollbarVisibility!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.ScrollRect.ScrollbarVisibility! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIScrollbarDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftToRight", UnityEngine.UI.Scrollbar.Direction.LeftToRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightToLeft", UnityEngine.UI.Scrollbar.Direction.RightToLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomToTop", UnityEngine.UI.Scrollbar.Direction.BottomToTop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopToBottom", UnityEngine.UI.Scrollbar.Direction.TopToBottom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Scrollbar.Direction), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIScrollbarDirection(L, (UnityEngine.UI.Scrollbar.Direction)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LeftToRight"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.LeftToRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightToLeft"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.RightToLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomToTop"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.BottomToTop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopToBottom"))
                {
                    translator.PushUnityEngineUIScrollbarDirection(L, UnityEngine.UI.Scrollbar.Direction.TopToBottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Scrollbar.Direction!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Scrollbar.Direction! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUISelectableTransitionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Selectable.Transition), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Selectable.Transition), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Selectable.Transition), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.Selectable.Transition.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ColorTint", UnityEngine.UI.Selectable.Transition.ColorTint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpriteSwap", UnityEngine.UI.Selectable.Transition.SpriteSwap);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Animation", UnityEngine.UI.Selectable.Transition.Animation);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Selectable.Transition), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUISelectableTransition(L, (UnityEngine.UI.Selectable.Transition)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ColorTint"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.ColorTint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpriteSwap"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.SpriteSwap);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Animation"))
                {
                    translator.PushUnityEngineUISelectableTransition(L, UnityEngine.UI.Selectable.Transition.Animation);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Selectable.Transition!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Selectable.Transition! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUISliderDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Slider.Direction), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Slider.Direction), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Slider.Direction), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftToRight", UnityEngine.UI.Slider.Direction.LeftToRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightToLeft", UnityEngine.UI.Slider.Direction.RightToLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomToTop", UnityEngine.UI.Slider.Direction.BottomToTop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopToBottom", UnityEngine.UI.Slider.Direction.TopToBottom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Slider.Direction), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUISliderDirection(L, (UnityEngine.UI.Slider.Direction)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LeftToRight"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.LeftToRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightToLeft"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.RightToLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomToTop"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.BottomToTop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopToBottom"))
                {
                    translator.PushUnityEngineUISliderDirection(L, UnityEngine.UI.Slider.Direction.TopToBottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Slider.Direction!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Slider.Direction! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineUIToggleToggleTransitionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", UnityEngine.UI.Toggle.ToggleTransition.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fade", UnityEngine.UI.Toggle.ToggleTransition.Fade);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.UI.Toggle.ToggleTransition), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineUIToggleToggleTransition(L, (UnityEngine.UI.Toggle.ToggleTransition)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushUnityEngineUIToggleToggleTransition(L, UnityEngine.UI.Toggle.ToggleTransition.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fade"))
                {
                    translator.PushUnityEngineUIToggleToggleTransition(L, UnityEngine.UI.Toggle.ToggleTransition.Fade);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.UI.Toggle.ToggleTransition!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.UI.Toggle.ToggleTransition! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEventSystemsPointerEventDataInputButtonWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.PointerEventData.InputButton), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.PointerEventData.InputButton), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.PointerEventData.InputButton), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", UnityEngine.EventSystems.PointerEventData.InputButton.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", UnityEngine.EventSystems.PointerEventData.InputButton.Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Middle", UnityEngine.EventSystems.PointerEventData.InputButton.Middle);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EventSystems.PointerEventData.InputButton), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEventSystemsPointerEventDataInputButton(L, (UnityEngine.EventSystems.PointerEventData.InputButton)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataInputButton(L, UnityEngine.EventSystems.PointerEventData.InputButton.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataInputButton(L, UnityEngine.EventSystems.PointerEventData.InputButton.Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Middle"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataInputButton(L, UnityEngine.EventSystems.PointerEventData.InputButton.Middle);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EventSystems.PointerEventData.InputButton!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EventSystems.PointerEventData.InputButton! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UnityEngineEventSystemsPointerEventDataFramePressStateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pressed", UnityEngine.EventSystems.PointerEventData.FramePressState.Pressed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Released", UnityEngine.EventSystems.PointerEventData.FramePressState.Released);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PressedAndReleased", UnityEngine.EventSystems.PointerEventData.FramePressState.PressedAndReleased);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotChanged", UnityEngine.EventSystems.PointerEventData.FramePressState.NotChanged);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, (UnityEngine.EventSystems.PointerEventData.FramePressState)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Pressed"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, UnityEngine.EventSystems.PointerEventData.FramePressState.Pressed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Released"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, UnityEngine.EventSystems.PointerEventData.FramePressState.Released);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PressedAndReleased"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, UnityEngine.EventSystems.PointerEventData.FramePressState.PressedAndReleased);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NotChanged"))
                {
                    translator.PushUnityEngineEventSystemsPointerEventDataFramePressState(L, UnityEngine.EventSystems.PointerEventData.FramePressState.NotChanged);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UnityEngine.EventSystems.PointerEventData.FramePressState!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.EventSystems.PointerEventData.FramePressState! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class ZFightPacketTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(ZFight.PacketType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(ZFight.PacketType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(ZFight.PacketType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Undefined", ZFight.PacketType.Undefined);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ClientToServer", ZFight.PacketType.ClientToServer);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ServerToClient", ZFight.PacketType.ServerToClient);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(ZFight.PacketType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushZFightPacketType(L, (ZFight.PacketType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Undefined"))
                {
                    translator.PushZFightPacketType(L, ZFight.PacketType.Undefined);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ClientToServer"))
                {
                    translator.PushZFightPacketType(L, ZFight.PacketType.ClientToServer);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ServerToClient"))
                {
                    translator.PushZFightPacketType(L, ZFight.PacketType.ServerToClient);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for ZFight.PacketType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for ZFight.PacketType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class ZFightCampTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(ZFight.CampType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(ZFight.CampType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(ZFight.CampType), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", ZFight.CampType.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Player", ZFight.CampType.Player);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Enemy", ZFight.CampType.Enemy);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Neutral", ZFight.CampType.Neutral);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Player2", ZFight.CampType.Player2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Enemy2", ZFight.CampType.Enemy2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Neutral2", ZFight.CampType.Neutral2);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(ZFight.CampType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushZFightCampType(L, (ZFight.CampType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushZFightCampType(L, ZFight.CampType.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Player"))
                {
                    translator.PushZFightCampType(L, ZFight.CampType.Player);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Enemy"))
                {
                    translator.PushZFightCampType(L, ZFight.CampType.Enemy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Neutral"))
                {
                    translator.PushZFightCampType(L, ZFight.CampType.Neutral);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Player2"))
                {
                    translator.PushZFightCampType(L, ZFight.CampType.Player2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Enemy2"))
                {
                    translator.PushZFightCampType(L, ZFight.CampType.Enemy2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Neutral2"))
                {
                    translator.PushZFightCampType(L, ZFight.CampType.Neutral2);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for ZFight.CampType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for ZFight.CampType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class ZFightRelationTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(ZFight.RelationType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(ZFight.RelationType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(ZFight.RelationType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", ZFight.RelationType.Unknown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Friendly", ZFight.RelationType.Friendly);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Neutral", ZFight.RelationType.Neutral);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hostile", ZFight.RelationType.Hostile);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(ZFight.RelationType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushZFightRelationType(L, (ZFight.RelationType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushZFightRelationType(L, ZFight.RelationType.Unknown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Friendly"))
                {
                    translator.PushZFightRelationType(L, ZFight.RelationType.Friendly);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Neutral"))
                {
                    translator.PushZFightRelationType(L, ZFight.RelationType.Neutral);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hostile"))
                {
                    translator.PushZFightRelationType(L, ZFight.RelationType.Hostile);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for ZFight.RelationType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for ZFight.RelationType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class ZFightGameModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(ZFight.GameMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(ZFight.GameMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(ZFight.GameMode), L, null, 2, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", ZFight.GameMode.Normal);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(ZFight.GameMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushZFightGameMode(L, (ZFight.GameMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushZFightGameMode(L, ZFight.GameMode.Normal);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for ZFight.GameMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for ZFight.GameMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class ZFightUIFormIdWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(ZFight.UIFormId), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(ZFight.UIFormId), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(ZFight.UIFormId), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Undefined", ZFight.UIFormId.Undefined);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DialogForm", ZFight.UIFormId.DialogForm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MenuForm", ZFight.UIFormId.MenuForm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SettingForm", ZFight.UIFormId.SettingForm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AboutForm", ZFight.UIFormId.AboutForm);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(ZFight.UIFormId), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushZFightUIFormId(L, (ZFight.UIFormId)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Undefined"))
                {
                    translator.PushZFightUIFormId(L, ZFight.UIFormId.Undefined);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DialogForm"))
                {
                    translator.PushZFightUIFormId(L, ZFight.UIFormId.DialogForm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MenuForm"))
                {
                    translator.PushZFightUIFormId(L, ZFight.UIFormId.MenuForm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SettingForm"))
                {
                    translator.PushZFightUIFormId(L, ZFight.UIFormId.SettingForm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AboutForm"))
                {
                    translator.PushZFightUIFormId(L, ZFight.UIFormId.AboutForm);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for ZFight.UIFormId!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for ZFight.UIFormId! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}