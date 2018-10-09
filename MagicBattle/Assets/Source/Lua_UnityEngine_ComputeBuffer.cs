using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001670 RID: 5744
[Preserve]
public class Lua_UnityEngine_ComputeBuffer : LuaObject
{
	// Token: 0x06022F18 RID: 143128 RVA: 0x00C16858 File Offset: 0x00C14A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				int count;
				LuaObject.checkType(l, 2, out count);
				int stride;
				LuaObject.checkType(l, 3, out stride);
				ComputeBuffer o = new ComputeBuffer(count, stride);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				int count2;
				LuaObject.checkType(l, 2, out count2);
				int stride2;
				LuaObject.checkType(l, 3, out stride2);
				ComputeBufferType type;
				LuaObject.checkEnum<ComputeBufferType>(l, 4, out type);
				ComputeBuffer o = new ComputeBuffer(count2, stride2, type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F19 RID: 143129 RVA: 0x00C16924 File Offset: 0x00C14B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			ComputeBuffer computeBuffer = (ComputeBuffer)LuaObject.checkSelf(l);
			computeBuffer.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F1A RID: 143130 RVA: 0x00C16970 File Offset: 0x00C14B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Release(IntPtr l)
	{
		int result;
		try
		{
			ComputeBuffer computeBuffer = (ComputeBuffer)LuaObject.checkSelf(l);
			computeBuffer.Release();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F1B RID: 143131 RVA: 0x00C169BC File Offset: 0x00C14BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetData(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				ComputeBuffer computeBuffer = (ComputeBuffer)LuaObject.checkSelf(l);
				Array data;
				LuaObject.checkType<Array>(l, 2, out data);
				computeBuffer.SetData(data);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				ComputeBuffer computeBuffer2 = (ComputeBuffer)LuaObject.checkSelf(l);
				Array data2;
				LuaObject.checkType<Array>(l, 2, out data2);
				int managedBufferStartIndex;
				LuaObject.checkType(l, 3, out managedBufferStartIndex);
				int computeBufferStartIndex;
				LuaObject.checkType(l, 4, out computeBufferStartIndex);
				int count;
				LuaObject.checkType(l, 5, out count);
				computeBuffer2.SetData(data2, managedBufferStartIndex, computeBufferStartIndex, count);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetData to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F1C RID: 143132 RVA: 0x00C16A98 File Offset: 0x00C14C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetData(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				ComputeBuffer computeBuffer = (ComputeBuffer)LuaObject.checkSelf(l);
				Array data;
				LuaObject.checkType<Array>(l, 2, out data);
				computeBuffer.GetData(data);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				ComputeBuffer computeBuffer2 = (ComputeBuffer)LuaObject.checkSelf(l);
				Array data2;
				LuaObject.checkType<Array>(l, 2, out data2);
				int managedBufferStartIndex;
				LuaObject.checkType(l, 3, out managedBufferStartIndex);
				int computeBufferStartIndex;
				LuaObject.checkType(l, 4, out computeBufferStartIndex);
				int count;
				LuaObject.checkType(l, 5, out count);
				computeBuffer2.GetData(data2, managedBufferStartIndex, computeBufferStartIndex, count);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetData to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F1D RID: 143133 RVA: 0x00C16B74 File Offset: 0x00C14D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCounterValue(IntPtr l)
	{
		int result;
		try
		{
			ComputeBuffer computeBuffer = (ComputeBuffer)LuaObject.checkSelf(l);
			uint counterValue;
			LuaObject.checkType(l, 2, out counterValue);
			computeBuffer.SetCounterValue(counterValue);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F1E RID: 143134 RVA: 0x00C16BCC File Offset: 0x00C14DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNativeBufferPtr(IntPtr l)
	{
		int result;
		try
		{
			ComputeBuffer computeBuffer = (ComputeBuffer)LuaObject.checkSelf(l);
			IntPtr nativeBufferPtr = computeBuffer.GetNativeBufferPtr();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nativeBufferPtr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F1F RID: 143135 RVA: 0x00C16C28 File Offset: 0x00C14E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CopyCount_s(IntPtr l)
	{
		int result;
		try
		{
			ComputeBuffer src;
			LuaObject.checkType<ComputeBuffer>(l, 1, out src);
			ComputeBuffer dst;
			LuaObject.checkType<ComputeBuffer>(l, 2, out dst);
			int dstOffsetBytes;
			LuaObject.checkType(l, 3, out dstOffsetBytes);
			ComputeBuffer.CopyCount(src, dst, dstOffsetBytes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F20 RID: 143136 RVA: 0x00C16C8C File Offset: 0x00C14E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_count(IntPtr l)
	{
		int result;
		try
		{
			ComputeBuffer computeBuffer = (ComputeBuffer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, computeBuffer.count);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F21 RID: 143137 RVA: 0x00C16CE0 File Offset: 0x00C14EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_stride(IntPtr l)
	{
		int result;
		try
		{
			ComputeBuffer computeBuffer = (ComputeBuffer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, computeBuffer.stride);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F22 RID: 143138 RVA: 0x00C16D34 File Offset: 0x00C14F34
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ComputeBuffer");
		if (Lua_UnityEngine_ComputeBuffer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ComputeBuffer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ComputeBuffer.Dispose);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeBuffer.<>f__mg$cache0);
		if (Lua_UnityEngine_ComputeBuffer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ComputeBuffer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ComputeBuffer.Release);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeBuffer.<>f__mg$cache1);
		if (Lua_UnityEngine_ComputeBuffer.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ComputeBuffer.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ComputeBuffer.SetData);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeBuffer.<>f__mg$cache2);
		if (Lua_UnityEngine_ComputeBuffer.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ComputeBuffer.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ComputeBuffer.GetData);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeBuffer.<>f__mg$cache3);
		if (Lua_UnityEngine_ComputeBuffer.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ComputeBuffer.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ComputeBuffer.SetCounterValue);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeBuffer.<>f__mg$cache4);
		if (Lua_UnityEngine_ComputeBuffer.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ComputeBuffer.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ComputeBuffer.GetNativeBufferPtr);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeBuffer.<>f__mg$cache5);
		if (Lua_UnityEngine_ComputeBuffer.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_ComputeBuffer.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_ComputeBuffer.CopyCount_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeBuffer.<>f__mg$cache6);
		string name = "count";
		if (Lua_UnityEngine_ComputeBuffer.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_ComputeBuffer.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_ComputeBuffer.get_count);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_ComputeBuffer.<>f__mg$cache7, null, true);
		string name2 = "stride";
		if (Lua_UnityEngine_ComputeBuffer.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_ComputeBuffer.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_ComputeBuffer.get_stride);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_ComputeBuffer.<>f__mg$cache8, null, true);
		if (Lua_UnityEngine_ComputeBuffer.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_ComputeBuffer.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_ComputeBuffer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ComputeBuffer.<>f__mg$cache9, typeof(ComputeBuffer));
	}

	// Token: 0x04018E96 RID: 102038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E97 RID: 102039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E98 RID: 102040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E99 RID: 102041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E9A RID: 102042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E9B RID: 102043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E9C RID: 102044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E9D RID: 102045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018E9E RID: 102046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018E9F RID: 102047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
