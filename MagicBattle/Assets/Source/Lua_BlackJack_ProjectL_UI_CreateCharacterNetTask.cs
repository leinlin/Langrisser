using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200140B RID: 5131
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CreateCharacterNetTask : LuaObject
{
	// Token: 0x0601CFD1 RID: 118737 RVA: 0x00917898 File Offset: 0x00915A98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string charactorName;
			LuaObject.checkType(l, 2, out charactorName);
			CreateCharacterNetTask o = new CreateCharacterNetTask(charactorName);
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

	// Token: 0x0601CFD2 RID: 118738 RVA: 0x009178EC File Offset: 0x00915AEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Result(IntPtr l)
	{
		int result;
		try
		{
			CreateCharacterNetTask createCharacterNetTask = (CreateCharacterNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createCharacterNetTask.Result);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CFD3 RID: 118739 RVA: 0x00917940 File Offset: 0x00915B40
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CreateCharacterNetTask");
		string name = "Result";
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterNetTask.get_Result);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_CreateCharacterNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_CreateCharacterNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateCharacterNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateCharacterNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_CreateCharacterNetTask.<>f__mg$cache1, typeof(CreateCharacterNetTask), typeof(NetWorkTransactionTask));
	}

	// Token: 0x0401319D RID: 78237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401319E RID: 78238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
