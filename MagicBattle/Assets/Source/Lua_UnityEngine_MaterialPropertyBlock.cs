using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001725 RID: 5925
[Preserve]
public class Lua_UnityEngine_MaterialPropertyBlock : LuaObject
{
	// Token: 0x060235AA RID: 144810 RVA: 0x00C49FE0 File Offset: 0x00C481E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MaterialPropertyBlock o = new MaterialPropertyBlock();
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

	// Token: 0x060235AB RID: 144811 RVA: 0x00C4A028 File Offset: 0x00C48228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
			materialPropertyBlock.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235AC RID: 144812 RVA: 0x00C4A074 File Offset: 0x00C48274
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
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float value;
				LuaObject.checkType(l, 3, out value);
				materialPropertyBlock.SetFloat(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float value2;
				LuaObject.checkType(l, 3, out value2);
				materialPropertyBlock2.SetFloat(name, value2);
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

	// Token: 0x060235AD RID: 144813 RVA: 0x00C4A17C File Offset: 0x00C4837C
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
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4 value;
				LuaObject.checkType(l, 3, out value);
				materialPropertyBlock.SetVector(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Vector4)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4 value2;
				LuaObject.checkType(l, 3, out value2);
				materialPropertyBlock2.SetVector(name, value2);
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

	// Token: 0x060235AE RID: 144814 RVA: 0x00C4A284 File Offset: 0x00C48484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetColor(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Color)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Color value;
				LuaObject.checkType(l, 3, out value);
				materialPropertyBlock.SetColor(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Color)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Color value2;
				LuaObject.checkType(l, 3, out value2);
				materialPropertyBlock2.SetColor(name, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetColor to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235AF RID: 144815 RVA: 0x00C4A38C File Offset: 0x00C4858C
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
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4 value;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out value);
				materialPropertyBlock.SetMatrix(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Matrix4x4)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4 value2;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out value2);
				materialPropertyBlock2.SetMatrix(name, value2);
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

	// Token: 0x060235B0 RID: 144816 RVA: 0x00C4A494 File Offset: 0x00C48694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBuffer(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(ComputeBuffer)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				ComputeBuffer value;
				LuaObject.checkType<ComputeBuffer>(l, 3, out value);
				materialPropertyBlock.SetBuffer(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(ComputeBuffer)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				ComputeBuffer value2;
				LuaObject.checkType<ComputeBuffer>(l, 3, out value2);
				materialPropertyBlock2.SetBuffer(name, value2);
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

	// Token: 0x060235B1 RID: 144817 RVA: 0x00C4A59C File Offset: 0x00C4879C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTexture(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Texture)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Texture value;
				LuaObject.checkType<Texture>(l, 3, out value);
				materialPropertyBlock.SetTexture(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Texture)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Texture value2;
				LuaObject.checkType<Texture>(l, 3, out value2);
				materialPropertyBlock2.SetTexture(name, value2);
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

	// Token: 0x060235B2 RID: 144818 RVA: 0x00C4A6A4 File Offset: 0x00C488A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFloatArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float[])))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float[] values;
				LuaObject.checkArray<float>(l, 3, out values);
				materialPropertyBlock.SetFloatArray(name, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float[])))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float[] values2;
				LuaObject.checkArray<float>(l, 3, out values2);
				materialPropertyBlock2.SetFloatArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<float>)))
			{
				MaterialPropertyBlock materialPropertyBlock3 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<float> values3;
				LuaObject.checkType<List<float>>(l, 3, out values3);
				materialPropertyBlock3.SetFloatArray(name2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<float>)))
			{
				MaterialPropertyBlock materialPropertyBlock4 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<float> values4;
				LuaObject.checkType<List<float>>(l, 3, out values4);
				materialPropertyBlock4.SetFloatArray(nameID2, values4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetFloatArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235B3 RID: 144819 RVA: 0x00C4A870 File Offset: 0x00C48A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVectorArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Vector4[])))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4[] values;
				LuaObject.checkArray<Vector4>(l, 3, out values);
				materialPropertyBlock.SetVectorArray(name, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Vector4[])))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4[] values2;
				LuaObject.checkArray<Vector4>(l, 3, out values2);
				materialPropertyBlock2.SetVectorArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Vector4>)))
			{
				MaterialPropertyBlock materialPropertyBlock3 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<Vector4> values3;
				LuaObject.checkType<List<Vector4>>(l, 3, out values3);
				materialPropertyBlock3.SetVectorArray(name2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector4>)))
			{
				MaterialPropertyBlock materialPropertyBlock4 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Vector4> values4;
				LuaObject.checkType<List<Vector4>>(l, 3, out values4);
				materialPropertyBlock4.SetVectorArray(nameID2, values4);
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

	// Token: 0x060235B4 RID: 144820 RVA: 0x00C4AA3C File Offset: 0x00C48C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMatrixArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Matrix4x4[])))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4[] values;
				LuaObject.checkArray<Matrix4x4>(l, 3, out values);
				materialPropertyBlock.SetMatrixArray(name, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Matrix4x4[])))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4[] values2;
				LuaObject.checkArray<Matrix4x4>(l, 3, out values2);
				materialPropertyBlock2.SetMatrixArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Matrix4x4>)))
			{
				MaterialPropertyBlock materialPropertyBlock3 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<Matrix4x4> values3;
				LuaObject.checkType<List<Matrix4x4>>(l, 3, out values3);
				materialPropertyBlock3.SetMatrixArray(name2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Matrix4x4>)))
			{
				MaterialPropertyBlock materialPropertyBlock4 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Matrix4x4> values4;
				LuaObject.checkType<List<Matrix4x4>>(l, 3, out values4);
				materialPropertyBlock4.SetMatrixArray(nameID2, values4);
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

	// Token: 0x060235B5 RID: 144821 RVA: 0x00C4AC08 File Offset: 0x00C48E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFloat(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float @float = materialPropertyBlock.GetFloat(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @float);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float float2 = materialPropertyBlock2.GetFloat(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, float2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetFloat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235B6 RID: 144822 RVA: 0x00C4ACF4 File Offset: 0x00C48EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetVector(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4 vector = materialPropertyBlock.GetVector(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vector);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4 vector2 = materialPropertyBlock2.GetVector(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vector2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetVector to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235B7 RID: 144823 RVA: 0x00C4ADE0 File Offset: 0x00C48FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetColor(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Color color = materialPropertyBlock.GetColor(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, color);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Color color2 = materialPropertyBlock2.GetColor(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, color2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetColor to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235B8 RID: 144824 RVA: 0x00C4AECC File Offset: 0x00C490CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMatrix(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4 matrix = materialPropertyBlock.GetMatrix(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, matrix);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4 matrix2 = materialPropertyBlock2.GetMatrix(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, matrix2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetMatrix to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235B9 RID: 144825 RVA: 0x00C4AFC4 File Offset: 0x00C491C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFloatArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float[] floatArray = materialPropertyBlock.GetFloatArray(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, floatArray);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float[] floatArray2 = materialPropertyBlock2.GetFloatArray(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, floatArray2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<float>)))
			{
				MaterialPropertyBlock materialPropertyBlock3 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<float> values;
				LuaObject.checkType<List<float>>(l, 3, out values);
				materialPropertyBlock3.GetFloatArray(name2, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<float>)))
			{
				MaterialPropertyBlock materialPropertyBlock4 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<float> values2;
				LuaObject.checkType<List<float>>(l, 3, out values2);
				materialPropertyBlock4.GetFloatArray(nameID2, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetFloatArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235BA RID: 144826 RVA: 0x00C4B174 File Offset: 0x00C49374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetVectorArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4[] vectorArray = materialPropertyBlock.GetVectorArray(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vectorArray);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4[] vectorArray2 = materialPropertyBlock2.GetVectorArray(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vectorArray2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Vector4>)))
			{
				MaterialPropertyBlock materialPropertyBlock3 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<Vector4> values;
				LuaObject.checkType<List<Vector4>>(l, 3, out values);
				materialPropertyBlock3.GetVectorArray(name2, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector4>)))
			{
				MaterialPropertyBlock materialPropertyBlock4 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Vector4> values2;
				LuaObject.checkType<List<Vector4>>(l, 3, out values2);
				materialPropertyBlock4.GetVectorArray(nameID2, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetVectorArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235BB RID: 144827 RVA: 0x00C4B324 File Offset: 0x00C49524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMatrixArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4[] matrixArray = materialPropertyBlock.GetMatrixArray(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, matrixArray);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4[] matrixArray2 = materialPropertyBlock2.GetMatrixArray(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, matrixArray2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Matrix4x4>)))
			{
				MaterialPropertyBlock materialPropertyBlock3 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<Matrix4x4> values;
				LuaObject.checkType<List<Matrix4x4>>(l, 3, out values);
				materialPropertyBlock3.GetMatrixArray(name2, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Matrix4x4>)))
			{
				MaterialPropertyBlock materialPropertyBlock4 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Matrix4x4> values2;
				LuaObject.checkType<List<Matrix4x4>>(l, 3, out values2);
				materialPropertyBlock4.GetMatrixArray(nameID2, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetMatrixArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235BC RID: 144828 RVA: 0x00C4B4D4 File Offset: 0x00C496D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTexture(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Texture texture = materialPropertyBlock.GetTexture(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, texture);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				MaterialPropertyBlock materialPropertyBlock2 = (MaterialPropertyBlock)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Texture texture2 = materialPropertyBlock2.GetTexture(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, texture2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetTexture to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235BD RID: 144829 RVA: 0x00C4B5C0 File Offset: 0x00C497C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isEmpty(IntPtr l)
	{
		int result;
		try
		{
			MaterialPropertyBlock materialPropertyBlock = (MaterialPropertyBlock)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, materialPropertyBlock.isEmpty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235BE RID: 144830 RVA: 0x00C4B614 File Offset: 0x00C49814
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.MaterialPropertyBlock");
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.Clear);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache0);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.SetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache1);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.SetVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache2);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.SetColor);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache3);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.SetMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache4);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.SetBuffer);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache5);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.SetTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache6);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.SetFloatArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache7);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.SetVectorArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache8);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.SetMatrixArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache9);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.GetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheA);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.GetVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheB);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.GetColor);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheC);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.GetMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheD);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.GetFloatArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheE);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.GetVectorArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cacheF);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.GetMatrixArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache10);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.GetTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache11);
		string name = "isEmpty";
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.get_isEmpty);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache12, null, true);
		if (Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_MaterialPropertyBlock.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_MaterialPropertyBlock.<>f__mg$cache13, typeof(MaterialPropertyBlock));
	}

	// Token: 0x040193BE RID: 103358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040193BF RID: 103359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040193C0 RID: 103360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040193C1 RID: 103361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040193C2 RID: 103362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040193C3 RID: 103363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040193C4 RID: 103364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040193C5 RID: 103365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040193C6 RID: 103366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040193C7 RID: 103367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040193C8 RID: 103368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040193C9 RID: 103369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040193CA RID: 103370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040193CB RID: 103371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040193CC RID: 103372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040193CD RID: 103373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040193CE RID: 103374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040193CF RID: 103375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040193D0 RID: 103376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040193D1 RID: 103377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
