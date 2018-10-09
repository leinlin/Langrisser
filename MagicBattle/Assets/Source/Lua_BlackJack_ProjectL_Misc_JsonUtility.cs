using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SimpleJson;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012A5 RID: 4773
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_JsonUtility : LuaObject
{
	// Token: 0x0601906A RID: 102506 RVA: 0x0071F708 File Offset: 0x0071D908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			JsonUtility o = new JsonUtility();
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

	// Token: 0x0601906B RID: 102507 RVA: 0x0071F750 File Offset: 0x0071D950
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Serialize_s(IntPtr l)
	{
		int result;
		try
		{
			object j;
			LuaObject.checkType<object>(l, 1, out j);
			string s = JsonUtility.Serialize(j);
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

	// Token: 0x0601906C RID: 102508 RVA: 0x0071F7A4 File Offset: 0x0071D9A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Deserialize_s(IntPtr l)
	{
		int result;
		try
		{
			string txt;
			LuaObject.checkType(l, 1, out txt);
			object o = JsonUtility.Deserialize(txt);
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

	// Token: 0x0601906D RID: 102509 RVA: 0x0071F7F8 File Offset: 0x0071D9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeObject_s(IntPtr l)
	{
		int result;
		try
		{
			JsonObject j;
			LuaObject.checkType<JsonObject>(l, 1, out j);
			string s = JsonUtility.SerializeObject(j);
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

	// Token: 0x0601906E RID: 102510 RVA: 0x0071F84C File Offset: 0x0071DA4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeArray_s(IntPtr l)
	{
		int result;
		try
		{
			JsonArray j;
			LuaObject.checkType<JsonArray>(l, 1, out j);
			string s = JsonUtility.SerializeArray(j);
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

	// Token: 0x0601906F RID: 102511 RVA: 0x0071F8A0 File Offset: 0x0071DAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeserializeObject_s(IntPtr l)
	{
		int result;
		try
		{
			string txt;
			LuaObject.checkType(l, 1, out txt);
			JsonObject o = JsonUtility.DeserializeObject(txt);
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

	// Token: 0x06019070 RID: 102512 RVA: 0x0071F8F4 File Offset: 0x0071DAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeserializeArray_s(IntPtr l)
	{
		int result;
		try
		{
			string txt;
			LuaObject.checkType(l, 1, out txt);
			JsonArray o = JsonUtility.DeserializeArray(txt);
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

	// Token: 0x06019071 RID: 102513 RVA: 0x0071F948 File Offset: 0x0071DB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddArray_s(IntPtr l)
	{
		int result;
		try
		{
			JsonObject j;
			LuaObject.checkType<JsonObject>(l, 1, out j);
			string key;
			LuaObject.checkType(l, 2, out key);
			JsonArray o = JsonUtility.AddArray(j, key);
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

	// Token: 0x06019072 RID: 102514 RVA: 0x0071F9A8 File Offset: 0x0071DBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddObject_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				JsonArray a;
				LuaObject.checkType<JsonArray>(l, 1, out a);
				JsonObject o = JsonUtility.AddObject(a);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				JsonObject j;
				LuaObject.checkType<JsonObject>(l, 1, out j);
				string key;
				LuaObject.checkType(l, 2, out key);
				JsonObject o2 = JsonUtility.AddObject(j, key);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddObject to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019073 RID: 102515 RVA: 0x0071FA60 File Offset: 0x0071DC60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetObject_s(IntPtr l)
	{
		int result;
		try
		{
			JsonObject j;
			LuaObject.checkType<JsonObject>(l, 1, out j);
			string key;
			LuaObject.checkType(l, 2, out key);
			JsonObject @object = JsonUtility.GetObject(j, key);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @object);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019074 RID: 102516 RVA: 0x0071FAC0 File Offset: 0x0071DCC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetArray_s(IntPtr l)
	{
		int result;
		try
		{
			JsonObject j;
			LuaObject.checkType<JsonObject>(l, 1, out j);
			string key;
			LuaObject.checkType(l, 2, out key);
			JsonArray array = JsonUtility.GetArray(j, key);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, array);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019075 RID: 102517 RVA: 0x0071FB20 File Offset: 0x0071DD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Set_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(float)))
			{
				JsonObject j;
				LuaObject.checkType<JsonObject>(l, 1, out j);
				string key;
				LuaObject.checkType(l, 2, out key);
				float value;
				LuaObject.checkType(l, 3, out value);
				JsonUtility.Set(j, key, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(double)))
			{
				JsonObject j2;
				LuaObject.checkType<JsonObject>(l, 1, out j2);
				string key2;
				LuaObject.checkType(l, 2, out key2);
				double value2;
				LuaObject.checkType(l, 3, out value2);
				JsonUtility.Set(j2, key2, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(byte)))
			{
				JsonObject j3;
				LuaObject.checkType<JsonObject>(l, 1, out j3);
				string key3;
				LuaObject.checkType(l, 2, out key3);
				byte value3;
				LuaObject.checkType(l, 3, out value3);
				JsonUtility.Set(j3, key3, value3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(DateTime)))
			{
				JsonObject j4;
				LuaObject.checkType<JsonObject>(l, 1, out j4);
				string key4;
				LuaObject.checkType(l, 2, out key4);
				DateTime value4;
				LuaObject.checkValueType<DateTime>(l, 3, out value4);
				JsonUtility.Set(j4, key4, value4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(string)))
			{
				JsonObject j5;
				LuaObject.checkType<JsonObject>(l, 1, out j5);
				string key5;
				LuaObject.checkType(l, 2, out key5);
				string value5;
				LuaObject.checkType(l, 3, out value5);
				JsonUtility.Set(j5, key5, value5);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(bool)))
			{
				JsonObject j6;
				LuaObject.checkType<JsonObject>(l, 1, out j6);
				string key6;
				LuaObject.checkType(l, 2, out key6);
				bool value6;
				LuaObject.checkType(l, 3, out value6);
				JsonUtility.Set(j6, key6, value6);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(uint)))
			{
				JsonObject j7;
				LuaObject.checkType<JsonObject>(l, 1, out j7);
				string key7;
				LuaObject.checkType(l, 2, out key7);
				uint value7;
				LuaObject.checkType(l, 3, out value7);
				JsonUtility.Set(j7, key7, value7);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(int)))
			{
				JsonObject j8;
				LuaObject.checkType<JsonObject>(l, 1, out j8);
				string key8;
				LuaObject.checkType(l, 2, out key8);
				int value8;
				LuaObject.checkType(l, 3, out value8);
				JsonUtility.Set(j8, key8, value8);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(long)))
			{
				JsonObject j9;
				LuaObject.checkType<JsonObject>(l, 1, out j9);
				string key9;
				LuaObject.checkType(l, 2, out key9);
				long value9;
				LuaObject.checkType(l, 3, out value9);
				JsonUtility.Set(j9, key9, value9);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(sbyte)))
			{
				JsonObject j10;
				LuaObject.checkType<JsonObject>(l, 1, out j10);
				string key10;
				LuaObject.checkType(l, 2, out key10);
				sbyte value10;
				LuaObject.checkType(l, 3, out value10);
				JsonUtility.Set(j10, key10, value10);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(ushort)))
			{
				JsonObject j11;
				LuaObject.checkType<JsonObject>(l, 1, out j11);
				string key11;
				LuaObject.checkType(l, 2, out key11);
				ushort value11;
				LuaObject.checkType(l, 3, out value11);
				JsonUtility.Set(j11, key11, value11);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(short)))
			{
				JsonObject j12;
				LuaObject.checkType<JsonObject>(l, 1, out j12);
				string key12;
				LuaObject.checkType(l, 2, out key12);
				short value12;
				LuaObject.checkType(l, 3, out value12);
				JsonUtility.Set(j12, key12, value12);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Set to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019076 RID: 102518 RVA: 0x00720020 File Offset: 0x0071E220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Get_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(PLong)))
			{
				JsonObject j;
				LuaObject.checkType<JsonObject>(l, 1, out j);
				string key;
				LuaObject.checkType(l, 2, out key);
				PLong p;
				LuaObject.checkValueType<PLong>(l, 3, out p);
				bool b = JsonUtility.Get(j, key, ref p);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				LuaObject.pushValue(l, p);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(PInt)))
			{
				JsonObject j2;
				LuaObject.checkType<JsonObject>(l, 1, out j2);
				string key2;
				LuaObject.checkType(l, 2, out key2);
				PInt p2;
				LuaObject.checkValueType<PInt>(l, 3, out p2);
				bool b2 = JsonUtility.Get(j2, key2, ref p2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				LuaObject.pushValue(l, p2);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(string)))
			{
				JsonObject j3;
				LuaObject.checkType<JsonObject>(l, 1, out j3);
				string key3;
				LuaObject.checkType(l, 2, out key3);
				string s;
				LuaObject.checkType(l, 3, out s);
				bool b3 = JsonUtility.Get(j3, key3, ref s);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				LuaObject.pushValue(l, s);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(DateTime)))
			{
				JsonObject j4;
				LuaObject.checkType<JsonObject>(l, 1, out j4);
				string key4;
				LuaObject.checkType(l, 2, out key4);
				DateTime dateTime;
				LuaObject.checkValueType<DateTime>(l, 3, out dateTime);
				bool b4 = JsonUtility.Get(j4, key4, ref dateTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b4);
				LuaObject.pushValue(l, dateTime);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(PUInt)))
			{
				JsonObject j5;
				LuaObject.checkType<JsonObject>(l, 1, out j5);
				string key5;
				LuaObject.checkType(l, 2, out key5);
				PUInt p3;
				LuaObject.checkValueType<PUInt>(l, 3, out p3);
				bool b5 = JsonUtility.Get(j5, key5, ref p3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b5);
				LuaObject.pushValue(l, p3);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(PSByte)))
			{
				JsonObject j6;
				LuaObject.checkType<JsonObject>(l, 1, out j6);
				string key6;
				LuaObject.checkType(l, 2, out key6);
				PSByte p4;
				LuaObject.checkValueType<PSByte>(l, 3, out p4);
				bool b6 = JsonUtility.Get(j6, key6, ref p4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b6);
				LuaObject.pushValue(l, p4);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(PByte)))
			{
				JsonObject j7;
				LuaObject.checkType<JsonObject>(l, 1, out j7);
				string key7;
				LuaObject.checkType(l, 2, out key7);
				PByte p5;
				LuaObject.checkValueType<PByte>(l, 3, out p5);
				bool b7 = JsonUtility.Get(j7, key7, ref p5);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b7);
				LuaObject.pushValue(l, p5);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(PShort)))
			{
				JsonObject j8;
				LuaObject.checkType<JsonObject>(l, 1, out j8);
				string key8;
				LuaObject.checkType(l, 2, out key8);
				PShort p6;
				LuaObject.checkValueType<PShort>(l, 3, out p6);
				bool b8 = JsonUtility.Get(j8, key8, ref p6);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b8);
				LuaObject.pushValue(l, p6);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(PUShort)))
			{
				JsonObject j9;
				LuaObject.checkType<JsonObject>(l, 1, out j9);
				string key9;
				LuaObject.checkType(l, 2, out key9);
				PUShort p7;
				LuaObject.checkValueType<PUShort>(l, 3, out p7);
				bool b9 = JsonUtility.Get(j9, key9, ref p7);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b9);
				LuaObject.pushValue(l, p7);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(bool)))
			{
				JsonObject j10;
				LuaObject.checkType<JsonObject>(l, 1, out j10);
				string key10;
				LuaObject.checkType(l, 2, out key10);
				bool b10;
				LuaObject.checkType(l, 3, out b10);
				bool b11 = JsonUtility.Get(j10, key10, ref b10);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b11);
				LuaObject.pushValue(l, b10);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(uint)))
			{
				JsonObject j11;
				LuaObject.checkType<JsonObject>(l, 1, out j11);
				string key11;
				LuaObject.checkType(l, 2, out key11);
				uint o;
				LuaObject.checkType(l, 3, out o);
				bool b12 = JsonUtility.Get(j11, key11, ref o);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b12);
				LuaObject.pushValue(l, o);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(short)))
			{
				JsonObject j12;
				LuaObject.checkType<JsonObject>(l, 1, out j12);
				string key12;
				LuaObject.checkType(l, 2, out key12);
				short i;
				LuaObject.checkType(l, 3, out i);
				bool b13 = JsonUtility.Get(j12, key12, ref i);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b13);
				LuaObject.pushValue(l, i);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(long)))
			{
				JsonObject j13;
				LuaObject.checkType<JsonObject>(l, 1, out j13);
				string key13;
				LuaObject.checkType(l, 2, out key13);
				long i2;
				LuaObject.checkType(l, 3, out i2);
				bool b14 = JsonUtility.Get(j13, key13, ref i2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b14);
				LuaObject.pushValue(l, i2);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(int)))
			{
				JsonObject j14;
				LuaObject.checkType<JsonObject>(l, 1, out j14);
				string key14;
				LuaObject.checkType(l, 2, out key14);
				int i3;
				LuaObject.checkType(l, 3, out i3);
				bool b15 = JsonUtility.Get(j14, key14, ref i3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b15);
				LuaObject.pushValue(l, i3);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(ushort)))
			{
				JsonObject j15;
				LuaObject.checkType<JsonObject>(l, 1, out j15);
				string key15;
				LuaObject.checkType(l, 2, out key15);
				ushort v;
				LuaObject.checkType(l, 3, out v);
				bool b16 = JsonUtility.Get(j15, key15, ref v);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b16);
				LuaObject.pushValue(l, v);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(double)))
			{
				JsonObject j16;
				LuaObject.checkType<JsonObject>(l, 1, out j16);
				string key16;
				LuaObject.checkType(l, 2, out key16);
				double d;
				LuaObject.checkType(l, 3, out d);
				bool b17 = JsonUtility.Get(j16, key16, ref d);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b17);
				LuaObject.pushValue(l, d);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(float)))
			{
				JsonObject j17;
				LuaObject.checkType<JsonObject>(l, 1, out j17);
				string key17;
				LuaObject.checkType(l, 2, out key17);
				float o2;
				LuaObject.checkType(l, 3, out o2);
				bool b18 = JsonUtility.Get(j17, key17, ref o2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b18);
				LuaObject.pushValue(l, o2);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(sbyte)))
			{
				JsonObject j18;
				LuaObject.checkType<JsonObject>(l, 1, out j18);
				string key18;
				LuaObject.checkType(l, 2, out key18);
				sbyte v2;
				LuaObject.checkType(l, 3, out v2);
				bool b19 = JsonUtility.Get(j18, key18, ref v2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b19);
				LuaObject.pushValue(l, v2);
				result = 3;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(JsonObject), typeof(string), typeof(byte)))
			{
				JsonObject j19;
				LuaObject.checkType<JsonObject>(l, 1, out j19);
				string key19;
				LuaObject.checkType(l, 2, out key19);
				byte i4;
				LuaObject.checkType(l, 3, out i4);
				bool b20 = JsonUtility.Get(j19, key19, ref i4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b20);
				LuaObject.pushValue(l, i4);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Get to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019077 RID: 102519 RVA: 0x00720954 File Offset: 0x0071EB54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.JsonUtility");
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.Serialize_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.Deserialize_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.SerializeObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.SerializeArray_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.DeserializeObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.DeserializeArray_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.AddArray_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.AddObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.GetObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.GetArray_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.Set_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.Get_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_JsonUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_JsonUtility.<>f__mg$cacheC, typeof(JsonUtility));
	}

	// Token: 0x0400F502 RID: 62722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F503 RID: 62723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F504 RID: 62724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F505 RID: 62725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F506 RID: 62726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F507 RID: 62727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F508 RID: 62728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F509 RID: 62729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F50A RID: 62730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F50B RID: 62731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F50C RID: 62732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F50D RID: 62733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F50E RID: 62734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
