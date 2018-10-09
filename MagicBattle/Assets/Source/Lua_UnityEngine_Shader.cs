using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017CD RID: 6093
[Preserve]
public class Lua_UnityEngine_Shader : LuaObject
{
	// Token: 0x06023CE3 RID: 146659 RVA: 0x00C8B4A0 File Offset: 0x00C896A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Shader o = new Shader();
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

	// Token: 0x06023CE4 RID: 146660 RVA: 0x00C8B4E8 File Offset: 0x00C896E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Find_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			Shader o = Shader.Find(name);
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

	// Token: 0x06023CE5 RID: 146661 RVA: 0x00C8B53C File Offset: 0x00C8973C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EnableKeyword_s(IntPtr l)
	{
		int result;
		try
		{
			string keyword;
			LuaObject.checkType(l, 1, out keyword);
			Shader.EnableKeyword(keyword);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CE6 RID: 146662 RVA: 0x00C8B588 File Offset: 0x00C89788
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DisableKeyword_s(IntPtr l)
	{
		int result;
		try
		{
			string keyword;
			LuaObject.checkType(l, 1, out keyword);
			Shader.DisableKeyword(keyword);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CE7 RID: 146663 RVA: 0x00C8B5D4 File Offset: 0x00C897D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsKeywordEnabled_s(IntPtr l)
	{
		int result;
		try
		{
			string keyword;
			LuaObject.checkType(l, 1, out keyword);
			bool b = Shader.IsKeywordEnabled(keyword);
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

	// Token: 0x06023CE8 RID: 146664 RVA: 0x00C8B628 File Offset: 0x00C89828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalBuffer_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string), typeof(ComputeBuffer)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				ComputeBuffer buffer;
				LuaObject.checkType<ComputeBuffer>(l, 2, out buffer);
				Shader.SetGlobalBuffer(name, buffer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(ComputeBuffer)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				ComputeBuffer buffer2;
				LuaObject.checkType<ComputeBuffer>(l, 2, out buffer2);
				Shader.SetGlobalBuffer(nameID, buffer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetGlobalBuffer to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CE9 RID: 146665 RVA: 0x00C8B70C File Offset: 0x00C8990C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PropertyToID_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			int i = Shader.PropertyToID(name);
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

	// Token: 0x06023CEA RID: 146666 RVA: 0x00C8B760 File Offset: 0x00C89960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WarmupAllShaders_s(IntPtr l)
	{
		int result;
		try
		{
			Shader.WarmupAllShaders();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CEB RID: 146667 RVA: 0x00C8B7A0 File Offset: 0x00C899A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalFloat_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int), typeof(float)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				float value;
				LuaObject.checkType(l, 2, out value);
				Shader.SetGlobalFloat(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(float)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				float value2;
				LuaObject.checkType(l, 2, out value2);
				Shader.SetGlobalFloat(name, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetGlobalFloat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CEC RID: 146668 RVA: 0x00C8B884 File Offset: 0x00C89A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalInt_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int), typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				int value;
				LuaObject.checkType(l, 2, out value);
				Shader.SetGlobalInt(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(int)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				int value2;
				LuaObject.checkType(l, 2, out value2);
				Shader.SetGlobalInt(name, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetGlobalInt to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CED RID: 146669 RVA: 0x00C8B968 File Offset: 0x00C89B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalVector_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int), typeof(Vector4)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Vector4 value;
				LuaObject.checkType(l, 2, out value);
				Shader.SetGlobalVector(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(Vector4)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Vector4 value2;
				LuaObject.checkType(l, 2, out value2);
				Shader.SetGlobalVector(name, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetGlobalVector to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CEE RID: 146670 RVA: 0x00C8BA4C File Offset: 0x00C89C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalColor_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int), typeof(Color)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Color value;
				LuaObject.checkType(l, 2, out value);
				Shader.SetGlobalColor(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(Color)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Color value2;
				LuaObject.checkType(l, 2, out value2);
				Shader.SetGlobalColor(name, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetGlobalColor to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CEF RID: 146671 RVA: 0x00C8BB30 File Offset: 0x00C89D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalMatrix_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int), typeof(Matrix4x4)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Matrix4x4 value;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out value);
				Shader.SetGlobalMatrix(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(Matrix4x4)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Matrix4x4 value2;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out value2);
				Shader.SetGlobalMatrix(name, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetGlobalMatrix to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CF0 RID: 146672 RVA: 0x00C8BC14 File Offset: 0x00C89E14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGlobalTexture_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int), typeof(Texture)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Texture value;
				LuaObject.checkType<Texture>(l, 2, out value);
				Shader.SetGlobalTexture(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(Texture)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Texture value2;
				LuaObject.checkType<Texture>(l, 2, out value2);
				Shader.SetGlobalTexture(name, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetGlobalTexture to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CF1 RID: 146673 RVA: 0x00C8BCF8 File Offset: 0x00C89EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalFloatArray_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string), typeof(float[])))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				float[] values;
				LuaObject.checkArray<float>(l, 2, out values);
				Shader.SetGlobalFloatArray(name, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(float[])))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				float[] values2;
				LuaObject.checkArray<float>(l, 2, out values2);
				Shader.SetGlobalFloatArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(List<float>)))
			{
				string name2;
				LuaObject.checkType(l, 1, out name2);
				List<float> values3;
				LuaObject.checkType<List<float>>(l, 2, out values3);
				Shader.SetGlobalFloatArray(name2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(List<float>)))
			{
				int nameID2;
				LuaObject.checkType(l, 1, out nameID2);
				List<float> values4;
				LuaObject.checkType<List<float>>(l, 2, out values4);
				Shader.SetGlobalFloatArray(nameID2, values4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetGlobalFloatArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CF2 RID: 146674 RVA: 0x00C8BE80 File Offset: 0x00C8A080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalVectorArray_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string), typeof(Vector4[])))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Vector4[] values;
				LuaObject.checkArray<Vector4>(l, 2, out values);
				Shader.SetGlobalVectorArray(name, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(Vector4[])))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Vector4[] values2;
				LuaObject.checkArray<Vector4>(l, 2, out values2);
				Shader.SetGlobalVectorArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(List<Vector4>)))
			{
				string name2;
				LuaObject.checkType(l, 1, out name2);
				List<Vector4> values3;
				LuaObject.checkType<List<Vector4>>(l, 2, out values3);
				Shader.SetGlobalVectorArray(name2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(List<Vector4>)))
			{
				int nameID2;
				LuaObject.checkType(l, 1, out nameID2);
				List<Vector4> values4;
				LuaObject.checkType<List<Vector4>>(l, 2, out values4);
				Shader.SetGlobalVectorArray(nameID2, values4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetGlobalVectorArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CF3 RID: 146675 RVA: 0x00C8C008 File Offset: 0x00C8A208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalMatrixArray_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string), typeof(Matrix4x4[])))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Matrix4x4[] values;
				LuaObject.checkArray<Matrix4x4>(l, 2, out values);
				Shader.SetGlobalMatrixArray(name, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(Matrix4x4[])))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Matrix4x4[] values2;
				LuaObject.checkArray<Matrix4x4>(l, 2, out values2);
				Shader.SetGlobalMatrixArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(List<Matrix4x4>)))
			{
				string name2;
				LuaObject.checkType(l, 1, out name2);
				List<Matrix4x4> values3;
				LuaObject.checkType<List<Matrix4x4>>(l, 2, out values3);
				Shader.SetGlobalMatrixArray(name2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(List<Matrix4x4>)))
			{
				int nameID2;
				LuaObject.checkType(l, 1, out nameID2);
				List<Matrix4x4> values4;
				LuaObject.checkType<List<Matrix4x4>>(l, 2, out values4);
				Shader.SetGlobalMatrixArray(nameID2, values4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetGlobalMatrixArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CF4 RID: 146676 RVA: 0x00C8C190 File Offset: 0x00C8A390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGlobalFloat_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				float globalFloat = Shader.GetGlobalFloat(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalFloat);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				float globalFloat2 = Shader.GetGlobalFloat(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalFloat2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetGlobalFloat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CF5 RID: 146677 RVA: 0x00C8C25C File Offset: 0x00C8A45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGlobalInt_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				int globalInt = Shader.GetGlobalInt(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalInt);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				int globalInt2 = Shader.GetGlobalInt(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalInt2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetGlobalInt to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CF6 RID: 146678 RVA: 0x00C8C328 File Offset: 0x00C8A528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGlobalVector_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Vector4 globalVector = Shader.GetGlobalVector(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalVector);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Vector4 globalVector2 = Shader.GetGlobalVector(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalVector2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetGlobalVector to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CF7 RID: 146679 RVA: 0x00C8C3F4 File Offset: 0x00C8A5F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGlobalColor_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Color globalColor = Shader.GetGlobalColor(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalColor);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Color globalColor2 = Shader.GetGlobalColor(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalColor2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetGlobalColor to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CF8 RID: 146680 RVA: 0x00C8C4C0 File Offset: 0x00C8A6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGlobalMatrix_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Matrix4x4 globalMatrix = Shader.GetGlobalMatrix(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalMatrix);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Matrix4x4 globalMatrix2 = Shader.GetGlobalMatrix(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalMatrix2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetGlobalMatrix to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CF9 RID: 146681 RVA: 0x00C8C598 File Offset: 0x00C8A798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGlobalTexture_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Texture globalTexture = Shader.GetGlobalTexture(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalTexture);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Texture globalTexture2 = Shader.GetGlobalTexture(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalTexture2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetGlobalTexture to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CFA RID: 146682 RVA: 0x00C8C664 File Offset: 0x00C8A864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGlobalFloatArray_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				float[] globalFloatArray = Shader.GetGlobalFloatArray(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalFloatArray);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				float[] globalFloatArray2 = Shader.GetGlobalFloatArray(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalFloatArray2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(List<float>)))
			{
				string name2;
				LuaObject.checkType(l, 1, out name2);
				List<float> values;
				LuaObject.checkType<List<float>>(l, 2, out values);
				Shader.GetGlobalFloatArray(name2, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(List<float>)))
			{
				int nameID2;
				LuaObject.checkType(l, 1, out nameID2);
				List<float> values2;
				LuaObject.checkType<List<float>>(l, 2, out values2);
				Shader.GetGlobalFloatArray(nameID2, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetGlobalFloatArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CFB RID: 146683 RVA: 0x00C8C7D4 File Offset: 0x00C8A9D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGlobalVectorArray_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Vector4[] globalVectorArray = Shader.GetGlobalVectorArray(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalVectorArray);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Vector4[] globalVectorArray2 = Shader.GetGlobalVectorArray(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalVectorArray2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(List<Vector4>)))
			{
				string name2;
				LuaObject.checkType(l, 1, out name2);
				List<Vector4> values;
				LuaObject.checkType<List<Vector4>>(l, 2, out values);
				Shader.GetGlobalVectorArray(name2, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(List<Vector4>)))
			{
				int nameID2;
				LuaObject.checkType(l, 1, out nameID2);
				List<Vector4> values2;
				LuaObject.checkType<List<Vector4>>(l, 2, out values2);
				Shader.GetGlobalVectorArray(nameID2, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetGlobalVectorArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CFC RID: 146684 RVA: 0x00C8C944 File Offset: 0x00C8AB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGlobalMatrixArray_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 1, out nameID);
				Matrix4x4[] globalMatrixArray = Shader.GetGlobalMatrixArray(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalMatrixArray);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				Matrix4x4[] globalMatrixArray2 = Shader.GetGlobalMatrixArray(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, globalMatrixArray2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(List<Matrix4x4>)))
			{
				string name2;
				LuaObject.checkType(l, 1, out name2);
				List<Matrix4x4> values;
				LuaObject.checkType<List<Matrix4x4>>(l, 2, out values);
				Shader.GetGlobalMatrixArray(name2, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(List<Matrix4x4>)))
			{
				int nameID2;
				LuaObject.checkType(l, 1, out nameID2);
				List<Matrix4x4> values2;
				LuaObject.checkType<List<Matrix4x4>>(l, 2, out values2);
				Shader.GetGlobalMatrixArray(nameID2, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetGlobalMatrixArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CFD RID: 146685 RVA: 0x00C8CAB4 File Offset: 0x00C8ACB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isSupported(IntPtr l)
	{
		int result;
		try
		{
			Shader shader = (Shader)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shader.isSupported);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CFE RID: 146686 RVA: 0x00C8CB08 File Offset: 0x00C8AD08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_maximumLOD(IntPtr l)
	{
		int result;
		try
		{
			Shader shader = (Shader)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shader.maximumLOD);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CFF RID: 146687 RVA: 0x00C8CB5C File Offset: 0x00C8AD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maximumLOD(IntPtr l)
	{
		int result;
		try
		{
			Shader shader = (Shader)LuaObject.checkSelf(l);
			int maximumLOD;
			LuaObject.checkType(l, 2, out maximumLOD);
			shader.maximumLOD = maximumLOD;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D00 RID: 146688 RVA: 0x00C8CBB4 File Offset: 0x00C8ADB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_globalMaximumLOD(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Shader.globalMaximumLOD);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D01 RID: 146689 RVA: 0x00C8CBFC File Offset: 0x00C8ADFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_globalMaximumLOD(IntPtr l)
	{
		int result;
		try
		{
			int globalMaximumLOD;
			LuaObject.checkType(l, 2, out globalMaximumLOD);
			Shader.globalMaximumLOD = globalMaximumLOD;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D02 RID: 146690 RVA: 0x00C8CC48 File Offset: 0x00C8AE48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_globalRenderPipeline(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Shader.globalRenderPipeline);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D03 RID: 146691 RVA: 0x00C8CC90 File Offset: 0x00C8AE90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_globalRenderPipeline(IntPtr l)
	{
		int result;
		try
		{
			string globalRenderPipeline;
			LuaObject.checkType(l, 2, out globalRenderPipeline);
			Shader.globalRenderPipeline = globalRenderPipeline;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D04 RID: 146692 RVA: 0x00C8CCDC File Offset: 0x00C8AEDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_renderQueue(IntPtr l)
	{
		int result;
		try
		{
			Shader shader = (Shader)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shader.renderQueue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D05 RID: 146693 RVA: 0x00C8CD30 File Offset: 0x00C8AF30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Shader");
		if (Lua_UnityEngine_Shader.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Shader.Find_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache0);
		if (Lua_UnityEngine_Shader.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Shader.EnableKeyword_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache1);
		if (Lua_UnityEngine_Shader.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Shader.DisableKeyword_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache2);
		if (Lua_UnityEngine_Shader.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Shader.IsKeywordEnabled_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache3);
		if (Lua_UnityEngine_Shader.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Shader.SetGlobalBuffer_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache4);
		if (Lua_UnityEngine_Shader.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Shader.PropertyToID_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache5);
		if (Lua_UnityEngine_Shader.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Shader.WarmupAllShaders_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache6);
		if (Lua_UnityEngine_Shader.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Shader.SetGlobalFloat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache7);
		if (Lua_UnityEngine_Shader.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Shader.SetGlobalInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache8);
		if (Lua_UnityEngine_Shader.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Shader.SetGlobalVector_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache9);
		if (Lua_UnityEngine_Shader.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Shader.SetGlobalColor_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cacheA);
		if (Lua_UnityEngine_Shader.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Shader.SetGlobalMatrix_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cacheB);
		if (Lua_UnityEngine_Shader.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Shader.SetGlobalTexture_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cacheC);
		if (Lua_UnityEngine_Shader.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Shader.SetGlobalFloatArray_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cacheD);
		if (Lua_UnityEngine_Shader.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Shader.SetGlobalVectorArray_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cacheE);
		if (Lua_UnityEngine_Shader.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Shader.SetGlobalMatrixArray_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cacheF);
		if (Lua_UnityEngine_Shader.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Shader.GetGlobalFloat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache10);
		if (Lua_UnityEngine_Shader.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Shader.GetGlobalInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache11);
		if (Lua_UnityEngine_Shader.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Shader.GetGlobalVector_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache12);
		if (Lua_UnityEngine_Shader.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Shader.GetGlobalColor_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache13);
		if (Lua_UnityEngine_Shader.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Shader.GetGlobalMatrix_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache14);
		if (Lua_UnityEngine_Shader.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Shader.GetGlobalTexture_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache15);
		if (Lua_UnityEngine_Shader.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Shader.GetGlobalFloatArray_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache16);
		if (Lua_UnityEngine_Shader.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Shader.GetGlobalVectorArray_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache17);
		if (Lua_UnityEngine_Shader.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Shader.GetGlobalMatrixArray_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Shader.<>f__mg$cache18);
		string name = "isSupported";
		if (Lua_UnityEngine_Shader.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Shader.get_isSupported);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Shader.<>f__mg$cache19, null, true);
		string name2 = "maximumLOD";
		if (Lua_UnityEngine_Shader.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Shader.get_maximumLOD);
		}
		LuaCSFunction get = Lua_UnityEngine_Shader.<>f__mg$cache1A;
		if (Lua_UnityEngine_Shader.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Shader.set_maximumLOD);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_Shader.<>f__mg$cache1B, true);
		string name3 = "globalMaximumLOD";
		if (Lua_UnityEngine_Shader.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Shader.get_globalMaximumLOD);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Shader.<>f__mg$cache1C;
		if (Lua_UnityEngine_Shader.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Shader.set_globalMaximumLOD);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_Shader.<>f__mg$cache1D, false);
		string name4 = "globalRenderPipeline";
		if (Lua_UnityEngine_Shader.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Shader.get_globalRenderPipeline);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Shader.<>f__mg$cache1E;
		if (Lua_UnityEngine_Shader.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Shader.set_globalRenderPipeline);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_Shader.<>f__mg$cache1F, false);
		string name5 = "renderQueue";
		if (Lua_UnityEngine_Shader.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Shader.get_renderQueue);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Shader.<>f__mg$cache20, null, true);
		if (Lua_UnityEngine_Shader.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Shader.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Shader.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Shader.<>f__mg$cache21, typeof(Shader), typeof(UnityEngine.Object));
	}

	// Token: 0x040199A7 RID: 104871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040199A8 RID: 104872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040199A9 RID: 104873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040199AA RID: 104874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040199AB RID: 104875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040199AC RID: 104876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040199AD RID: 104877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040199AE RID: 104878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040199AF RID: 104879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040199B0 RID: 104880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040199B1 RID: 104881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040199B2 RID: 104882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040199B3 RID: 104883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040199B4 RID: 104884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040199B5 RID: 104885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040199B6 RID: 104886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040199B7 RID: 104887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040199B8 RID: 104888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040199B9 RID: 104889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040199BA RID: 104890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040199BB RID: 104891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040199BC RID: 104892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040199BD RID: 104893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040199BE RID: 104894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040199BF RID: 104895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040199C0 RID: 104896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040199C1 RID: 104897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040199C2 RID: 104898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040199C3 RID: 104899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040199C4 RID: 104900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040199C5 RID: 104901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040199C6 RID: 104902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040199C7 RID: 104903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040199C8 RID: 104904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
