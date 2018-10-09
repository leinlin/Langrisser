using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020015ED RID: 5613
[Preserve]
public class Lua_BlackJack_ProjectLBasic_DialogBox : LuaObject
{
	// Token: 0x060227AF RID: 141231 RVA: 0x00BD2AC0 File Offset: 0x00BD0CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show(IntPtr l)
	{
		int result;
		try
		{
			DialogBox dialogBox = (DialogBox)LuaObject.checkSelf(l);
			string msgText;
			LuaObject.checkType(l, 2, out msgText);
			string okText;
			LuaObject.checkType(l, 3, out okText);
			string cancelText;
			LuaObject.checkType(l, 4, out cancelText);
			Action<DialogBoxResult> callback;
			LuaObject.checkDelegate<Action<DialogBoxResult>>(l, 5, out callback);
			dialogBox.Show(msgText, okText, cancelText, callback);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227B0 RID: 141232 RVA: 0x00BD2B40 File Offset: 0x00BD0D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			DialogBox dialogBox = (DialogBox)LuaObject.checkSelf(l);
			dialogBox.Initialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227B1 RID: 141233 RVA: 0x00BD2B8C File Offset: 0x00BD0D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Cancel(IntPtr l)
	{
		int result;
		try
		{
			DialogBox dialogBox = (DialogBox)LuaObject.checkSelf(l);
			bool b = dialogBox.Cancel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227B2 RID: 141234 RVA: 0x00BD2BE0 File Offset: 0x00BD0DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject parentObj;
			LuaObject.checkType<GameObject>(l, 1, out parentObj);
			string prefabPath;
			LuaObject.checkType(l, 2, out prefabPath);
			string msgText;
			LuaObject.checkType(l, 3, out msgText);
			string okText;
			LuaObject.checkType(l, 4, out okText);
			string cancelText;
			LuaObject.checkType(l, 5, out cancelText);
			Action<DialogBoxResult> onClose;
			LuaObject.checkDelegate<Action<DialogBoxResult>>(l, 6, out onClose);
			IEnumerator o = DialogBox.Show(parentObj, prefabPath, msgText, okText, cancelText, onClose);
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

	// Token: 0x060227B3 RID: 141235 RVA: 0x00BD2C74 File Offset: 0x00BD0E74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectLBasic.DialogBox");
		if (Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DialogBox.Show);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DialogBox.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DialogBox.Cancel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DialogBox.Show_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_DialogBox.<>f__mg$cache3);
		LuaObject.createTypeMetatable(l, null, typeof(DialogBox), typeof(MonoBehaviour));
	}

	// Token: 0x040185B7 RID: 99767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185B8 RID: 99768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185B9 RID: 99769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185BA RID: 99770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
