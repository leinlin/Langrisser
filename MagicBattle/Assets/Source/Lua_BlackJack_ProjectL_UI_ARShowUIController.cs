using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200138B RID: 5003
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ARShowUIController : LuaObject
{
	// Token: 0x0601B3DF RID: 111583 RVA: 0x008395FC File Offset: 0x008377FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Refresh(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.Refresh();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3E0 RID: 111584 RVA: 0x00839648 File Offset: 0x00837848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUITask(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			ARUITask uitask;
			LuaObject.checkType<ARUITask>(l, 2, out uitask);
			arshowUIController.SetUITask(uitask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3E1 RID: 111585 RVA: 0x008396A0 File Offset: 0x008378A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadData(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.LoadData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3E2 RID: 111586 RVA: 0x008396EC File Offset: 0x008378EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetARShowSceneController(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			ARShowSceneController arshowSceneController;
			LuaObject.checkType<ARShowSceneController>(l, 2, out arshowSceneController);
			arshowUIController.SetARShowSceneController(arshowSceneController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3E3 RID: 111587 RVA: 0x00839744 File Offset: 0x00837944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3E4 RID: 111588 RVA: 0x00839798 File Offset: 0x00837998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3E5 RID: 111589 RVA: 0x008397EC File Offset: 0x008379EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDeveloperMode(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.UpdateDeveloperMode();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3E6 RID: 111590 RVA: 0x00839840 File Offset: 0x00837A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPhotographClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.OnPhotographClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3E7 RID: 111591 RVA: 0x00839894 File Offset: 0x00837A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.OnReturnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3E8 RID: 111592 RVA: 0x008398E8 File Offset: 0x00837AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSummonClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.OnSummonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3E9 RID: 111593 RVA: 0x0083993C File Offset: 0x00837B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExitClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.OnExitClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3EA RID: 111594 RVA: 0x00839990 File Offset: 0x00837B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCharActionClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			arshowUIController.m_luaExportHelper.OnCharActionClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3EB RID: 111595 RVA: 0x008399EC File Offset: 0x00837BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCharDirectionClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			arshowUIController.m_luaExportHelper.OnCharDirectionClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3EC RID: 111596 RVA: 0x00839A48 File Offset: 0x00837C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShareReturnClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.OnShareReturnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3ED RID: 111597 RVA: 0x00839A9C File Offset: 0x00837C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWeiBoClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.OnWeiBoClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3EE RID: 111598 RVA: 0x00839AF0 File Offset: 0x00837CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWeChatClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.OnWeChatClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3EF RID: 111599 RVA: 0x00839B44 File Offset: 0x00837D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShareBackgroundClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.OnShareBackgroundClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3F0 RID: 111600 RVA: 0x00839B98 File Offset: 0x00837D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScaleScrollBarValueChange(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			float value;
			LuaObject.checkType(l, 2, out value);
			arshowUIController.m_luaExportHelper.OnScaleScrollBarValueChange(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3F1 RID: 111601 RVA: 0x00839BF4 File Offset: 0x00837DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDistanceScrollBarValueChange(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			float value;
			LuaObject.checkType(l, 2, out value);
			arshowUIController.m_luaExportHelper.OnDistanceScrollBarValueChange(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3F2 RID: 111602 RVA: 0x00839C50 File Offset: 0x00837E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Photograph(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			IEnumerator o = arshowUIController.m_luaExportHelper.Photograph();
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

	// Token: 0x0601B3F3 RID: 111603 RVA: 0x00839CAC File Offset: 0x00837EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShareImage(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			int sharePlatform;
			LuaObject.checkType(l, 2, out sharePlatform);
			IEnumerator o = arshowUIController.m_luaExportHelper.ShareImage(sharePlatform);
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

	// Token: 0x0601B3F4 RID: 111604 RVA: 0x00839D14 File Offset: 0x00837F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CopyTexture2D(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Texture2D texture;
			LuaObject.checkType<Texture2D>(l, 2, out texture);
			Texture2D o = arshowUIController.m_luaExportHelper.CopyTexture2D(texture);
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

	// Token: 0x0601B3F5 RID: 111605 RVA: 0x00839D7C File Offset: 0x00837F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveTextureToPNG(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Texture2D texture;
			LuaObject.checkType<Texture2D>(l, 2, out texture);
			string path;
			LuaObject.checkType(l, 3, out path);
			string pngName;
			LuaObject.checkType(l, 4, out pngName);
			arshowUIController.m_luaExportHelper.SaveTextureToPNG(texture, path, pngName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3F6 RID: 111606 RVA: 0x00839DF4 File Offset: 0x00837FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arshowUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3F7 RID: 111607 RVA: 0x00839E60 File Offset: 0x00838060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3F8 RID: 111608 RVA: 0x00839EB4 File Offset: 0x008380B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3F9 RID: 111609 RVA: 0x00839F08 File Offset: 0x00838108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arshowUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B3FA RID: 111610 RVA: 0x00839FB0 File Offset: 0x008381B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			arshowUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3FB RID: 111611 RVA: 0x0083A004 File Offset: 0x00838204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arshowUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3FC RID: 111612 RVA: 0x0083A070 File Offset: 0x00838270
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
				ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arshowUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ARShowUIController arshowUIController2 = (ARShowUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arshowUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B3FD RID: 111613 RVA: 0x0083A180 File Offset: 0x00838380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arshowUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3FE RID: 111614 RVA: 0x0083A1EC File Offset: 0x008383EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arshowUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3FF RID: 111615 RVA: 0x0083A258 File Offset: 0x00838458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arshowUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B400 RID: 111616 RVA: 0x0083A2C4 File Offset: 0x008384C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arshowUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B401 RID: 111617 RVA: 0x0083A330 File Offset: 0x00838530
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
				ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arshowUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ARShowUIController arshowUIController2 = (ARShowUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arshowUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B402 RID: 111618 RVA: 0x0083A440 File Offset: 0x00838640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			string s = arshowUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B403 RID: 111619 RVA: 0x0083A49C File Offset: 0x0083869C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uiState(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)arshowUIController.m_luaExportHelper.uiState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B404 RID: 111620 RVA: 0x0083A4F4 File Offset: 0x008386F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uiState(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			ARShowUIController.UIState uiState;
			LuaObject.checkEnum<ARShowUIController.UIState>(l, 2, out uiState);
			arshowUIController.m_luaExportHelper.uiState = uiState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B405 RID: 111621 RVA: 0x0083A550 File Offset: 0x00838750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resourceContainer(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_resourceContainer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B406 RID: 111622 RVA: 0x0083A5A8 File Offset: 0x008387A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resourceContainer(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			PrefabResourceContainer resourceContainer;
			LuaObject.checkType<PrefabResourceContainer>(l, 2, out resourceContainer);
			arshowUIController.m_luaExportHelper.m_resourceContainer = resourceContainer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B407 RID: 111623 RVA: 0x0083A604 File Offset: 0x00838804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_photographButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_photographButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B408 RID: 111624 RVA: 0x0083A65C File Offset: 0x0083885C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_photographButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Button photographButton;
			LuaObject.checkType<Button>(l, 2, out photographButton);
			arshowUIController.m_luaExportHelper.m_photographButton = photographButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B409 RID: 111625 RVA: 0x0083A6B8 File Offset: 0x008388B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B40A RID: 111626 RVA: 0x0083A710 File Offset: 0x00838910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			arshowUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B40B RID: 111627 RVA: 0x0083A76C File Offset: 0x0083896C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_summonButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_summonButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B40C RID: 111628 RVA: 0x0083A7C4 File Offset: 0x008389C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_summonButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Button summonButton;
			LuaObject.checkType<Button>(l, 2, out summonButton);
			arshowUIController.m_luaExportHelper.m_summonButton = summonButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B40D RID: 111629 RVA: 0x0083A820 File Offset: 0x00838A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_exitButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_exitButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B40E RID: 111630 RVA: 0x0083A878 File Offset: 0x00838A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_exitButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Button exitButton;
			LuaObject.checkType<Button>(l, 2, out exitButton);
			arshowUIController.m_luaExportHelper.m_exitButton = exitButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B40F RID: 111631 RVA: 0x0083A8D4 File Offset: 0x00838AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roleControlPanel(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_roleControlPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B410 RID: 111632 RVA: 0x0083A92C File Offset: 0x00838B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roleControlPanel(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			GameObject roleControlPanel;
			LuaObject.checkType<GameObject>(l, 2, out roleControlPanel);
			arshowUIController.m_luaExportHelper.m_roleControlPanel = roleControlPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B411 RID: 111633 RVA: 0x0083A988 File Offset: 0x00838B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B412 RID: 111634 RVA: 0x0083A9E0 File Offset: 0x00838BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			arshowUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B413 RID: 111635 RVA: 0x0083AA3C File Offset: 0x00838C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charActionChoose(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_charActionChoose);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B414 RID: 111636 RVA: 0x0083AA94 File Offset: 0x00838C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charActionChoose(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle charActionChoose;
			LuaObject.checkType<Toggle>(l, 2, out charActionChoose);
			arshowUIController.m_luaExportHelper.m_charActionChoose = charActionChoose;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B415 RID: 111637 RVA: 0x0083AAF0 File Offset: 0x00838CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charIdleToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_charIdleToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B416 RID: 111638 RVA: 0x0083AB48 File Offset: 0x00838D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charIdleToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle charIdleToggle;
			LuaObject.checkType<Toggle>(l, 2, out charIdleToggle);
			arshowUIController.m_luaExportHelper.m_charIdleToggle = charIdleToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B417 RID: 111639 RVA: 0x0083ABA4 File Offset: 0x00838DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charAttackToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_charAttackToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B418 RID: 111640 RVA: 0x0083ABFC File Offset: 0x00838DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charAttackToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle charAttackToggle;
			LuaObject.checkType<Toggle>(l, 2, out charAttackToggle);
			arshowUIController.m_luaExportHelper.m_charAttackToggle = charAttackToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B419 RID: 111641 RVA: 0x0083AC58 File Offset: 0x00838E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charSuperAttackToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_charSuperAttackToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B41A RID: 111642 RVA: 0x0083ACB0 File Offset: 0x00838EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charSuperAttackToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle charSuperAttackToggle;
			LuaObject.checkType<Toggle>(l, 2, out charSuperAttackToggle);
			arshowUIController.m_luaExportHelper.m_charSuperAttackToggle = charSuperAttackToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B41B RID: 111643 RVA: 0x0083AD0C File Offset: 0x00838F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charMagicToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_charMagicToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B41C RID: 111644 RVA: 0x0083AD64 File Offset: 0x00838F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charMagicToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle charMagicToggle;
			LuaObject.checkType<Toggle>(l, 2, out charMagicToggle);
			arshowUIController.m_luaExportHelper.m_charMagicToggle = charMagicToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B41D RID: 111645 RVA: 0x0083ADC0 File Offset: 0x00838FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charDeathToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_charDeathToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B41E RID: 111646 RVA: 0x0083AE18 File Offset: 0x00839018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charDeathToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle charDeathToggle;
			LuaObject.checkType<Toggle>(l, 2, out charDeathToggle);
			arshowUIController.m_luaExportHelper.m_charDeathToggle = charDeathToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B41F RID: 111647 RVA: 0x0083AE74 File Offset: 0x00839074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charSingToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_charSingToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B420 RID: 111648 RVA: 0x0083AECC File Offset: 0x008390CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charSingToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle charSingToggle;
			LuaObject.checkType<Toggle>(l, 2, out charSingToggle);
			arshowUIController.m_luaExportHelper.m_charSingToggle = charSingToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B421 RID: 111649 RVA: 0x0083AF28 File Offset: 0x00839128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charFaintToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_charFaintToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B422 RID: 111650 RVA: 0x0083AF80 File Offset: 0x00839180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charFaintToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle charFaintToggle;
			LuaObject.checkType<Toggle>(l, 2, out charFaintToggle);
			arshowUIController.m_luaExportHelper.m_charFaintToggle = charFaintToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B423 RID: 111651 RVA: 0x0083AFDC File Offset: 0x008391DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charRunToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_charRunToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B424 RID: 111652 RVA: 0x0083B034 File Offset: 0x00839234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charRunToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle charRunToggle;
			LuaObject.checkType<Toggle>(l, 2, out charRunToggle);
			arshowUIController.m_luaExportHelper.m_charRunToggle = charRunToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B425 RID: 111653 RVA: 0x0083B090 File Offset: 0x00839290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnLeftToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_turnLeftToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B426 RID: 111654 RVA: 0x0083B0E8 File Offset: 0x008392E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turnLeftToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle turnLeftToggle;
			LuaObject.checkType<Toggle>(l, 2, out turnLeftToggle);
			arshowUIController.m_luaExportHelper.m_turnLeftToggle = turnLeftToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B427 RID: 111655 RVA: 0x0083B144 File Offset: 0x00839344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_turnRightToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_turnRightToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B428 RID: 111656 RVA: 0x0083B19C File Offset: 0x0083939C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_turnRightToggle(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Toggle turnRightToggle;
			LuaObject.checkType<Toggle>(l, 2, out turnRightToggle);
			arshowUIController.m_luaExportHelper.m_turnRightToggle = turnRightToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B429 RID: 111657 RVA: 0x0083B1F8 File Offset: 0x008393F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sharePanel(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_sharePanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B42A RID: 111658 RVA: 0x0083B250 File Offset: 0x00839450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sharePanel(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			GameObject sharePanel;
			LuaObject.checkType<GameObject>(l, 2, out sharePanel);
			arshowUIController.m_luaExportHelper.m_sharePanel = sharePanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B42B RID: 111659 RVA: 0x0083B2AC File Offset: 0x008394AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shareBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_shareBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B42C RID: 111660 RVA: 0x0083B304 File Offset: 0x00839504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shareBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Button shareBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out shareBackgroundButton);
			arshowUIController.m_luaExportHelper.m_shareBackgroundButton = shareBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B42D RID: 111661 RVA: 0x0083B360 File Offset: 0x00839560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shareImage(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_shareImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B42E RID: 111662 RVA: 0x0083B3B8 File Offset: 0x008395B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shareImage(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			RawImage shareImage;
			LuaObject.checkType<RawImage>(l, 2, out shareImage);
			arshowUIController.m_luaExportHelper.m_shareImage = shareImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B42F RID: 111663 RVA: 0x0083B414 File Offset: 0x00839614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shareReturnButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_shareReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B430 RID: 111664 RVA: 0x0083B46C File Offset: 0x0083966C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shareReturnButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Button shareReturnButton;
			LuaObject.checkType<Button>(l, 2, out shareReturnButton);
			arshowUIController.m_luaExportHelper.m_shareReturnButton = shareReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B431 RID: 111665 RVA: 0x0083B4C8 File Offset: 0x008396C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shareButtonDummy(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_shareButtonDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B432 RID: 111666 RVA: 0x0083B520 File Offset: 0x00839720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shareButtonDummy(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			GameObject shareButtonDummy;
			LuaObject.checkType<GameObject>(l, 2, out shareButtonDummy);
			arshowUIController.m_luaExportHelper.m_shareButtonDummy = shareButtonDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B433 RID: 111667 RVA: 0x0083B57C File Offset: 0x0083977C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sharePhotoDummy(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_sharePhotoDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B434 RID: 111668 RVA: 0x0083B5D4 File Offset: 0x008397D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sharePhotoDummy(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			GameObject sharePhotoDummy;
			LuaObject.checkType<GameObject>(l, 2, out sharePhotoDummy);
			arshowUIController.m_luaExportHelper.m_sharePhotoDummy = sharePhotoDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B435 RID: 111669 RVA: 0x0083B630 File Offset: 0x00839830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_developPanel(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_developPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B436 RID: 111670 RVA: 0x0083B688 File Offset: 0x00839888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_developPanel(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			GameObject developPanel;
			LuaObject.checkType<GameObject>(l, 2, out developPanel);
			arshowUIController.m_luaExportHelper.m_developPanel = developPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B437 RID: 111671 RVA: 0x0083B6E4 File Offset: 0x008398E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scaleScrollbar(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_scaleScrollbar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B438 RID: 111672 RVA: 0x0083B73C File Offset: 0x0083993C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scaleScrollbar(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Scrollbar scaleScrollbar;
			LuaObject.checkType<Scrollbar>(l, 2, out scaleScrollbar);
			arshowUIController.m_luaExportHelper.m_scaleScrollbar = scaleScrollbar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B439 RID: 111673 RVA: 0x0083B798 File Offset: 0x00839998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_distanceScrollbar(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_distanceScrollbar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B43A RID: 111674 RVA: 0x0083B7F0 File Offset: 0x008399F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_distanceScrollbar(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Scrollbar distanceScrollbar;
			LuaObject.checkType<Scrollbar>(l, 2, out distanceScrollbar);
			arshowUIController.m_luaExportHelper.m_distanceScrollbar = distanceScrollbar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B43B RID: 111675 RVA: 0x0083B84C File Offset: 0x00839A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scaleText(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_scaleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B43C RID: 111676 RVA: 0x0083B8A4 File Offset: 0x00839AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scaleText(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Text scaleText;
			LuaObject.checkType<Text>(l, 2, out scaleText);
			arshowUIController.m_luaExportHelper.m_scaleText = scaleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B43D RID: 111677 RVA: 0x0083B900 File Offset: 0x00839B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_distanceText(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_distanceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B43E RID: 111678 RVA: 0x0083B958 File Offset: 0x00839B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_distanceText(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Text distanceText;
			LuaObject.checkType<Text>(l, 2, out distanceText);
			arshowUIController.m_luaExportHelper.m_distanceText = distanceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B43F RID: 111679 RVA: 0x0083B9B4 File Offset: 0x00839BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sharePhotoUIPanel(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_sharePhotoUIPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B440 RID: 111680 RVA: 0x0083BA0C File Offset: 0x00839C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sharePhotoUIPanel(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			GameObject sharePhotoUIPanel;
			LuaObject.checkType<GameObject>(l, 2, out sharePhotoUIPanel);
			arshowUIController.m_luaExportHelper.m_sharePhotoUIPanel = sharePhotoUIPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B441 RID: 111681 RVA: 0x0083BA68 File Offset: 0x00839C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B442 RID: 111682 RVA: 0x0083BAC0 File Offset: 0x00839CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			arshowUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B443 RID: 111683 RVA: 0x0083BB1C File Offset: 0x00839D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLvText(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_playerLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B444 RID: 111684 RVA: 0x0083BB74 File Offset: 0x00839D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLvText(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Text playerLvText;
			LuaObject.checkType<Text>(l, 2, out playerLvText);
			arshowUIController.m_luaExportHelper.m_playerLvText = playerLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B445 RID: 111685 RVA: 0x0083BBD0 File Offset: 0x00839DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverNameText(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_serverNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B446 RID: 111686 RVA: 0x0083BC28 File Offset: 0x00839E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverNameText(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Text serverNameText;
			LuaObject.checkType<Text>(l, 2, out serverNameText);
			arshowUIController.m_luaExportHelper.m_serverNameText = serverNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B447 RID: 111687 RVA: 0x0083BC84 File Offset: 0x00839E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shareSubPanel(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_shareSubPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B448 RID: 111688 RVA: 0x0083BCDC File Offset: 0x00839EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shareSubPanel(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			GameObject shareSubPanel;
			LuaObject.checkType<GameObject>(l, 2, out shareSubPanel);
			arshowUIController.m_luaExportHelper.m_shareSubPanel = shareSubPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B449 RID: 111689 RVA: 0x0083BD38 File Offset: 0x00839F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weiBoButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_weiBoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B44A RID: 111690 RVA: 0x0083BD90 File Offset: 0x00839F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weiBoButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Button weiBoButton;
			LuaObject.checkType<Button>(l, 2, out weiBoButton);
			arshowUIController.m_luaExportHelper.m_weiBoButton = weiBoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B44B RID: 111691 RVA: 0x0083BDEC File Offset: 0x00839FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weChatButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_weChatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B44C RID: 111692 RVA: 0x0083BE44 File Offset: 0x0083A044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weChatButton(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Button weChatButton;
			LuaObject.checkType<Button>(l, 2, out weChatButton);
			arshowUIController.m_luaExportHelper.m_weChatButton = weChatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B44D RID: 111693 RVA: 0x0083BEA0 File Offset: 0x0083A0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_task(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_task);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B44E RID: 111694 RVA: 0x0083BEF8 File Offset: 0x0083A0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_task(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			ARUITask task;
			LuaObject.checkType<ARUITask>(l, 2, out task);
			arshowUIController.m_luaExportHelper.m_task = task;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B44F RID: 111695 RVA: 0x0083BF54 File Offset: 0x0083A154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arShowSceneController(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_arShowSceneController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B450 RID: 111696 RVA: 0x0083BFAC File Offset: 0x0083A1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arShowSceneController(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			ARShowSceneController arShowSceneController;
			LuaObject.checkType<ARShowSceneController>(l, 2, out arShowSceneController);
			arshowUIController.m_luaExportHelper.m_arShowSceneController = arShowSceneController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B451 RID: 111697 RVA: 0x0083C008 File Offset: 0x0083A208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B452 RID: 111698 RVA: 0x0083C060 File Offset: 0x0083A260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			arshowUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B453 RID: 111699 RVA: 0x0083C0BC File Offset: 0x0083A2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B454 RID: 111700 RVA: 0x0083C114 File Offset: 0x0083A314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			arshowUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B455 RID: 111701 RVA: 0x0083C170 File Offset: 0x0083A370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_captureTexture(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_captureTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B456 RID: 111702 RVA: 0x0083C1C8 File Offset: 0x0083A3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_captureTexture(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			Texture2D captureTexture;
			LuaObject.checkType<Texture2D>(l, 2, out captureTexture);
			arshowUIController.m_luaExportHelper.m_captureTexture = captureTexture;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B457 RID: 111703 RVA: 0x0083C224 File Offset: 0x0083A424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arShowType(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_arShowType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B458 RID: 111704 RVA: 0x0083C27C File Offset: 0x0083A47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arShowType(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			int arShowType;
			LuaObject.checkType(l, 2, out arShowType);
			arshowUIController.m_luaExportHelper.m_arShowType = arShowType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B459 RID: 111705 RVA: 0x0083C2D8 File Offset: 0x0083A4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectHeroID(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowUIController.m_luaExportHelper.m_selectHeroID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B45A RID: 111706 RVA: 0x0083C330 File Offset: 0x0083A530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectHeroID(IntPtr l)
	{
		int result;
		try
		{
			ARShowUIController arshowUIController = (ARShowUIController)LuaObject.checkSelf(l);
			int selectHeroID;
			LuaObject.checkType(l, 2, out selectHeroID);
			arshowUIController.m_luaExportHelper.m_selectHeroID = selectHeroID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B45B RID: 111707 RVA: 0x0083C38C File Offset: 0x0083A58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleShow(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B45C RID: 111708 RVA: 0x0083C3D0 File Offset: 0x0083A5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroDrawShow(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B45D RID: 111709 RVA: 0x0083C414 File Offset: 0x0083A614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamShow(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B45E RID: 111710 RVA: 0x0083C458 File Offset: 0x0083A658
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ARShowUIController");
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.Refresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.SetUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.LoadData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.SetARShowSceneController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.UpdateDeveloperMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnPhotographClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnReturnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnSummonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnExitClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnCharActionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnCharDirectionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnShareReturnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnWeiBoClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnWeChatClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnShareBackgroundClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnScaleScrollBarValueChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.OnDistanceScrollBarValueChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.Photograph);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.ShareImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.CopyTexture2D);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.SaveTextureToPNG);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache23);
		string name = "uiState";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_uiState);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_uiState);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache25, true);
		string name2 = "m_resourceContainer";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_resourceContainer);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_resourceContainer);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache27, true);
		string name3 = "m_photographButton";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_photographButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_photographButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache29, true);
		string name4 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_returnButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2B, true);
		string name5 = "m_summonButton";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_summonButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_summonButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2D, true);
		string name6 = "m_exitButton";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_exitButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_exitButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache2F, true);
		string name7 = "m_roleControlPanel";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_roleControlPanel);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_roleControlPanel);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache31, true);
		string name8 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_marginTransform);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache33, true);
		string name9 = "m_charActionChoose";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_charActionChoose);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_charActionChoose);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache35, true);
		string name10 = "m_charIdleToggle";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_charIdleToggle);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_charIdleToggle);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache37, true);
		string name11 = "m_charAttackToggle";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_charAttackToggle);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_charAttackToggle);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache39, true);
		string name12 = "m_charSuperAttackToggle";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_charSuperAttackToggle);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_charSuperAttackToggle);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3B, true);
		string name13 = "m_charMagicToggle";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_charMagicToggle);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_charMagicToggle);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3D, true);
		string name14 = "m_charDeathToggle";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_charDeathToggle);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_charDeathToggle);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache3F, true);
		string name15 = "m_charSingToggle";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_charSingToggle);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_charSingToggle);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache41, true);
		string name16 = "m_charFaintToggle";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_charFaintToggle);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_charFaintToggle);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache43, true);
		string name17 = "m_charRunToggle";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_charRunToggle);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_charRunToggle);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache45, true);
		string name18 = "m_turnLeftToggle";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_turnLeftToggle);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_turnLeftToggle);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache47, true);
		string name19 = "m_turnRightToggle";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_turnRightToggle);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_turnRightToggle);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache49, true);
		string name20 = "m_sharePanel";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_sharePanel);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_sharePanel);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4B, true);
		string name21 = "m_shareBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_shareBackgroundButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_shareBackgroundButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4D, true);
		string name22 = "m_shareImage";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_shareImage);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_shareImage);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache4F, true);
		string name23 = "m_shareReturnButton";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_shareReturnButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_shareReturnButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache51, true);
		string name24 = "m_shareButtonDummy";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_shareButtonDummy);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_shareButtonDummy);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache53, true);
		string name25 = "m_sharePhotoDummy";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_sharePhotoDummy);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_sharePhotoDummy);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache55, true);
		string name26 = "m_developPanel";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_developPanel);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_developPanel);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache57, true);
		string name27 = "m_scaleScrollbar";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_scaleScrollbar);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_scaleScrollbar);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache59, true);
		string name28 = "m_distanceScrollbar";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_distanceScrollbar);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_distanceScrollbar);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5B, true);
		string name29 = "m_scaleText";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_scaleText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_scaleText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5D, true);
		string name30 = "m_distanceText";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_distanceText);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_distanceText);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache5F, true);
		string name31 = "m_sharePhotoUIPanel";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_sharePhotoUIPanel);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_sharePhotoUIPanel);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache61, true);
		string name32 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_playerNameText);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache63, true);
		string name33 = "m_playerLvText";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_playerLvText);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_playerLvText);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache65, true);
		string name34 = "m_serverNameText";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_serverNameText);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_serverNameText);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache67, true);
		string name35 = "m_shareSubPanel";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_shareSubPanel);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_shareSubPanel);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache69, true);
		string name36 = "m_weiBoButton";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_weiBoButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_weiBoButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6B, true);
		string name37 = "m_weChatButton";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_weChatButton);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_weChatButton);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6D, true);
		string name38 = "m_task";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_task);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_task);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache6F, true);
		string name39 = "m_arShowSceneController";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_arShowSceneController);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_arShowSceneController);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache71, true);
		string name40 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_configDataLoader);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache73, true);
		string name41 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_playerContext);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache75, true);
		string name42 = "m_captureTexture";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_captureTexture);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_captureTexture);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache77, true);
		string name43 = "m_arShowType";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_arShowType);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_arShowType);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache79, true);
		string name44 = "m_selectHeroID";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_m_selectHeroID);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.set_m_selectHeroID);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7B, true);
		string name45 = "BattleShow";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_BattleShow);
		}
		LuaObject.addMember(l, name45, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7C, null, false);
		string name46 = "HeroDrawShow";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_HeroDrawShow);
		}
		LuaObject.addMember(l, name46, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7D, null, false);
		string name47 = "TeamShow";
		if (Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowUIController.get_TeamShow);
		}
		LuaObject.addMember(l, name47, Lua_BlackJack_ProjectL_UI_ARShowUIController.<>f__mg$cache7E, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(ARShowUIController), typeof(UIControllerBase));
	}

	// Token: 0x040116AB RID: 71339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040116AC RID: 71340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040116AD RID: 71341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040116AE RID: 71342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040116AF RID: 71343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040116B0 RID: 71344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040116B1 RID: 71345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040116B2 RID: 71346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040116B3 RID: 71347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040116B4 RID: 71348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040116B5 RID: 71349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040116B6 RID: 71350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040116B7 RID: 71351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040116B8 RID: 71352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040116B9 RID: 71353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040116BA RID: 71354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040116BB RID: 71355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040116BC RID: 71356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040116BD RID: 71357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040116BE RID: 71358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040116BF RID: 71359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040116C0 RID: 71360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040116C1 RID: 71361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040116C2 RID: 71362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040116C3 RID: 71363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040116C4 RID: 71364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040116C5 RID: 71365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040116C6 RID: 71366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040116C7 RID: 71367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040116C8 RID: 71368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040116C9 RID: 71369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040116CA RID: 71370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040116CB RID: 71371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040116CC RID: 71372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040116CD RID: 71373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040116CE RID: 71374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040116CF RID: 71375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040116D0 RID: 71376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040116D1 RID: 71377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040116D2 RID: 71378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040116D3 RID: 71379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040116D4 RID: 71380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040116D5 RID: 71381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040116D6 RID: 71382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040116D7 RID: 71383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040116D8 RID: 71384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040116D9 RID: 71385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040116DA RID: 71386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040116DB RID: 71387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040116DC RID: 71388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040116DD RID: 71389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040116DE RID: 71390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040116DF RID: 71391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040116E0 RID: 71392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040116E1 RID: 71393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040116E2 RID: 71394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040116E3 RID: 71395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040116E4 RID: 71396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040116E5 RID: 71397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040116E6 RID: 71398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040116E7 RID: 71399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040116E8 RID: 71400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040116E9 RID: 71401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040116EA RID: 71402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040116EB RID: 71403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040116EC RID: 71404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040116ED RID: 71405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040116EE RID: 71406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040116EF RID: 71407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040116F0 RID: 71408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040116F1 RID: 71409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040116F2 RID: 71410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040116F3 RID: 71411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040116F4 RID: 71412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040116F5 RID: 71413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040116F6 RID: 71414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040116F7 RID: 71415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040116F8 RID: 71416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040116F9 RID: 71417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040116FA RID: 71418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040116FB RID: 71419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040116FC RID: 71420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040116FD RID: 71421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040116FE RID: 71422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040116FF RID: 71423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04011700 RID: 71424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04011701 RID: 71425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04011702 RID: 71426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04011703 RID: 71427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04011704 RID: 71428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04011705 RID: 71429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04011706 RID: 71430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04011707 RID: 71431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04011708 RID: 71432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04011709 RID: 71433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401170A RID: 71434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401170B RID: 71435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401170C RID: 71436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0401170D RID: 71437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401170E RID: 71438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401170F RID: 71439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04011710 RID: 71440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04011711 RID: 71441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04011712 RID: 71442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04011713 RID: 71443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04011714 RID: 71444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04011715 RID: 71445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04011716 RID: 71446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04011717 RID: 71447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04011718 RID: 71448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04011719 RID: 71449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0401171A RID: 71450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0401171B RID: 71451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0401171C RID: 71452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0401171D RID: 71453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0401171E RID: 71454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0401171F RID: 71455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04011720 RID: 71456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04011721 RID: 71457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04011722 RID: 71458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04011723 RID: 71459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04011724 RID: 71460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04011725 RID: 71461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04011726 RID: 71462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04011727 RID: 71463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04011728 RID: 71464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04011729 RID: 71465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;
}
