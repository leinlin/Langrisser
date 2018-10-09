using System;
using System.Runtime.CompilerServices;
using System.Text;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001884 RID: 6276
[Preserve]
public class Lua_UnityEngine_WWWForm : LuaObject
{
	// Token: 0x0602447D RID: 148605 RVA: 0x00CC1970 File Offset: 0x00CBFB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			WWWForm o = new WWWForm();
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

	// Token: 0x0602447E RID: 148606 RVA: 0x00CC19B8 File Offset: 0x00CBFBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddField(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(string), typeof(int)))
			{
				WWWForm wwwform = (WWWForm)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				int i;
				LuaObject.checkType(l, 3, out i);
				wwwform.AddField(fieldName, i);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(string)))
			{
				WWWForm wwwform2 = (WWWForm)LuaObject.checkSelf(l);
				string fieldName2;
				LuaObject.checkType(l, 2, out fieldName2);
				string value;
				LuaObject.checkType(l, 3, out value);
				wwwform2.AddField(fieldName2, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				WWWForm wwwform3 = (WWWForm)LuaObject.checkSelf(l);
				string fieldName3;
				LuaObject.checkType(l, 2, out fieldName3);
				string value2;
				LuaObject.checkType(l, 3, out value2);
				Encoding e;
				LuaObject.checkType<Encoding>(l, 4, out e);
				wwwform3.AddField(fieldName3, value2, e);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddField to call");
				result = 2;
			}
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0602447F RID: 148607 RVA: 0x00CC1B18 File Offset: 0x00CBFD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddBinaryData(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				WWWForm wwwform = (WWWForm)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				byte[] contents;
				LuaObject.checkArray<byte>(l, 3, out contents);
				wwwform.AddBinaryData(fieldName, contents);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				WWWForm wwwform2 = (WWWForm)LuaObject.checkSelf(l);
				string fieldName2;
				LuaObject.checkType(l, 2, out fieldName2);
				byte[] contents2;
				LuaObject.checkArray<byte>(l, 3, out contents2);
				string fileName;
				LuaObject.checkType(l, 4, out fileName);
				wwwform2.AddBinaryData(fieldName2, contents2, fileName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				WWWForm wwwform3 = (WWWForm)LuaObject.checkSelf(l);
				string fieldName3;
				LuaObject.checkType(l, 2, out fieldName3);
				byte[] contents3;
				LuaObject.checkArray<byte>(l, 3, out contents3);
				string fileName2;
				LuaObject.checkType(l, 4, out fileName2);
				string mimeType;
				LuaObject.checkType(l, 5, out mimeType);
				wwwform3.AddBinaryData(fieldName3, contents3, fileName2, mimeType);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddBinaryData to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024480 RID: 148608 RVA: 0x00CC1C5C File Offset: 0x00CBFE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_headers(IntPtr l)
	{
		int result;
		try
		{
			WWWForm wwwform = (WWWForm)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wwwform.headers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024481 RID: 148609 RVA: 0x00CC1CB0 File Offset: 0x00CBFEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_data(IntPtr l)
	{
		int result;
		try
		{
			WWWForm wwwform = (WWWForm)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wwwform.data);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024482 RID: 148610 RVA: 0x00CC1D04 File Offset: 0x00CBFF04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.WWWForm");
		if (Lua_UnityEngine_WWWForm.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_WWWForm.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_WWWForm.AddField);
		}
		LuaObject.addMember(l, Lua_UnityEngine_WWWForm.<>f__mg$cache0);
		if (Lua_UnityEngine_WWWForm.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_WWWForm.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_WWWForm.AddBinaryData);
		}
		LuaObject.addMember(l, Lua_UnityEngine_WWWForm.<>f__mg$cache1);
		string name = "headers";
		if (Lua_UnityEngine_WWWForm.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_WWWForm.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_WWWForm.get_headers);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_WWWForm.<>f__mg$cache2, null, true);
		string name2 = "data";
		if (Lua_UnityEngine_WWWForm.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_WWWForm.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_WWWForm.get_data);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_WWWForm.<>f__mg$cache3, null, true);
		if (Lua_UnityEngine_WWWForm.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_WWWForm.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_WWWForm.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_WWWForm.<>f__mg$cache4, typeof(WWWForm));
	}

	// Token: 0x04019FD3 RID: 106451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019FD4 RID: 106452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019FD5 RID: 106453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019FD6 RID: 106454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019FD7 RID: 106455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
