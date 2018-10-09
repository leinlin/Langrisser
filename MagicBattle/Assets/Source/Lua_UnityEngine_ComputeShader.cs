using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001672 RID: 5746
[Preserve]
public class Lua_UnityEngine_ComputeShader : LuaObject
{
	// Token: 0x06022F26 RID: 143142 RVA: 0x00C16F54 File Offset: 0x00C15154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ComputeShader o = new ComputeShader();
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

	// Token: 0x06022F27 RID: 143143 RVA: 0x00C16F9C File Offset: 0x00C1519C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindKernel(IntPtr l)
	{
		int result;
		try
		{
			ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int i = computeShader.FindKernel(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F28 RID: 143144 RVA: 0x00C17000 File Offset: 0x00C15200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasKernel(IntPtr l)
	{
		int result;
		try
		{
			ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool b = computeShader.HasKernel(name);
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

	// Token: 0x06022F29 RID: 143145 RVA: 0x00C17064 File Offset: 0x00C15264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetKernelThreadGroupSizes(IntPtr l)
	{
		int result;
		try
		{
			ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
			int kernelIndex;
			LuaObject.checkType(l, 2, out kernelIndex);
			uint o;
			uint o2;
			uint o3;
			computeShader.GetKernelThreadGroupSizes(kernelIndex, out o, out o2, out o3);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, o2);
			LuaObject.pushValue(l, o3);
			result = 4;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F2A RID: 143146 RVA: 0x00C170DC File Offset: 0x00C152DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFloat(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float)))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float val;
				LuaObject.checkType(l, 3, out val);
				computeShader.SetFloat(nameID, val);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float val2;
				LuaObject.checkType(l, 3, out val2);
				computeShader2.SetFloat(name, val2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetFloat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F2B RID: 143147 RVA: 0x00C171E4 File Offset: 0x00C153E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInt(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int)))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				int val;
				LuaObject.checkType(l, 3, out val);
				computeShader.SetInt(nameID, val);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int)))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				int val2;
				LuaObject.checkType(l, 3, out val2);
				computeShader2.SetInt(name, val2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetInt to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F2C RID: 143148 RVA: 0x00C172EC File Offset: 0x00C154EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBool(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(bool)))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				bool val;
				LuaObject.checkType(l, 3, out val);
				computeShader.SetBool(nameID, val);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(bool)))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				bool val2;
				LuaObject.checkType(l, 3, out val2);
				computeShader2.SetBool(name, val2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetBool to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F2D RID: 143149 RVA: 0x00C173F4 File Offset: 0x00C155F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVector(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Vector4)))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4 val;
				LuaObject.checkType(l, 3, out val);
				computeShader.SetVector(nameID, val);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Vector4)))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4 val2;
				LuaObject.checkType(l, 3, out val2);
				computeShader2.SetVector(name, val2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetVector to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F2E RID: 143150 RVA: 0x00C174FC File Offset: 0x00C156FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVectorArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Vector4[])))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4[] values;
				LuaObject.checkArray<Vector4>(l, 3, out values);
				computeShader.SetVectorArray(nameID, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Vector4[])))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4[] values2;
				LuaObject.checkArray<Vector4>(l, 3, out values2);
				computeShader2.SetVectorArray(name, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetVectorArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F2F RID: 143151 RVA: 0x00C17604 File Offset: 0x00C15804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMatrix(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Matrix4x4)))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4 val;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out val);
				computeShader.SetMatrix(nameID, val);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Matrix4x4)))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4 val2;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out val2);
				computeShader2.SetMatrix(name, val2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetMatrix to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F30 RID: 143152 RVA: 0x00C1770C File Offset: 0x00C1590C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMatrixArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Matrix4x4[])))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4[] values;
				LuaObject.checkArray<Matrix4x4>(l, 3, out values);
				computeShader.SetMatrixArray(nameID, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Matrix4x4[])))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4[] values2;
				LuaObject.checkArray<Matrix4x4>(l, 3, out values2);
				computeShader2.SetMatrixArray(name, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetMatrixArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F31 RID: 143153 RVA: 0x00C17814 File Offset: 0x00C15A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFloats(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float[])))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float[] values;
				LuaObject.checkParams(l, 3, out values);
				computeShader.SetFloats(nameID, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float[])))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float[] values2;
				LuaObject.checkParams(l, 3, out values2);
				computeShader2.SetFloats(name, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetFloats to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F32 RID: 143154 RVA: 0x00C1791C File Offset: 0x00C15B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInts(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int[])))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				int[] values;
				LuaObject.checkParams(l, 3, out values);
				computeShader.SetInts(nameID, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int[])))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				int[] values2;
				LuaObject.checkParams(l, 3, out values2);
				computeShader2.SetInts(name, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetInts to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F33 RID: 143155 RVA: 0x00C17A24 File Offset: 0x00C15C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTexture(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int), typeof(Texture)))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int kernelIndex;
				LuaObject.checkType(l, 2, out kernelIndex);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				Texture texture;
				LuaObject.checkType<Texture>(l, 4, out texture);
				computeShader.SetTexture(kernelIndex, nameID, texture);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(string), typeof(Texture)))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				int kernelIndex2;
				LuaObject.checkType(l, 2, out kernelIndex2);
				string name;
				LuaObject.checkType(l, 3, out name);
				Texture texture2;
				LuaObject.checkType<Texture>(l, 4, out texture2);
				computeShader2.SetTexture(kernelIndex2, name, texture2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetTexture to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F34 RID: 143156 RVA: 0x00C17B64 File Offset: 0x00C15D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTextureFromGlobal(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int), typeof(int)))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int kernelIndex;
				LuaObject.checkType(l, 2, out kernelIndex);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				int globalTextureNameID;
				LuaObject.checkType(l, 4, out globalTextureNameID);
				computeShader.SetTextureFromGlobal(kernelIndex, nameID, globalTextureNameID);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(string), typeof(string)))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				int kernelIndex2;
				LuaObject.checkType(l, 2, out kernelIndex2);
				string name;
				LuaObject.checkType(l, 3, out name);
				string globalTextureName;
				LuaObject.checkType(l, 4, out globalTextureName);
				computeShader2.SetTextureFromGlobal(kernelIndex2, name, globalTextureName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetTextureFromGlobal to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F35 RID: 143157 RVA: 0x00C17CA4 File Offset: 0x00C15EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBuffer(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int), typeof(ComputeBuffer)))
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int kernelIndex;
				LuaObject.checkType(l, 2, out kernelIndex);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				ComputeBuffer buffer;
				LuaObject.checkType<ComputeBuffer>(l, 4, out buffer);
				computeShader.SetBuffer(kernelIndex, nameID, buffer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(string), typeof(ComputeBuffer)))
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				int kernelIndex2;
				LuaObject.checkType(l, 2, out kernelIndex2);
				string name;
				LuaObject.checkType(l, 3, out name);
				ComputeBuffer buffer2;
				LuaObject.checkType<ComputeBuffer>(l, 4, out buffer2);
				computeShader2.SetBuffer(kernelIndex2, name, buffer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetBuffer to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F36 RID: 143158 RVA: 0x00C17DE4 File Offset: 0x00C15FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispatch(IntPtr l)
	{
		int result;
		try
		{
			ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
			int kernelIndex;
			LuaObject.checkType(l, 2, out kernelIndex);
			int threadGroupsX;
			LuaObject.checkType(l, 3, out threadGroupsX);
			int threadGroupsY;
			LuaObject.checkType(l, 4, out threadGroupsY);
			int threadGroupsZ;
			LuaObject.checkType(l, 5, out threadGroupsZ);
			computeShader.Dispatch(kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F37 RID: 143159 RVA: 0x00C17E64 File Offset: 0x00C16064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DispatchIndirect(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				ComputeShader computeShader = (ComputeShader)LuaObject.checkSelf(l);
				int kernelIndex;
				LuaObject.checkType(l, 2, out kernelIndex);
				ComputeBuffer argsBuffer;
				LuaObject.checkType<ComputeBuffer>(l, 3, out argsBuffer);
				computeShader.DispatchIndirect(kernelIndex, argsBuffer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				ComputeShader computeShader2 = (ComputeShader)LuaObject.checkSelf(l);
				int kernelIndex2;
				LuaObject.checkType(l, 2, out kernelIndex2);
				ComputeBuffer argsBuffer2;
				LuaObject.checkType<ComputeBuffer>(l, 3, out argsBuffer2);
				uint argsOffset;
				LuaObject.checkType(l, 4, out argsOffset);
				computeShader2.DispatchIndirect(kernelIndex2, argsBuffer2, argsOffset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DispatchIndirect to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F38 RID: 143160 RVA: 0x00C17F44 File Offset: 0x00C16144
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ComputeShader");
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.FindKernel);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache0);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.HasKernel);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache1);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.GetKernelThreadGroupSizes);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache2);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache3);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetInt);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache4);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetBool);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache5);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache6);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetVectorArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache7);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache8);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetMatrixArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache9);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetFloats);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cacheA);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetInts);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cacheB);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cacheC);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetTextureFromGlobal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cacheD);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_ComputeShader.SetBuffer);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cacheE);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_ComputeShader.Dispatch);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cacheF);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.DispatchIndirect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache10);
		if (Lua_UnityEngine_ComputeShader.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_ComputeShader.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_ComputeShader.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ComputeShader.<>f__mg$cache11, typeof(ComputeShader), typeof(UnityEngine.Object));
	}

	// Token: 0x04018EA0 RID: 102048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018EA1 RID: 102049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018EA2 RID: 102050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018EA3 RID: 102051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018EA4 RID: 102052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018EA5 RID: 102053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018EA6 RID: 102054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018EA7 RID: 102055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018EA8 RID: 102056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018EA9 RID: 102057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018EAA RID: 102058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018EAB RID: 102059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018EAC RID: 102060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018EAD RID: 102061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018EAE RID: 102062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018EAF RID: 102063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018EB0 RID: 102064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018EB1 RID: 102065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
