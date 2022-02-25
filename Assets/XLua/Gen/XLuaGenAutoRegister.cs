#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.BaseClass), TutorialBaseClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.TestEnum), TutorialTestEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass), TutorialDerivedClassWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.ICalc), TutorialICalcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClassExtensions), TutorialDerivedClassExtensionsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.LuaBehaviour), XLuaTestLuaBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Pedding), XLuaTestPeddingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.MyStruct), XLuaTestMyStructWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.MyEnum), XLuaTestMyEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.NoGc), XLuaTestNoGcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.WaitForSeconds), UnityEngineWaitForSecondsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.BaseTest), XLuaTestBaseTestWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo1Parent), XLuaTestFoo1ParentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo2Parent), XLuaTestFoo2ParentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo1Child), XLuaTestFoo1ChildWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo2Child), XLuaTestFoo2ChildWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.Foo), XLuaTestFooWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(XLuaTest.FooExtension), XLuaTestFooExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tutorial.DerivedClass.TestEnumInner), TutorialDerivedClassTestEnumInnerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SystemInfo), UnityEngineSystemInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SpriteRenderer), UnityEngineSpriteRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.TimeSpan), SystemTimeSpanWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.DateTime), SystemDateTimeWrap.__Register);
        
        }
        
        static void wrapInit1(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerEventData), UnityEngineEventSystemsPointerEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GUIUtility), UnityEngineGUIUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.AnimationTriggers), UnityEngineUIAnimationTriggersWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button), UnityEngineUIButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasUpdate), UnityEngineUICanvasUpdateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ICanvasElement), UnityEngineUIICanvasElementWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasUpdateRegistry), UnityEngineUICanvasUpdateRegistryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ColorBlock), UnityEngineUIColorBlockWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ClipperRegistry), UnityEngineUIClipperRegistryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Clipping), UnityEngineUIClippingWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.IClipper), UnityEngineUIIClipperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.IClippable), UnityEngineUIIClippableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.DefaultControls), UnityEngineUIDefaultControlsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown), UnityEngineUIDropdownWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.FontData), UnityEngineUIFontDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.FontUpdateTracker), UnityEngineUIFontUpdateTrackerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Graphic), UnityEngineUIGraphicWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRaycaster), UnityEngineUIGraphicRaycasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRegistry), UnityEngineUIGraphicRegistryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.IMaskable), UnityEngineUIIMaskableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image), UnityEngineUIImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField), UnityEngineUIInputFieldWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.AspectRatioFitter), UnityEngineUIAspectRatioFitterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler), UnityEngineUICanvasScalerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ContentSizeFitter), UnityEngineUIContentSizeFitterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup), UnityEngineUIGridLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.HorizontalLayoutGroup), UnityEngineUIHorizontalLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup), UnityEngineUIHorizontalOrVerticalLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutElement), UnityEngineUIILayoutElementWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutController), UnityEngineUIILayoutControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutGroup), UnityEngineUIILayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutSelfController), UnityEngineUIILayoutSelfControllerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ILayoutIgnorer), UnityEngineUIILayoutIgnorerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutElement), UnityEngineUILayoutElementWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutGroup), UnityEngineUILayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutRebuilder), UnityEngineUILayoutRebuilderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.LayoutUtility), UnityEngineUILayoutUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.VerticalLayoutGroup), UnityEngineUIVerticalLayoutGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Mask), UnityEngineUIMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskUtilities), UnityEngineUIMaskUtilitiesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskableGraphic), UnityEngineUIMaskableGraphicWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.IMaterialModifier), UnityEngineUIIMaterialModifierWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Navigation), UnityEngineUINavigationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.RawImage), UnityEngineUIRawImageWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.RectMask2D), UnityEngineUIRectMask2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect), UnityEngineUIScrollRectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar), UnityEngineUIScrollbarWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Selectable), UnityEngineUISelectableWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider), UnityEngineUISliderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.SpriteState), UnityEngineUISpriteStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.StencilMaterial), UnityEngineUIStencilMaterialWrap.__Register);
        
        }
        
        static void wrapInit2(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Text), UnityEngineUITextWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle), UnityEngineUIToggleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ToggleGroup), UnityEngineUIToggleGroupWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.VertexHelper), UnityEngineUIVertexHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.BaseMeshEffect), UnityEngineUIBaseMeshEffectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.IMeshModifier), UnityEngineUIIMeshModifierWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Outline), UnityEngineUIOutlineWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.PositionAsUV1), UnityEngineUIPositionAsUV1Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Shadow), UnityEngineUIShadowWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.AxisEventData), UnityEngineEventSystemsAxisEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.AbstractEventData), UnityEngineEventSystemsAbstractEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseEventData), UnityEngineEventSystemsBaseEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventHandle), UnityEngineEventSystemsEventHandleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IEventSystemHandler), UnityEngineEventSystemsIEventSystemHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerEnterHandler), UnityEngineEventSystemsIPointerEnterHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerExitHandler), UnityEngineEventSystemsIPointerExitHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerDownHandler), UnityEngineEventSystemsIPointerDownHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerUpHandler), UnityEngineEventSystemsIPointerUpHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IPointerClickHandler), UnityEngineEventSystemsIPointerClickHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IBeginDragHandler), UnityEngineEventSystemsIBeginDragHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IInitializePotentialDragHandler), UnityEngineEventSystemsIInitializePotentialDragHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IDragHandler), UnityEngineEventSystemsIDragHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IEndDragHandler), UnityEngineEventSystemsIEndDragHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IDropHandler), UnityEngineEventSystemsIDropHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IScrollHandler), UnityEngineEventSystemsIScrollHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IUpdateSelectedHandler), UnityEngineEventSystemsIUpdateSelectedHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ISelectHandler), UnityEngineEventSystemsISelectHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IDeselectHandler), UnityEngineEventSystemsIDeselectHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.IMoveHandler), UnityEngineEventSystemsIMoveHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ISubmitHandler), UnityEngineEventSystemsISubmitHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ICancelHandler), UnityEngineEventSystemsICancelHandlerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventSystem), UnityEngineEventSystemsEventSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger), UnityEngineEventSystemsEventTriggerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTriggerType), UnityEngineEventSystemsEventTriggerTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.ExecuteEvents), UnityEngineEventSystemsExecuteEventsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseInput), UnityEngineEventSystemsBaseInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseInputModule), UnityEngineEventSystemsBaseInputModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerInputModule), UnityEngineEventSystemsPointerInputModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.StandaloneInputModule), UnityEngineEventSystemsStandaloneInputModuleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.MoveDirection), UnityEngineEventSystemsMoveDirectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.RaycastResult), UnityEngineEventSystemsRaycastResultWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.BaseRaycaster), UnityEngineEventSystemsBaseRaycasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.Physics2DRaycaster), UnityEngineEventSystemsPhysics2DRaycasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PhysicsRaycaster), UnityEngineEventSystemsPhysicsRaycasterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.UIBehaviour), UnityEngineEventSystemsUIBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Button.ButtonClickedEvent), UnityEngineUIButtonButtonClickedEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.DefaultControls.IFactoryControls), UnityEngineUIDefaultControlsIFactoryControlsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.DefaultControls.Resources), UnityEngineUIDefaultControlsResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown.OptionData), UnityEngineUIDropdownOptionDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown.OptionDataList), UnityEngineUIDropdownOptionDataListWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Dropdown.DropdownEvent), UnityEngineUIDropdownDropdownEventWrap.__Register);
        
        }
        
        static void wrapInit3(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GraphicRaycaster.BlockingObjects), UnityEngineUIGraphicRaycasterBlockingObjectsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Type), UnityEngineUIImageTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.FillMethod), UnityEngineUIImageFillMethodWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.OriginHorizontal), UnityEngineUIImageOriginHorizontalWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.OriginVertical), UnityEngineUIImageOriginVerticalWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Origin90), UnityEngineUIImageOrigin90Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Origin180), UnityEngineUIImageOrigin180Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Image.Origin360), UnityEngineUIImageOrigin360Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.ContentType), UnityEngineUIInputFieldContentTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.InputType), UnityEngineUIInputFieldInputTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.CharacterValidation), UnityEngineUIInputFieldCharacterValidationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.LineType), UnityEngineUIInputFieldLineTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.SubmitEvent), UnityEngineUIInputFieldSubmitEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.InputField.OnChangeEvent), UnityEngineUIInputFieldOnChangeEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.AspectRatioFitter.AspectMode), UnityEngineUIAspectRatioFitterAspectModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler.ScaleMode), UnityEngineUICanvasScalerScaleModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler.ScreenMatchMode), UnityEngineUICanvasScalerScreenMatchModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.CanvasScaler.Unit), UnityEngineUICanvasScalerUnitWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ContentSizeFitter.FitMode), UnityEngineUIContentSizeFitterFitModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup.Corner), UnityEngineUIGridLayoutGroupCornerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup.Axis), UnityEngineUIGridLayoutGroupAxisWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.GridLayoutGroup.Constraint), UnityEngineUIGridLayoutGroupConstraintWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent), UnityEngineUIMaskableGraphicCullStateChangedEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Navigation.Mode), UnityEngineUINavigationModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect.MovementType), UnityEngineUIScrollRectMovementTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect.ScrollbarVisibility), UnityEngineUIScrollRectScrollbarVisibilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent), UnityEngineUIScrollRectScrollRectEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar.Direction), UnityEngineUIScrollbarDirectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Scrollbar.ScrollEvent), UnityEngineUIScrollbarScrollEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Selectable.Transition), UnityEngineUISelectableTransitionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider.Direction), UnityEngineUISliderDirectionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Slider.SliderEvent), UnityEngineUISliderSliderEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle.ToggleTransition), UnityEngineUIToggleToggleTransitionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.UI.Toggle.ToggleEvent), UnityEngineUIToggleToggleEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerEventData.InputButton), UnityEngineEventSystemsPointerEventDataInputButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerEventData.FramePressState), UnityEngineEventSystemsPointerEventDataFramePressStateWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger.TriggerEvent), UnityEngineEventSystemsEventTriggerTriggerEventWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.EventTrigger.Entry), UnityEngineEventSystemsEventTriggerEntryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData), UnityEngineEventSystemsPointerInputModuleMouseButtonEventDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.GameEntry), ZFightGameEntryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ChangeLanguageDebuggerWindow), ZFightChangeLanguageDebuggerWindowWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.HPBarComponent), ZFightHPBarComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.HPBarItem), ZFightHPBarItemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.HPBarItemObject), ZFightHPBarItemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.CSPacketBase), ZFightCSPacketBaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.CSPacketHeader), ZFightCSPacketHeaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.NetworkChannelHelper), ZFightNetworkChannelHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.CSHeartBeat), ZFightCSHeartBeatWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.SCHeartBeat), ZFightSCHeartBeatWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.PacketBase), ZFightPacketBaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.SCHeartBeatHandler), ZFightSCHeartBeatHandlerWrap.__Register);
        
        }
        
        static void wrapInit4(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(ZFight.PacketHandlerBase), ZFightPacketHandlerBaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.PacketHeaderBase), ZFightPacketHeaderBaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.PacketType), ZFightPacketTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.SCPacketBase), ZFightSCPacketBaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.SCPacketHeader), ZFightSCPacketHeaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.HideByBoundary), ZFightHideByBoundaryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ScrollableBackground), ZFightScrollableBackgroundWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.SoundExtension), ZFightSoundExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.BuiltinDataComponent), ZFightBuiltinDataComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.BinaryReaderExtension), ZFightBinaryReaderExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DRAircraft), ZFightDRAircraftWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DRArmor), ZFightDRArmorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DRAsteroid), ZFightDRAsteroidWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DREntity), ZFightDREntityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DRMusic), ZFightDRMusicWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DRScene), ZFightDRSceneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DRSound), ZFightDRSoundWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DRThruster), ZFightDRThrusterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DRUIForm), ZFightDRUIFormWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DRUISound), ZFightDRUISoundWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DRWeapon), ZFightDRWeaponWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DataTableExtension), ZFightDataTableExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Constant), ZFightConstantWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.BuildInfo), ZFightBuildInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ImpactData), ZFightImpactDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.VersionInfo), ZFightVersionInfoWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.CampType), ZFightCampTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.RelationType), ZFightRelationTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.LuaLooper), ZFightLuaLooperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.LuaManager), ZFightLuaManagerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.XmlLocalizationHelper), ZFightXmlLocalizationHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.AIUtility), ZFightAIUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.AssetUtility), ZFightAssetUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.WebUtility), ZFightWebUtilityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.AccessoryObjectData), ZFightAccessoryObjectDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.AircraftData), ZFightAircraftDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ArmorData), ZFightArmorDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.AsteroidData), ZFightAsteroidDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.BulletData), ZFightBulletDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.EffectData), ZFightEffectDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.EntityData), ZFightEntityDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.MyAircraftData), ZFightMyAircraftDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.TargetableObjectData), ZFightTargetableObjectDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ThrusterData), ZFightThrusterDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.WeaponData), ZFightWeaponDataWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.EntityExtension), ZFightEntityExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Aircraft), ZFightAircraftWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Armor), ZFightArmorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Asteroid), ZFightAsteroidWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Bullet), ZFightBulletWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Effect), ZFightEffectWrap.__Register);
        
        }
        
        static void wrapInit5(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(ZFight.Entity), ZFightEntityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.MyAircraft), ZFightMyAircraftWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.TargetableObject), ZFightTargetableObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Thruster), ZFightThrusterWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Weapon), ZFightWeaponWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.GameBase), ZFightGameBaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.GameMode), ZFightGameModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.NomalGame), ZFightNomalGameWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.AboutForm), ZFightAboutFormWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.CommonButton), ZFightCommonButtonWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DialogForm), ZFightDialogFormWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.DialogParams), ZFightDialogParamsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.MenuForm), ZFightMenuFormWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.SettingForm), ZFightSettingFormWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.UGuiForm), ZFightUGuiFormWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.UGuiGroupHelper), ZFightUGuiGroupHelperWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.UIExtension), ZFightUIExtensionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.UIFormId), ZFightUIFormIdWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.UpdateResourceForm), ZFightUpdateResourceFormWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureBase), ZFightProcedureBaseWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureChangeScene), ZFightProcedureChangeSceneWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureCheckResources), ZFightProcedureCheckResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureCheckVersion), ZFightProcedureCheckVersionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureInitResources), ZFightProcedureInitResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureLaunch), ZFightProcedureLaunchWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureLuaLaunch), ZFightProcedureLuaLaunchWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureMain), ZFightProcedureMainWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureMenu), ZFightProcedureMenuWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedurePreload), ZFightProcedurePreloadWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureSplash), ZFightProcedureSplashWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureUpdateResources), ZFightProcedureUpdateResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.ProcedureUpdateVersion), ZFightProcedureUpdateVersionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Constant.AssetPriority), ZFightConstantAssetPriorityWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Constant.Layer), ZFightConstantLayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(ZFight.Constant.Setting), ZFightConstantSettingWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            wrapInit1(luaenv, translator);
            
            wrapInit2(luaenv, translator);
            
            wrapInit3(luaenv, translator);
            
            wrapInit4(luaenv, translator);
            
            wrapInit5(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(XLuaTest.IExchanger), XLuaTestIExchangerBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(Tutorial.CSCallLua.ItfD), TutorialCSCallLuaItfDBridge.__Create);
            
            translator.AddInterfaceBridgeCreator(typeof(XLuaTest.InvokeLua.ICalc), XLuaTestInvokeLuaICalcBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
		delegate System.Nullable<int> __GEN_DELEGATE0( UnityGameFramework.Runtime.SoundComponent soundComponent,  int musicId,  object userData);
		
		delegate void __GEN_DELEGATE1( UnityGameFramework.Runtime.SoundComponent soundComponent);
		
		delegate System.Nullable<int> __GEN_DELEGATE2( UnityGameFramework.Runtime.SoundComponent soundComponent,  int soundId,  ZFight.Entity bindingEntity,  object userData);
		
		delegate System.Nullable<int> __GEN_DELEGATE3( UnityGameFramework.Runtime.SoundComponent soundComponent,  int uiSoundId,  object userData);
		
		delegate bool __GEN_DELEGATE4( UnityGameFramework.Runtime.SoundComponent soundComponent,  string soundGroupName);
		
		delegate void __GEN_DELEGATE5( UnityGameFramework.Runtime.SoundComponent soundComponent,  string soundGroupName,  bool mute);
		
		delegate float __GEN_DELEGATE6( UnityGameFramework.Runtime.SoundComponent soundComponent,  string soundGroupName);
		
		delegate void __GEN_DELEGATE7( UnityGameFramework.Runtime.SoundComponent soundComponent,  string soundGroupName,  float volume);
		
		delegate UnityEngine.Color32 __GEN_DELEGATE8( System.IO.BinaryReader binaryReader);
		
		delegate UnityEngine.Color __GEN_DELEGATE9( System.IO.BinaryReader binaryReader);
		
		delegate System.DateTime __GEN_DELEGATE10( System.IO.BinaryReader binaryReader);
		
		delegate UnityEngine.Quaternion __GEN_DELEGATE11( System.IO.BinaryReader binaryReader);
		
		delegate UnityEngine.Rect __GEN_DELEGATE12( System.IO.BinaryReader binaryReader);
		
		delegate UnityEngine.Vector2 __GEN_DELEGATE13( System.IO.BinaryReader binaryReader);
		
		delegate UnityEngine.Vector3 __GEN_DELEGATE14( System.IO.BinaryReader binaryReader);
		
		delegate UnityEngine.Vector4 __GEN_DELEGATE15( System.IO.BinaryReader binaryReader);
		
		delegate void __GEN_DELEGATE16( UnityGameFramework.Runtime.DataTableComponent dataTableComponent,  string dataTableName,  string dataTableAssetName,  object userData);
		
		delegate ZFight.Entity __GEN_DELEGATE17( UnityGameFramework.Runtime.EntityComponent entityComponent,  int entityId);
		
		delegate void __GEN_DELEGATE18( UnityGameFramework.Runtime.EntityComponent entityComponent,  ZFight.Entity entity);
		
		delegate void __GEN_DELEGATE19( UnityGameFramework.Runtime.EntityComponent entityComponent,  ZFight.Entity entity,  int ownerId,  string parentTransformPath,  object userData);
		
		delegate void __GEN_DELEGATE20( UnityGameFramework.Runtime.EntityComponent entityComponent,  ZFight.MyAircraftData data);
		
		delegate void __GEN_DELEGATE21( UnityGameFramework.Runtime.EntityComponent entityComponent,  ZFight.AircraftData data);
		
		delegate void __GEN_DELEGATE22( UnityGameFramework.Runtime.EntityComponent entityComponent,  ZFight.ThrusterData data);
		
		delegate void __GEN_DELEGATE23( UnityGameFramework.Runtime.EntityComponent entityComponent,  ZFight.WeaponData data);
		
		delegate void __GEN_DELEGATE24( UnityGameFramework.Runtime.EntityComponent entityComponent,  ZFight.ArmorData data);
		
		delegate void __GEN_DELEGATE25( UnityGameFramework.Runtime.EntityComponent entityCompoennt,  ZFight.BulletData data);
		
		delegate void __GEN_DELEGATE26( UnityGameFramework.Runtime.EntityComponent entityCompoennt,  ZFight.AsteroidData data);
		
		delegate void __GEN_DELEGATE27( UnityGameFramework.Runtime.EntityComponent entityComponent,  ZFight.EffectData data);
		
		delegate int __GEN_DELEGATE28( UnityGameFramework.Runtime.EntityComponent entityComponent);
		
		delegate System.Collections.IEnumerator __GEN_DELEGATE29( UnityEngine.CanvasGroup canvasGroup,  float alpha,  float duration);
		
		delegate bool __GEN_DELEGATE30( UnityGameFramework.Runtime.UIComponent uiComponent,  ZFight.UIFormId uiFormId,  string uiGroupName);
		
		delegate bool __GEN_DELEGATE31( UnityGameFramework.Runtime.UIComponent uiComponent,  int uiFormId,  string uiGroupName);
		
		delegate ZFight.UGuiForm __GEN_DELEGATE32( UnityGameFramework.Runtime.UIComponent uiComponent,  ZFight.UIFormId uiFormId,  string uiGroupName);
		
		delegate ZFight.UGuiForm __GEN_DELEGATE33( UnityGameFramework.Runtime.UIComponent uiComponent,  int uiFormId,  string uiGroupName);
		
		delegate void __GEN_DELEGATE34( UnityGameFramework.Runtime.UIComponent uiComponent,  ZFight.UGuiForm uiForm);
		
		delegate System.Nullable<int> __GEN_DELEGATE35( UnityGameFramework.Runtime.UIComponent uiComponent,  ZFight.UIFormId uiFormId,  object userData);
		
		delegate System.Nullable<int> __GEN_DELEGATE36( UnityGameFramework.Runtime.UIComponent uiComponent,  int uiFormId,  object userData);
		
		delegate void __GEN_DELEGATE37( UnityGameFramework.Runtime.UIComponent uiComponent,  ZFight.DialogParams dialogParams);
		
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
				{typeof(UnityGameFramework.Runtime.SoundComponent), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE0(ZFight.SoundExtension.PlayMusic)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE1(ZFight.SoundExtension.StopMusic)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE2(ZFight.SoundExtension.PlaySound)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE3(ZFight.SoundExtension.PlayUISound)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE4(ZFight.SoundExtension.IsMuted)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE5(ZFight.SoundExtension.Mute)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE6(ZFight.SoundExtension.GetVolume)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE7(ZFight.SoundExtension.SetVolume)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(System.IO.BinaryReader), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE8(ZFight.BinaryReaderExtension.ReadColor32)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE9(ZFight.BinaryReaderExtension.ReadColor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE10(ZFight.BinaryReaderExtension.ReadDateTime)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE11(ZFight.BinaryReaderExtension.ReadQuaternion)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE12(ZFight.BinaryReaderExtension.ReadRect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE13(ZFight.BinaryReaderExtension.ReadVector2)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE14(ZFight.BinaryReaderExtension.ReadVector3)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE15(ZFight.BinaryReaderExtension.ReadVector4)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityGameFramework.Runtime.DataTableComponent), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE16(ZFight.DataTableExtension.LoadDataTable)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityGameFramework.Runtime.EntityComponent), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE17(ZFight.EntityExtension.GetGameEntity)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE18(ZFight.EntityExtension.HideEntity)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE19(ZFight.EntityExtension.AttachEntity)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE20(ZFight.EntityExtension.ShowMyAircraft)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE21(ZFight.EntityExtension.ShowAircraft)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE22(ZFight.EntityExtension.ShowThruster)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE23(ZFight.EntityExtension.ShowWeapon)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE24(ZFight.EntityExtension.ShowArmor)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE25(ZFight.EntityExtension.ShowBullet)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE26(ZFight.EntityExtension.ShowAsteroid)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE27(ZFight.EntityExtension.ShowEffect)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE28(ZFight.EntityExtension.GenerateSerialId)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityEngine.CanvasGroup), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE29(ZFight.UIExtension.FadeToAlpha)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(UnityGameFramework.Runtime.UIComponent), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE30(ZFight.UIExtension.HasUIForm)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE31(ZFight.UIExtension.HasUIForm)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE32(ZFight.UIExtension.GetUIForm)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE33(ZFight.UIExtension.GetUIForm)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE34(ZFight.UIExtension.CloseUIForm)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE35(ZFight.UIExtension.OpenUIForm)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE36(ZFight.UIExtension.OpenUIForm)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE37(ZFight.UIExtension.OpenDialog)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
