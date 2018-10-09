using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001440 RID: 5184
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FetterSkillUnlockNetTask : LuaObject
{
	// Token: 0x0601DDA9 RID: 122281 RVA: 0x009867C0 File Offset: 0x009849C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			FetterSkillUnlockNetTask o = new FetterSkillUnlockNetTask(heroId, fetterId);
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

	// Token: 0x0601DDAA RID: 122282 RVA: 0x00986820 File Offset: 0x00984A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			FetterSkillUnlockNetTask fetterSkillUnlockNetTask = (FetterSkillUnlockNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fetterSkillUnlockNetTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDAB RID: 122283 RVA: 0x00986874 File Offset: 0x00984A74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FetterSkillUnlockNetTask");
		string name = "Rewards";
		if (Lua_BlackJack_ProjectL_UI_FetterSkillUnlockNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FetterSkillUnlockNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FetterSkillUnlockNetTask.get_Rewards);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_FetterSkillUnlockNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_FetterSkillUnlockNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FetterSkillUnlockNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FetterSkillUnlockNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FetterSkillUnlockNetTask.<>f__mg$cache1, typeof(FetterSkillUnlockNetTask), typeof(UINetTask));
	}

	// Token: 0x04013F0B RID: 81675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013F0C RID: 81676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
