using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200155E RID: 5470
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController : LuaObject
{
	// Token: 0x06020BB0 RID: 134064 RVA: 0x00AF39A4 File Offset: 0x00AF1BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHardMode(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			bool hardMode;
			LuaObject.checkType(l, 2, out hardMode);
			riftBackgroundUIController.SetHardMode(hardMode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BB1 RID: 134065 RVA: 0x00AF39FC File Offset: 0x00AF1BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			riftBackgroundUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BB2 RID: 134066 RVA: 0x00AF3A50 File Offset: 0x00AF1C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			riftBackgroundUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BB3 RID: 134067 RVA: 0x00AF3ABC File Offset: 0x00AF1CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			riftBackgroundUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BB4 RID: 134068 RVA: 0x00AF3B10 File Offset: 0x00AF1D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			riftBackgroundUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BB5 RID: 134069 RVA: 0x00AF3B64 File Offset: 0x00AF1D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = riftBackgroundUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020BB6 RID: 134070 RVA: 0x00AF3C0C File Offset: 0x00AF1E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			riftBackgroundUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BB7 RID: 134071 RVA: 0x00AF3C60 File Offset: 0x00AF1E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			riftBackgroundUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BB8 RID: 134072 RVA: 0x00AF3CCC File Offset: 0x00AF1ECC
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
				RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				riftBackgroundUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RiftBackgroundUIController riftBackgroundUIController2 = (RiftBackgroundUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				riftBackgroundUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020BB9 RID: 134073 RVA: 0x00AF3DDC File Offset: 0x00AF1FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftBackgroundUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BBA RID: 134074 RVA: 0x00AF3E48 File Offset: 0x00AF2048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftBackgroundUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BBB RID: 134075 RVA: 0x00AF3EB4 File Offset: 0x00AF20B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftBackgroundUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BBC RID: 134076 RVA: 0x00AF3F20 File Offset: 0x00AF2120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftBackgroundUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BBD RID: 134077 RVA: 0x00AF3F8C File Offset: 0x00AF218C
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
				RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				riftBackgroundUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RiftBackgroundUIController riftBackgroundUIController2 = (RiftBackgroundUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				riftBackgroundUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020BBE RID: 134078 RVA: 0x00AF409C File Offset: 0x00AF229C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			string s = riftBackgroundUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020BBF RID: 134079 RVA: 0x00AF40F8 File Offset: 0x00AF22F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_animator(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftBackgroundUIController.m_luaExportHelper.m_animator);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BC0 RID: 134080 RVA: 0x00AF4150 File Offset: 0x00AF2350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_animator(IntPtr l)
	{
		int result;
		try
		{
			RiftBackgroundUIController riftBackgroundUIController = (RiftBackgroundUIController)LuaObject.checkSelf(l);
			Animator animator;
			LuaObject.checkType<Animator>(l, 2, out animator);
			riftBackgroundUIController.m_luaExportHelper.m_animator = animator;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BC1 RID: 134081 RVA: 0x00AF41AC File Offset: 0x00AF23AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftBackgroundUIController");
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.SetHardMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheE);
		string name = "m_animator";
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.get_m_animator);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.set_m_animator);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.<>f__mg$cache10, true);
		LuaObject.createTypeMetatable(l, null, typeof(RiftBackgroundUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016AD6 RID: 92886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016AD7 RID: 92887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016AD8 RID: 92888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016AD9 RID: 92889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016ADA RID: 92890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016ADB RID: 92891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016ADC RID: 92892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016ADD RID: 92893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016ADE RID: 92894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016ADF RID: 92895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016AE0 RID: 92896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016AE1 RID: 92897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016AE2 RID: 92898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016AE3 RID: 92899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016AE4 RID: 92900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016AE5 RID: 92901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016AE6 RID: 92902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
