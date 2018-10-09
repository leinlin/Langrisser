using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012A0 RID: 4768
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_FileUtility : LuaObject
{
	// Token: 0x0601903C RID: 102460 RVA: 0x0071E528 File Offset: 0x0071C728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FileUtility o = new FileUtility();
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

	// Token: 0x0601903D RID: 102461 RVA: 0x0071E570 File Offset: 0x0071C770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReadText_s(IntPtr l)
	{
		int result;
		try
		{
			string fname;
			LuaObject.checkType(l, 1, out fname);
			string s = FileUtility.ReadText(fname);
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

	// Token: 0x0601903E RID: 102462 RVA: 0x0071E5C4 File Offset: 0x0071C7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WriteText_s(IntPtr l)
	{
		int result;
		try
		{
			string fname;
			LuaObject.checkType(l, 1, out fname);
			string txt;
			LuaObject.checkType(l, 2, out txt);
			bool b = FileUtility.WriteText(fname, txt);
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

	// Token: 0x0601903F RID: 102463 RVA: 0x0071E624 File Offset: 0x0071C824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReadBytes_s(IntPtr l)
	{
		int result;
		try
		{
			string fname;
			LuaObject.checkType(l, 1, out fname);
			byte[] a = FileUtility.ReadBytes(fname);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, a);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019040 RID: 102464 RVA: 0x0071E678 File Offset: 0x0071C878
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WriteBytes_s(IntPtr l)
	{
		int result;
		try
		{
			string fname;
			LuaObject.checkType(l, 1, out fname);
			byte[] bytes;
			LuaObject.checkArray<byte>(l, 2, out bytes);
			bool b = FileUtility.WriteBytes(fname, bytes);
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

	// Token: 0x06019041 RID: 102465 RVA: 0x0071E6D8 File Offset: 0x0071C8D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeleteFile_s(IntPtr l)
	{
		int result;
		try
		{
			string fname;
			LuaObject.checkType(l, 1, out fname);
			bool b = FileUtility.DeleteFile(fname);
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

	// Token: 0x06019042 RID: 102466 RVA: 0x0071E72C File Offset: 0x0071C92C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsFileExist_s(IntPtr l)
	{
		int result;
		try
		{
			string fname;
			LuaObject.checkType(l, 1, out fname);
			bool b = FileUtility.IsFileExist(fname);
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

	// Token: 0x06019043 RID: 102467 RVA: 0x0071E780 File Offset: 0x0071C980
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.FileUtility");
		if (Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_FileUtility.ReadText_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_FileUtility.WriteText_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_FileUtility.ReadBytes_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_FileUtility.WriteBytes_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_FileUtility.DeleteFile_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_FileUtility.IsFileExist_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_FileUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_FileUtility.<>f__mg$cache6, typeof(FileUtility));
	}

	// Token: 0x0400F4DE RID: 62686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F4DF RID: 62687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F4E0 RID: 62688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F4E1 RID: 62689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F4E2 RID: 62690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F4E3 RID: 62691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F4E4 RID: 62692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
