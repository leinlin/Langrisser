using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200129F RID: 4767
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_CLZF : LuaObject
{
	// Token: 0x0601902F RID: 102447 RVA: 0x0071DFE0 File Offset: 0x0071C1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CLZF o = new CLZF();
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

	// Token: 0x06019030 RID: 102448 RVA: 0x0071E028 File Offset: 0x0071C228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Compress_s(IntPtr l)
	{
		int result;
		try
		{
			byte[] inputBytes;
			LuaObject.checkArray<byte>(l, 1, out inputBytes);
			byte[] a = CLZF.Compress(inputBytes);
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

	// Token: 0x06019031 RID: 102449 RVA: 0x0071E07C File Offset: 0x0071C27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Decompress_s(IntPtr l)
	{
		int result;
		try
		{
			byte[] inputBytes;
			LuaObject.checkArray<byte>(l, 1, out inputBytes);
			byte[] a = CLZF.Decompress(inputBytes);
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

	// Token: 0x06019032 RID: 102450 RVA: 0x0071E0D0 File Offset: 0x0071C2D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int lzf_compress_s(IntPtr l)
	{
		int result;
		try
		{
			byte[] input;
			LuaObject.checkArray<byte>(l, 1, out input);
			byte[] a;
			LuaObject.checkType<byte[]>(l, 2, out a);
			int i = CLZF.lzf_compress(input, ref a);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, a);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019033 RID: 102451 RVA: 0x0071E138 File Offset: 0x0071C338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int lzf_decompress_s(IntPtr l)
	{
		int result;
		try
		{
			byte[] input;
			LuaObject.checkArray<byte>(l, 1, out input);
			byte[] a;
			LuaObject.checkType<byte[]>(l, 2, out a);
			int i = CLZF.lzf_decompress(input, ref a);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, a);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019034 RID: 102452 RVA: 0x0071E1A0 File Offset: 0x0071C3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HLOG(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CLZF.LuaExportHelper.HLOG);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019035 RID: 102453 RVA: 0x0071E1E8 File Offset: 0x0071C3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HSIZE(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CLZF.LuaExportHelper.HSIZE);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019036 RID: 102454 RVA: 0x0071E230 File Offset: 0x0071C430
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MAX_LIT(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CLZF.LuaExportHelper.MAX_LIT);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019037 RID: 102455 RVA: 0x0071E278 File Offset: 0x0071C478
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MAX_OFF(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CLZF.LuaExportHelper.MAX_OFF);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019038 RID: 102456 RVA: 0x0071E2C0 File Offset: 0x0071C4C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MAX_REF(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CLZF.LuaExportHelper.MAX_REF);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019039 RID: 102457 RVA: 0x0071E308 File Offset: 0x0071C508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HashTable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CLZF.LuaExportHelper.HashTable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601903A RID: 102458 RVA: 0x0071E350 File Offset: 0x0071C550
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.CLZF");
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.Compress_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.Decompress_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.lzf_compress_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.lzf_decompress_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache3);
		string name = "HLOG";
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.get_HLOG);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache4, null, false);
		string name2 = "HSIZE";
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.get_HSIZE);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache5, null, false);
		string name3 = "MAX_LIT";
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.get_MAX_LIT);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache6, null, false);
		string name4 = "MAX_OFF";
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.get_MAX_OFF);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache7, null, false);
		string name5 = "MAX_REF";
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.get_MAX_REF);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache8, null, false);
		string name6 = "HashTable";
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.get_HashTable);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cache9, null, false);
		if (Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_CLZF.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_CLZF.<>f__mg$cacheA, typeof(CLZF));
	}

	// Token: 0x0400F4D3 RID: 62675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F4D4 RID: 62676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F4D5 RID: 62677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F4D6 RID: 62678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F4D7 RID: 62679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F4D8 RID: 62680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F4D9 RID: 62681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F4DA RID: 62682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F4DB RID: 62683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F4DC RID: 62684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F4DD RID: 62685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
