using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001483 RID: 5251
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController : LuaObject
{
	// Token: 0x0601E4FA RID: 124154 RVA: 0x009BF998 File Offset: 0x009BDB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitItemInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			GuildLog log;
			LuaObject.checkType<GuildLog>(l, 2, out log);
			guildJournalItemUIController.InitItemInfo(log);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4FB RID: 124155 RVA: 0x009BF9F0 File Offset: 0x009BDBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			guildJournalItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4FC RID: 124156 RVA: 0x009BFA44 File Offset: 0x009BDC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildJournalItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4FD RID: 124157 RVA: 0x009BFAB0 File Offset: 0x009BDCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			guildJournalItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4FE RID: 124158 RVA: 0x009BFB04 File Offset: 0x009BDD04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			guildJournalItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4FF RID: 124159 RVA: 0x009BFB58 File Offset: 0x009BDD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildJournalItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E500 RID: 124160 RVA: 0x009BFC00 File Offset: 0x009BDE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			guildJournalItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E501 RID: 124161 RVA: 0x009BFC54 File Offset: 0x009BDE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildJournalItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E502 RID: 124162 RVA: 0x009BFCC0 File Offset: 0x009BDEC0
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
				GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildJournalItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildJournalItemUIController guildJournalItemUIController2 = (GuildJournalItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildJournalItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E503 RID: 124163 RVA: 0x009BFDD0 File Offset: 0x009BDFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildJournalItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E504 RID: 124164 RVA: 0x009BFE3C File Offset: 0x009BE03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildJournalItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E505 RID: 124165 RVA: 0x009BFEA8 File Offset: 0x009BE0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildJournalItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E506 RID: 124166 RVA: 0x009BFF14 File Offset: 0x009BE114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildJournalItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E507 RID: 124167 RVA: 0x009BFF80 File Offset: 0x009BE180
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
				GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildJournalItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildJournalItemUIController guildJournalItemUIController2 = (GuildJournalItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildJournalItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E508 RID: 124168 RVA: 0x009C0090 File Offset: 0x009BE290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			string s = guildJournalItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E509 RID: 124169 RVA: 0x009C00EC File Offset: 0x009BE2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dateText(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildJournalItemUIController.m_luaExportHelper.m_dateText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E50A RID: 124170 RVA: 0x009C0144 File Offset: 0x009BE344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_dateText(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			Text dateText;
			LuaObject.checkType<Text>(l, 2, out dateText);
			guildJournalItemUIController.m_luaExportHelper.m_dateText = dateText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E50B RID: 124171 RVA: 0x009C01A0 File Offset: 0x009BE3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoText(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildJournalItemUIController.m_luaExportHelper.m_infoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E50C RID: 124172 RVA: 0x009C01F8 File Offset: 0x009BE3F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_infoText(IntPtr l)
	{
		int result;
		try
		{
			GuildJournalItemUIController guildJournalItemUIController = (GuildJournalItemUIController)LuaObject.checkSelf(l);
			Text infoText;
			LuaObject.checkType<Text>(l, 2, out infoText);
			guildJournalItemUIController.m_luaExportHelper.m_infoText = infoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E50D RID: 124173 RVA: 0x009C0254 File Offset: 0x009BE454
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildJournalItemUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.InitItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheE);
		string name = "m_dateText";
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.get_m_dateText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.set_m_dateText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache10, true);
		string name2 = "m_infoText";
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.get_m_infoText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.set_m_infoText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.<>f__mg$cache12, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildJournalItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040145D6 RID: 83414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040145D7 RID: 83415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040145D8 RID: 83416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040145D9 RID: 83417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040145DA RID: 83418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040145DB RID: 83419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040145DC RID: 83420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040145DD RID: 83421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040145DE RID: 83422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040145DF RID: 83423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040145E0 RID: 83424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040145E1 RID: 83425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040145E2 RID: 83426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040145E3 RID: 83427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040145E4 RID: 83428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040145E5 RID: 83429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040145E6 RID: 83430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040145E7 RID: 83431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040145E8 RID: 83432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
