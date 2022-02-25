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
    public class ZFightConstantAssetPriorityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ZFight.Constant.AssetPriority);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 18, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConfigAsset", ZFight.Constant.AssetPriority.ConfigAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DataTableAsset", ZFight.Constant.AssetPriority.DataTableAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DictionaryAsset", ZFight.Constant.AssetPriority.DictionaryAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FontAsset", ZFight.Constant.AssetPriority.FontAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MusicAsset", ZFight.Constant.AssetPriority.MusicAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SceneAsset", ZFight.Constant.AssetPriority.SceneAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SoundAsset", ZFight.Constant.AssetPriority.SoundAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UIFormAsset", ZFight.Constant.AssetPriority.UIFormAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UISoundAsset", ZFight.Constant.AssetPriority.UISoundAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MyAircraftAsset", ZFight.Constant.AssetPriority.MyAircraftAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AircraftAsset", ZFight.Constant.AssetPriority.AircraftAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ThrusterAsset", ZFight.Constant.AssetPriority.ThrusterAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WeaponAsset", ZFight.Constant.AssetPriority.WeaponAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ArmorAsset", ZFight.Constant.AssetPriority.ArmorAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BulletAsset", ZFight.Constant.AssetPriority.BulletAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AsteroiAsset", ZFight.Constant.AssetPriority.AsteroiAsset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EffectAsset", ZFight.Constant.AssetPriority.EffectAsset);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "ZFight.Constant.AssetPriority does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
