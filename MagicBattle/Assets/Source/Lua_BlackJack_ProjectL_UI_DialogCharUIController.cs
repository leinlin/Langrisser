using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001415 RID: 5141
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DialogCharUIController : LuaObject
{
	// Token: 0x0601D11B RID: 119067 RVA: 0x00921FBC File Offset: 0x009201BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGraphic(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			dialogCharUIController.CreateGraphic(charImageInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D11C RID: 119068 RVA: 0x00922014 File Offset: 0x00920214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyGraphic(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			dialogCharUIController.DestroyGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D11D RID: 119069 RVA: 0x00922060 File Offset: 0x00920260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetScaleOffet(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			float scale;
			LuaObject.checkType(l, 2, out scale);
			float yOffset;
			LuaObject.checkType(l, 3, out yOffset);
			dialogCharUIController.SetScaleOffet(scale, yOffset);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D11E RID: 119070 RVA: 0x009220C4 File Offset: 0x009202C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDirection(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			dialogCharUIController.SetDirection(direction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D11F RID: 119071 RVA: 0x0092211C File Offset: 0x0092031C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetColor(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			Color color;
			LuaObject.checkType(l, 2, out color);
			dialogCharUIController.SetColor(color);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D120 RID: 119072 RVA: 0x00922174 File Offset: 0x00920374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TweenColor(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			Color c;
			LuaObject.checkType(l, 2, out c);
			float time;
			LuaObject.checkType(l, 3, out time);
			dialogCharUIController.TweenColor(c, time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D121 RID: 119073 RVA: 0x009221D8 File Offset: 0x009203D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCharImageInfo(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo = dialogCharUIController.GetCharImageInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, charImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D122 RID: 119074 RVA: 0x0092222C File Offset: 0x0092042C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartFacialAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			float voiceTime;
			LuaObject.checkType(l, 2, out voiceTime);
			dialogCharUIController.StartFacialAnimation(voiceTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D123 RID: 119075 RVA: 0x00922284 File Offset: 0x00920484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Enter(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			int enterType;
			LuaObject.checkType(l, 2, out enterType);
			Action onEndAction;
			LuaObject.checkDelegate<Action>(l, 3, out onEndAction);
			dialogCharUIController.Enter(enterType, onEndAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D124 RID: 119076 RVA: 0x009222E8 File Offset: 0x009204E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Leave(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			int leaveType;
			LuaObject.checkType(l, 2, out leaveType);
			Action onEndAction;
			LuaObject.checkDelegate<Action>(l, 3, out onEndAction);
			dialogCharUIController.Leave(leaveType, onEndAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D125 RID: 119077 RVA: 0x0092234C File Offset: 0x0092054C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string preAnimation;
			LuaObject.checkType(l, 2, out preAnimation);
			string preFacialAnimation;
			LuaObject.checkType(l, 3, out preFacialAnimation);
			string idleAnimation;
			LuaObject.checkType(l, 4, out idleAnimation);
			string idleFacialAnimation;
			LuaObject.checkType(l, 5, out idleFacialAnimation);
			dialogCharUIController.SetAnimation(preAnimation, preFacialAnimation, idleAnimation, idleFacialAnimation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D126 RID: 119078 RVA: 0x009223CC File Offset: 0x009205CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopMouthAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			dialogCharUIController.StopMouthAnimation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D127 RID: 119079 RVA: 0x00922418 File Offset: 0x00920618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnimationDuration(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			float animationDuration = dialogCharUIController.GetAnimationDuration(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationDuration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D128 RID: 119080 RVA: 0x0092247C File Offset: 0x0092067C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			dialogCharUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D129 RID: 119081 RVA: 0x009224D0 File Offset: 0x009206D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			dialogCharUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D12A RID: 119082 RVA: 0x00922524 File Offset: 0x00920724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_TweenColor(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			Color fromColor;
			LuaObject.checkType(l, 2, out fromColor);
			Color toColor;
			LuaObject.checkType(l, 3, out toColor);
			float time;
			LuaObject.checkType(l, 4, out time);
			Action onEndAction;
			LuaObject.checkDelegate<Action>(l, 5, out onEndAction);
			IEnumerator o = dialogCharUIController.m_luaExportHelper.Co_TweenColor(fromColor, toColor, time, onEndAction);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D12B RID: 119083 RVA: 0x009225B4 File Offset: 0x009207B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNextBlinkTime(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			dialogCharUIController.m_luaExportHelper.SetNextBlinkTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D12C RID: 119084 RVA: 0x00922608 File Offset: 0x00920808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			int trackIndex;
			LuaObject.checkType(l, 4, out trackIndex);
			dialogCharUIController.m_luaExportHelper.PlayAnimation(name, loop, trackIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D12D RID: 119085 RVA: 0x00922680 File Offset: 0x00920880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			int trackIndex;
			LuaObject.checkType(l, 2, out trackIndex);
			dialogCharUIController.m_luaExportHelper.StopAnimation(trackIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D12E RID: 119086 RVA: 0x009226DC File Offset: 0x009208DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LateUpdate(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			dialogCharUIController.m_luaExportHelper.LateUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D12F RID: 119087 RVA: 0x00922730 File Offset: 0x00920930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayEyeAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string facialAnimation;
			LuaObject.checkType(l, 2, out facialAnimation);
			dialogCharUIController.m_luaExportHelper.PlayEyeAnimation(facialAnimation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D130 RID: 119088 RVA: 0x0092278C File Offset: 0x0092098C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayEyeStillAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string facialAnimation;
			LuaObject.checkType(l, 2, out facialAnimation);
			dialogCharUIController.m_luaExportHelper.PlayEyeStillAnimation(facialAnimation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D131 RID: 119089 RVA: 0x009227E8 File Offset: 0x009209E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayMouthAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string facialAnimation;
			LuaObject.checkType(l, 2, out facialAnimation);
			dialogCharUIController.m_luaExportHelper.PlayMouthAnimation(facialAnimation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D132 RID: 119090 RVA: 0x00922844 File Offset: 0x00920A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayMouthStillAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string facialAnimation;
			LuaObject.checkType(l, 2, out facialAnimation);
			dialogCharUIController.m_luaExportHelper.PlayMouthStillAnimation(facialAnimation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D133 RID: 119091 RVA: 0x009228A0 File Offset: 0x00920AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			dialogCharUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D134 RID: 119092 RVA: 0x0092290C File Offset: 0x00920B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			dialogCharUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D135 RID: 119093 RVA: 0x00922960 File Offset: 0x00920B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			dialogCharUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D136 RID: 119094 RVA: 0x009229B4 File Offset: 0x00920BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = dialogCharUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D137 RID: 119095 RVA: 0x00922A5C File Offset: 0x00920C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			dialogCharUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D138 RID: 119096 RVA: 0x00922AB0 File Offset: 0x00920CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			dialogCharUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D139 RID: 119097 RVA: 0x00922B1C File Offset: 0x00920D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				dialogCharUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				DialogCharUIController dialogCharUIController2 = (DialogCharUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				dialogCharUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D13A RID: 119098 RVA: 0x00922C2C File Offset: 0x00920E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogCharUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D13B RID: 119099 RVA: 0x00922C98 File Offset: 0x00920E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogCharUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D13C RID: 119100 RVA: 0x00922D04 File Offset: 0x00920F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogCharUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D13D RID: 119101 RVA: 0x00922D70 File Offset: 0x00920F70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			dialogCharUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D13E RID: 119102 RVA: 0x00922DDC File Offset: 0x00920FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				dialogCharUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				DialogCharUIController dialogCharUIController2 = (DialogCharUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				dialogCharUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D13F RID: 119103 RVA: 0x00922EEC File Offset: 0x009210EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string s = dialogCharUIController.m_luaExportHelper.__callBase_ToString();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D140 RID: 119104 RVA: 0x00922F48 File Offset: 0x00921148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D141 RID: 119105 RVA: 0x00922FA0 File Offset: 0x009211A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			dialogCharUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D142 RID: 119106 RVA: 0x00922FFC File Offset: 0x009211FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D143 RID: 119107 RVA: 0x00923054 File Offset: 0x00921254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			dialogCharUIController.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D144 RID: 119108 RVA: 0x009230B0 File Offset: 0x009212B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_charImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D145 RID: 119109 RVA: 0x00923108 File Offset: 0x00921308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			dialogCharUIController.m_luaExportHelper.m_charImageInfo = charImageInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D146 RID: 119110 RVA: 0x00923164 File Offset: 0x00921364
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_spineGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D147 RID: 119111 RVA: 0x009231BC File Offset: 0x009213BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			UISpineGraphic spineGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out spineGraphic);
			dialogCharUIController.m_luaExportHelper.m_spineGraphic = spineGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D148 RID: 119112 RVA: 0x00923218 File Offset: 0x00921418
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_curColor(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_curColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D149 RID: 119113 RVA: 0x00923270 File Offset: 0x00921470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curColor(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			Color curColor;
			LuaObject.checkType(l, 2, out curColor);
			dialogCharUIController.m_luaExportHelper.m_curColor = curColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D14A RID: 119114 RVA: 0x009232CC File Offset: 0x009214CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_tweenColor(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_tweenColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D14B RID: 119115 RVA: 0x00923324 File Offset: 0x00921524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_tweenColor(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			Color tweenColor;
			LuaObject.checkType(l, 2, out tweenColor);
			dialogCharUIController.m_luaExportHelper.m_tweenColor = tweenColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D14C RID: 119116 RVA: 0x00923380 File Offset: 0x00921580
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_tweenColorTime(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_tweenColorTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D14D RID: 119117 RVA: 0x009233D8 File Offset: 0x009215D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tweenColorTime(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			float tweenColorTime;
			LuaObject.checkType(l, 2, out tweenColorTime);
			dialogCharUIController.m_luaExportHelper.m_tweenColorTime = tweenColorTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D14E RID: 119118 RVA: 0x00923434 File Offset: 0x00921634
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_idleAnimationName(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_idleAnimationName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D14F RID: 119119 RVA: 0x0092348C File Offset: 0x0092168C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_idleAnimationName(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string idleAnimationName;
			LuaObject.checkType(l, 2, out idleAnimationName);
			dialogCharUIController.m_luaExportHelper.m_idleAnimationName = idleAnimationName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D150 RID: 119120 RVA: 0x009234E8 File Offset: 0x009216E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_idleFacialAnimationName(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_idleFacialAnimationName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D151 RID: 119121 RVA: 0x00923540 File Offset: 0x00921740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_idleFacialAnimationName(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			string idleFacialAnimationName;
			LuaObject.checkType(l, 2, out idleFacialAnimationName);
			dialogCharUIController.m_luaExportHelper.m_idleFacialAnimationName = idleFacialAnimationName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D152 RID: 119122 RVA: 0x0092359C File Offset: 0x0092179C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_voiceTime(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_voiceTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D153 RID: 119123 RVA: 0x009235F4 File Offset: 0x009217F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_voiceTime(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			float voiceTime;
			LuaObject.checkType(l, 2, out voiceTime);
			dialogCharUIController.m_luaExportHelper.m_voiceTime = voiceTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D154 RID: 119124 RVA: 0x00923650 File Offset: 0x00921850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_blinkTime(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_blinkTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D155 RID: 119125 RVA: 0x009236A8 File Offset: 0x009218A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_blinkTime(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			float blinkTime;
			LuaObject.checkType(l, 2, out blinkTime);
			dialogCharUIController.m_luaExportHelper.m_blinkTime = blinkTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D156 RID: 119126 RVA: 0x00923704 File Offset: 0x00921904
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isPlayingPreAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_isPlayingPreAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D157 RID: 119127 RVA: 0x0092375C File Offset: 0x0092195C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPlayingPreAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			bool isPlayingPreAnimation;
			LuaObject.checkType(l, 2, out isPlayingPreAnimation);
			dialogCharUIController.m_luaExportHelper.m_isPlayingPreAnimation = isPlayingPreAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D158 RID: 119128 RVA: 0x009237B8 File Offset: 0x009219B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isPlayingEyeAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_isPlayingEyeAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D159 RID: 119129 RVA: 0x00923810 File Offset: 0x00921A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPlayingEyeAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			bool isPlayingEyeAnimation;
			LuaObject.checkType(l, 2, out isPlayingEyeAnimation);
			dialogCharUIController.m_luaExportHelper.m_isPlayingEyeAnimation = isPlayingEyeAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D15A RID: 119130 RVA: 0x0092386C File Offset: 0x00921A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isPlayingMouthAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dialogCharUIController.m_luaExportHelper.m_isPlayingMouthAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D15B RID: 119131 RVA: 0x009238C4 File Offset: 0x00921AC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isPlayingMouthAnimation(IntPtr l)
	{
		int result;
		try
		{
			DialogCharUIController dialogCharUIController = (DialogCharUIController)LuaObject.checkSelf(l);
			bool isPlayingMouthAnimation;
			LuaObject.checkType(l, 2, out isPlayingMouthAnimation);
			dialogCharUIController.m_luaExportHelper.m_isPlayingMouthAnimation = isPlayingMouthAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D15C RID: 119132 RVA: 0x00923920 File Offset: 0x00921B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EYE_ANIMATION_TRACK(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DialogCharUIController.LuaExportHelper.EYE_ANIMATION_TRACK);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D15D RID: 119133 RVA: 0x00923968 File Offset: 0x00921B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MOUTH_ANIMATION_TRACK(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DialogCharUIController.LuaExportHelper.MOUTH_ANIMATION_TRACK);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D15E RID: 119134 RVA: 0x009239B0 File Offset: 0x00921BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EYE_ANIMATION(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DialogCharUIController.LuaExportHelper.EYE_ANIMATION);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D15F RID: 119135 RVA: 0x009239F8 File Offset: 0x00921BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EYE_STILL_ANIMATION(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DialogCharUIController.LuaExportHelper.EYE_STILL_ANIMATION);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D160 RID: 119136 RVA: 0x00923A40 File Offset: 0x00921C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MOUTH_ANIMATION(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DialogCharUIController.LuaExportHelper.MOUTH_ANIMATION);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D161 RID: 119137 RVA: 0x00923A88 File Offset: 0x00921C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MOUTH_STILL_ANIMATION(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DialogCharUIController.LuaExportHelper.MOUTH_STILL_ANIMATION);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D162 RID: 119138 RVA: 0x00923AD0 File Offset: 0x00921CD0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DialogCharUIController");
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.CreateGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.DestroyGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.SetScaleOffet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.SetDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.SetColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.TweenColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.GetCharImageInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.StartFacialAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.Enter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.Leave);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.SetAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.StopMouthAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.GetAnimationDuration);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.Co_TweenColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.SetNextBlinkTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.StopAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.LateUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.PlayEyeAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.PlayEyeStillAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.PlayMouthAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.PlayMouthStillAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache24);
		string name = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_uiStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache26, true);
		string name2 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_image);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_image);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache28, true);
		string name3 = "m_charImageInfo";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_charImageInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_charImageInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2A, true);
		string name4 = "m_spineGraphic";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_spineGraphic);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_spineGraphic);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2C, true);
		string name5 = "m_curColor";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_curColor);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_curColor);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2E, true);
		string name6 = "m_tweenColor";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_tweenColor);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_tweenColor);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache30, true);
		string name7 = "m_tweenColorTime";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_tweenColorTime);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_tweenColorTime);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache32, true);
		string name8 = "m_idleAnimationName";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_idleAnimationName);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_idleAnimationName);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache34, true);
		string name9 = "m_idleFacialAnimationName";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_idleFacialAnimationName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_idleFacialAnimationName);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache36, true);
		string name10 = "m_voiceTime";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_voiceTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_voiceTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache38, true);
		string name11 = "m_blinkTime";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_blinkTime);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_blinkTime);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3A, true);
		string name12 = "m_isPlayingPreAnimation";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_isPlayingPreAnimation);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_isPlayingPreAnimation);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3C, true);
		string name13 = "m_isPlayingEyeAnimation";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_isPlayingEyeAnimation);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_isPlayingEyeAnimation);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3E, true);
		string name14 = "m_isPlayingMouthAnimation";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_m_isPlayingMouthAnimation);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.set_m_isPlayingMouthAnimation);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache40, true);
		string name15 = "EYE_ANIMATION_TRACK";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_EYE_ANIMATION_TRACK);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache41, null, false);
		string name16 = "MOUTH_ANIMATION_TRACK";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_MOUTH_ANIMATION_TRACK);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache42, null, false);
		string name17 = "EYE_ANIMATION";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_EYE_ANIMATION);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache43, null, false);
		string name18 = "EYE_STILL_ANIMATION";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_EYE_STILL_ANIMATION);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache44, null, false);
		string name19 = "MOUTH_ANIMATION";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_MOUTH_ANIMATION);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache45, null, false);
		string name20 = "MOUTH_STILL_ANIMATION";
		if (Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DialogCharUIController.get_MOUTH_STILL_ANIMATION);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_UI_DialogCharUIController.<>f__mg$cache46, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(DialogCharUIController), typeof(UIControllerBase));
	}

	// Token: 0x040132D3 RID: 78547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040132D4 RID: 78548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040132D5 RID: 78549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040132D6 RID: 78550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040132D7 RID: 78551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040132D8 RID: 78552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040132D9 RID: 78553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040132DA RID: 78554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040132DB RID: 78555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040132DC RID: 78556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040132DD RID: 78557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040132DE RID: 78558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040132DF RID: 78559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040132E0 RID: 78560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040132E1 RID: 78561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040132E2 RID: 78562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040132E3 RID: 78563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040132E4 RID: 78564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040132E5 RID: 78565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040132E6 RID: 78566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040132E7 RID: 78567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040132E8 RID: 78568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040132E9 RID: 78569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040132EA RID: 78570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040132EB RID: 78571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040132EC RID: 78572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040132ED RID: 78573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040132EE RID: 78574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040132EF RID: 78575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040132F0 RID: 78576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040132F1 RID: 78577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040132F2 RID: 78578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040132F3 RID: 78579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040132F4 RID: 78580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040132F5 RID: 78581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040132F6 RID: 78582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040132F7 RID: 78583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040132F8 RID: 78584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040132F9 RID: 78585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040132FA RID: 78586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040132FB RID: 78587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040132FC RID: 78588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040132FD RID: 78589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040132FE RID: 78590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040132FF RID: 78591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013300 RID: 78592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013301 RID: 78593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013302 RID: 78594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013303 RID: 78595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013304 RID: 78596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013305 RID: 78597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013306 RID: 78598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013307 RID: 78599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013308 RID: 78600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013309 RID: 78601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401330A RID: 78602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401330B RID: 78603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401330C RID: 78604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401330D RID: 78605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401330E RID: 78606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401330F RID: 78607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013310 RID: 78608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013311 RID: 78609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013312 RID: 78610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013313 RID: 78611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013314 RID: 78612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013315 RID: 78613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013316 RID: 78614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013317 RID: 78615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013318 RID: 78616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013319 RID: 78617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;
}
