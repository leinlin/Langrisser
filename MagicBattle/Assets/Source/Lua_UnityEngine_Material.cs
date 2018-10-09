using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001723 RID: 5923
[Preserve]
public class Lua_UnityEngine_Material : LuaObject
{
	// Token: 0x0602356A RID: 144746 RVA: 0x00C46A80 File Offset: 0x00C44C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Shader)))
			{
				Shader shader;
				LuaObject.checkType<Shader>(l, 2, out shader);
				Material o = new Material(shader);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Material)))
			{
				Material source;
				LuaObject.checkType<Material>(l, 2, out source);
				Material o = new Material(source);
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

	// Token: 0x0602356B RID: 144747 RVA: 0x00C46B44 File Offset: 0x00C44D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasProperty(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Material material = (Material)LuaObject.checkSelf(l);
				string propertyName;
				LuaObject.checkType(l, 2, out propertyName);
				bool b = material.HasProperty(propertyName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				bool b2 = material2.HasProperty(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function HasProperty to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602356C RID: 144748 RVA: 0x00C46C30 File Offset: 0x00C44E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTag(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Material material = (Material)LuaObject.checkSelf(l);
				string tag;
				LuaObject.checkType(l, 2, out tag);
				bool searchFallbacks;
				LuaObject.checkType(l, 3, out searchFallbacks);
				string tag2 = material.GetTag(tag, searchFallbacks);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, tag2);
				result = 2;
			}
			else if (num == 4)
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string tag3;
				LuaObject.checkType(l, 2, out tag3);
				bool searchFallbacks2;
				LuaObject.checkType(l, 3, out searchFallbacks2);
				string defaultValue;
				LuaObject.checkType(l, 4, out defaultValue);
				string tag4 = material2.GetTag(tag3, searchFallbacks2, defaultValue);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, tag4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetTag to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602356D RID: 144749 RVA: 0x00C46D24 File Offset: 0x00C44F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOverrideTag(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			string val;
			LuaObject.checkType(l, 3, out val);
			material.SetOverrideTag(tag, val);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602356E RID: 144750 RVA: 0x00C46D88 File Offset: 0x00C44F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetShaderPassEnabled(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			string passName;
			LuaObject.checkType(l, 2, out passName);
			bool enabled;
			LuaObject.checkType(l, 3, out enabled);
			material.SetShaderPassEnabled(passName, enabled);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602356F RID: 144751 RVA: 0x00C46DEC File Offset: 0x00C44FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetShaderPassEnabled(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			string passName;
			LuaObject.checkType(l, 2, out passName);
			bool shaderPassEnabled = material.GetShaderPassEnabled(passName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shaderPassEnabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023570 RID: 144752 RVA: 0x00C46E50 File Offset: 0x00C45050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Lerp(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			Material start;
			LuaObject.checkType<Material>(l, 2, out start);
			Material end;
			LuaObject.checkType<Material>(l, 3, out end);
			float t;
			LuaObject.checkType(l, 4, out t);
			material.Lerp(start, end, t);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023571 RID: 144753 RVA: 0x00C46EC4 File Offset: 0x00C450C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPass(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			int pass;
			LuaObject.checkType(l, 2, out pass);
			bool b = material.SetPass(pass);
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

	// Token: 0x06023572 RID: 144754 RVA: 0x00C46F28 File Offset: 0x00C45128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPassName(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			int pass;
			LuaObject.checkType(l, 2, out pass);
			string passName = material.GetPassName(pass);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, passName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023573 RID: 144755 RVA: 0x00C46F8C File Offset: 0x00C4518C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPass(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			string passName;
			LuaObject.checkType(l, 2, out passName);
			int i = material.FindPass(passName);
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

	// Token: 0x06023574 RID: 144756 RVA: 0x00C46FF0 File Offset: 0x00C451F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CopyPropertiesFromMaterial(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			Material mat;
			LuaObject.checkType<Material>(l, 2, out mat);
			material.CopyPropertiesFromMaterial(mat);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023575 RID: 144757 RVA: 0x00C47048 File Offset: 0x00C45248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableKeyword(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			string keyword;
			LuaObject.checkType(l, 2, out keyword);
			material.EnableKeyword(keyword);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023576 RID: 144758 RVA: 0x00C470A0 File Offset: 0x00C452A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DisableKeyword(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			string keyword;
			LuaObject.checkType(l, 2, out keyword);
			material.DisableKeyword(keyword);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023577 RID: 144759 RVA: 0x00C470F8 File Offset: 0x00C452F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsKeywordEnabled(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			string keyword;
			LuaObject.checkType(l, 2, out keyword);
			bool b = material.IsKeywordEnabled(keyword);
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

	// Token: 0x06023578 RID: 144760 RVA: 0x00C4715C File Offset: 0x00C4535C
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
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float value;
				LuaObject.checkType(l, 3, out value);
				material.SetFloat(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float value2;
				LuaObject.checkType(l, 3, out value2);
				material2.SetFloat(name, value2);
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

	// Token: 0x06023579 RID: 144761 RVA: 0x00C47264 File Offset: 0x00C45464
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
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				int value;
				LuaObject.checkType(l, 3, out value);
				material.SetInt(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				int value2;
				LuaObject.checkType(l, 3, out value2);
				material2.SetInt(name, value2);
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

	// Token: 0x0602357A RID: 144762 RVA: 0x00C4736C File Offset: 0x00C4556C
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
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Color value;
				LuaObject.checkType(l, 3, out value);
				material.SetColor(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Color)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Color value2;
				LuaObject.checkType(l, 3, out value2);
				material2.SetColor(name, value2);
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

	// Token: 0x0602357B RID: 144763 RVA: 0x00C47474 File Offset: 0x00C45674
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
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4 value;
				LuaObject.checkType(l, 3, out value);
				material.SetVector(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Vector4)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4 value2;
				LuaObject.checkType(l, 3, out value2);
				material2.SetVector(name, value2);
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

	// Token: 0x0602357C RID: 144764 RVA: 0x00C4757C File Offset: 0x00C4577C
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
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4 value;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out value);
				material.SetMatrix(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Matrix4x4)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4 value2;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out value2);
				material2.SetMatrix(name, value2);
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

	// Token: 0x0602357D RID: 144765 RVA: 0x00C47684 File Offset: 0x00C45884
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
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Texture value;
				LuaObject.checkType<Texture>(l, 3, out value);
				material.SetTexture(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Texture)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Texture value2;
				LuaObject.checkType<Texture>(l, 3, out value2);
				material2.SetTexture(name, value2);
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

	// Token: 0x0602357E RID: 144766 RVA: 0x00C4778C File Offset: 0x00C4598C
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
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				ComputeBuffer value;
				LuaObject.checkType<ComputeBuffer>(l, 3, out value);
				material.SetBuffer(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(ComputeBuffer)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				ComputeBuffer value2;
				LuaObject.checkType<ComputeBuffer>(l, 3, out value2);
				material2.SetBuffer(name, value2);
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

	// Token: 0x0602357F RID: 144767 RVA: 0x00C47894 File Offset: 0x00C45A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTextureOffset(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Vector2)))
			{
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector2 value;
				LuaObject.checkType(l, 3, out value);
				material.SetTextureOffset(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Vector2)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector2 value2;
				LuaObject.checkType(l, 3, out value2);
				material2.SetTextureOffset(name, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetTextureOffset to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023580 RID: 144768 RVA: 0x00C4799C File Offset: 0x00C45B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTextureScale(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Vector2)))
			{
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector2 value;
				LuaObject.checkType(l, 3, out value);
				material.SetTextureScale(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Vector2)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector2 value2;
				LuaObject.checkType(l, 3, out value2);
				material2.SetTextureScale(name, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetTextureScale to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023581 RID: 144769 RVA: 0x00C47AA4 File Offset: 0x00C45CA4
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
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float[] values;
				LuaObject.checkArray<float>(l, 3, out values);
				material.SetFloatArray(name, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float[])))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float[] values2;
				LuaObject.checkArray<float>(l, 3, out values2);
				material2.SetFloatArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<float>)))
			{
				Material material3 = (Material)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<float> values3;
				LuaObject.checkType<List<float>>(l, 3, out values3);
				material3.SetFloatArray(name2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<float>)))
			{
				Material material4 = (Material)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<float> values4;
				LuaObject.checkType<List<float>>(l, 3, out values4);
				material4.SetFloatArray(nameID2, values4);
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

	// Token: 0x06023582 RID: 144770 RVA: 0x00C47C70 File Offset: 0x00C45E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetColorArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Color[])))
			{
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Color[] values;
				LuaObject.checkArray<Color>(l, 3, out values);
				material.SetColorArray(name, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Color[])))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Color[] values2;
				LuaObject.checkArray<Color>(l, 3, out values2);
				material2.SetColorArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Color>)))
			{
				Material material3 = (Material)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<Color> values3;
				LuaObject.checkType<List<Color>>(l, 3, out values3);
				material3.SetColorArray(name2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Color>)))
			{
				Material material4 = (Material)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Color> values4;
				LuaObject.checkType<List<Color>>(l, 3, out values4);
				material4.SetColorArray(nameID2, values4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetColorArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023583 RID: 144771 RVA: 0x00C47E3C File Offset: 0x00C4603C
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
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4[] values;
				LuaObject.checkArray<Vector4>(l, 3, out values);
				material.SetVectorArray(name, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Vector4[])))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4[] values2;
				LuaObject.checkArray<Vector4>(l, 3, out values2);
				material2.SetVectorArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Vector4>)))
			{
				Material material3 = (Material)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<Vector4> values3;
				LuaObject.checkType<List<Vector4>>(l, 3, out values3);
				material3.SetVectorArray(name2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector4>)))
			{
				Material material4 = (Material)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Vector4> values4;
				LuaObject.checkType<List<Vector4>>(l, 3, out values4);
				material4.SetVectorArray(nameID2, values4);
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

	// Token: 0x06023584 RID: 144772 RVA: 0x00C48008 File Offset: 0x00C46208
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
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4[] values;
				LuaObject.checkArray<Matrix4x4>(l, 3, out values);
				material.SetMatrixArray(name, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Matrix4x4[])))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4[] values2;
				LuaObject.checkArray<Matrix4x4>(l, 3, out values2);
				material2.SetMatrixArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Matrix4x4>)))
			{
				Material material3 = (Material)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<Matrix4x4> values3;
				LuaObject.checkType<List<Matrix4x4>>(l, 3, out values3);
				material3.SetMatrixArray(name2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Matrix4x4>)))
			{
				Material material4 = (Material)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Matrix4x4> values4;
				LuaObject.checkType<List<Matrix4x4>>(l, 3, out values4);
				material4.SetMatrixArray(nameID2, values4);
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

	// Token: 0x06023585 RID: 144773 RVA: 0x00C481D4 File Offset: 0x00C463D4
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
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float @float = material.GetFloat(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @float);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float float2 = material2.GetFloat(nameID);
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

	// Token: 0x06023586 RID: 144774 RVA: 0x00C482C0 File Offset: 0x00C464C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInt(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				int @int = material.GetInt(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @int);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				int int2 = material2.GetInt(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, int2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetInt to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023587 RID: 144775 RVA: 0x00C483AC File Offset: 0x00C465AC
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
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Color color = material.GetColor(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, color);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Color color2 = material2.GetColor(nameID);
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

	// Token: 0x06023588 RID: 144776 RVA: 0x00C48498 File Offset: 0x00C46698
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
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4 vector = material.GetVector(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vector);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4 vector2 = material2.GetVector(nameID);
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

	// Token: 0x06023589 RID: 144777 RVA: 0x00C48584 File Offset: 0x00C46784
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
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4 matrix = material.GetMatrix(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, matrix);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4 matrix2 = material2.GetMatrix(nameID);
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

	// Token: 0x0602358A RID: 144778 RVA: 0x00C4867C File Offset: 0x00C4687C
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
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float[] floatArray = material.GetFloatArray(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, floatArray);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float[] floatArray2 = material2.GetFloatArray(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, floatArray2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<float>)))
			{
				Material material3 = (Material)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<float> values;
				LuaObject.checkType<List<float>>(l, 3, out values);
				material3.GetFloatArray(name2, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<float>)))
			{
				Material material4 = (Material)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<float> values2;
				LuaObject.checkType<List<float>>(l, 3, out values2);
				material4.GetFloatArray(nameID2, values2);
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

	// Token: 0x0602358B RID: 144779 RVA: 0x00C4882C File Offset: 0x00C46A2C
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
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4[] vectorArray = material.GetVectorArray(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vectorArray);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4[] vectorArray2 = material2.GetVectorArray(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vectorArray2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Vector4>)))
			{
				Material material3 = (Material)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<Vector4> values;
				LuaObject.checkType<List<Vector4>>(l, 3, out values);
				material3.GetVectorArray(name2, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector4>)))
			{
				Material material4 = (Material)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Vector4> values2;
				LuaObject.checkType<List<Vector4>>(l, 3, out values2);
				material4.GetVectorArray(nameID2, values2);
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

	// Token: 0x0602358C RID: 144780 RVA: 0x00C489DC File Offset: 0x00C46BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetColorArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Color[] colorArray = material.GetColorArray(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, colorArray);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Color[] colorArray2 = material2.GetColorArray(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, colorArray2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Color>)))
			{
				Material material3 = (Material)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Color> values;
				LuaObject.checkType<List<Color>>(l, 3, out values);
				material3.GetColorArray(nameID2, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Color>)))
			{
				Material material4 = (Material)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<Color> values2;
				LuaObject.checkType<List<Color>>(l, 3, out values2);
				material4.GetColorArray(name2, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetColorArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602358D RID: 144781 RVA: 0x00C48B8C File Offset: 0x00C46D8C
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
				Material material = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4[] matrixArray = material.GetMatrixArray(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, matrixArray);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4[] matrixArray2 = material2.GetMatrixArray(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, matrixArray2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Matrix4x4>)))
			{
				Material material3 = (Material)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				List<Matrix4x4> values;
				LuaObject.checkType<List<Matrix4x4>>(l, 3, out values);
				material3.GetMatrixArray(name2, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Matrix4x4>)))
			{
				Material material4 = (Material)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Matrix4x4> values2;
				LuaObject.checkType<List<Matrix4x4>>(l, 3, out values2);
				material4.GetMatrixArray(nameID2, values2);
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

	// Token: 0x0602358E RID: 144782 RVA: 0x00C48D3C File Offset: 0x00C46F3C
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
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Texture texture = material.GetTexture(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, texture);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Texture texture2 = material2.GetTexture(nameID);
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

	// Token: 0x0602358F RID: 144783 RVA: 0x00C48E28 File Offset: 0x00C47028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTextureOffset(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector2 textureOffset = material.GetTextureOffset(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, textureOffset);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector2 textureOffset2 = material2.GetTextureOffset(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, textureOffset2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetTextureOffset to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023590 RID: 144784 RVA: 0x00C48F14 File Offset: 0x00C47114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTextureScale(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Material material = (Material)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector2 textureScale = material.GetTextureScale(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, textureScale);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Material material2 = (Material)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector2 textureScale2 = material2.GetTextureScale(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, textureScale2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetTextureScale to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023591 RID: 144785 RVA: 0x00C49000 File Offset: 0x00C47200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shader(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, material.shader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023592 RID: 144786 RVA: 0x00C49054 File Offset: 0x00C47254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shader(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			Shader shader;
			LuaObject.checkType<Shader>(l, 2, out shader);
			material.shader = shader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023593 RID: 144787 RVA: 0x00C490AC File Offset: 0x00C472AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_color(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, material.color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023594 RID: 144788 RVA: 0x00C49100 File Offset: 0x00C47300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_color(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			Color color;
			LuaObject.checkType(l, 2, out color);
			material.color = color;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023595 RID: 144789 RVA: 0x00C49158 File Offset: 0x00C47358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mainTexture(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, material.mainTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023596 RID: 144790 RVA: 0x00C491AC File Offset: 0x00C473AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mainTexture(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			Texture mainTexture;
			LuaObject.checkType<Texture>(l, 2, out mainTexture);
			material.mainTexture = mainTexture;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023597 RID: 144791 RVA: 0x00C49204 File Offset: 0x00C47404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mainTextureOffset(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, material.mainTextureOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023598 RID: 144792 RVA: 0x00C49258 File Offset: 0x00C47458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mainTextureOffset(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			Vector2 mainTextureOffset;
			LuaObject.checkType(l, 2, out mainTextureOffset);
			material.mainTextureOffset = mainTextureOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023599 RID: 144793 RVA: 0x00C492B0 File Offset: 0x00C474B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mainTextureScale(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, material.mainTextureScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602359A RID: 144794 RVA: 0x00C49304 File Offset: 0x00C47504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mainTextureScale(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			Vector2 mainTextureScale;
			LuaObject.checkType(l, 2, out mainTextureScale);
			material.mainTextureScale = mainTextureScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602359B RID: 144795 RVA: 0x00C4935C File Offset: 0x00C4755C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_passCount(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, material.passCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602359C RID: 144796 RVA: 0x00C493B0 File Offset: 0x00C475B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderQueue(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, material.renderQueue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602359D RID: 144797 RVA: 0x00C49404 File Offset: 0x00C47604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_renderQueue(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			int renderQueue;
			LuaObject.checkType(l, 2, out renderQueue);
			material.renderQueue = renderQueue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602359E RID: 144798 RVA: 0x00C4945C File Offset: 0x00C4765C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shaderKeywords(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, material.shaderKeywords);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602359F RID: 144799 RVA: 0x00C494B0 File Offset: 0x00C476B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shaderKeywords(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			string[] shaderKeywords;
			LuaObject.checkArray<string>(l, 2, out shaderKeywords);
			material.shaderKeywords = shaderKeywords;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235A0 RID: 144800 RVA: 0x00C49508 File Offset: 0x00C47708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_globalIlluminationFlags(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)material.globalIlluminationFlags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235A1 RID: 144801 RVA: 0x00C4955C File Offset: 0x00C4775C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_globalIlluminationFlags(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			MaterialGlobalIlluminationFlags globalIlluminationFlags;
			LuaObject.checkEnum<MaterialGlobalIlluminationFlags>(l, 2, out globalIlluminationFlags);
			material.globalIlluminationFlags = globalIlluminationFlags;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235A2 RID: 144802 RVA: 0x00C495B4 File Offset: 0x00C477B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enableInstancing(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, material.enableInstancing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235A3 RID: 144803 RVA: 0x00C49608 File Offset: 0x00C47808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enableInstancing(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			bool enableInstancing;
			LuaObject.checkType(l, 2, out enableInstancing);
			material.enableInstancing = enableInstancing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235A4 RID: 144804 RVA: 0x00C49660 File Offset: 0x00C47860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_doubleSidedGI(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, material.doubleSidedGI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235A5 RID: 144805 RVA: 0x00C496B4 File Offset: 0x00C478B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_doubleSidedGI(IntPtr l)
	{
		int result;
		try
		{
			Material material = (Material)LuaObject.checkSelf(l);
			bool doubleSidedGI;
			LuaObject.checkType(l, 2, out doubleSidedGI);
			material.doubleSidedGI = doubleSidedGI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235A6 RID: 144806 RVA: 0x00C4970C File Offset: 0x00C4790C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Material");
		if (Lua_UnityEngine_Material.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Material.HasProperty);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache0);
		if (Lua_UnityEngine_Material.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Material.GetTag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache1);
		if (Lua_UnityEngine_Material.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Material.SetOverrideTag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache2);
		if (Lua_UnityEngine_Material.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Material.SetShaderPassEnabled);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache3);
		if (Lua_UnityEngine_Material.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Material.GetShaderPassEnabled);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache4);
		if (Lua_UnityEngine_Material.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Material.Lerp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache5);
		if (Lua_UnityEngine_Material.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Material.SetPass);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache6);
		if (Lua_UnityEngine_Material.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Material.GetPassName);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache7);
		if (Lua_UnityEngine_Material.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Material.FindPass);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache8);
		if (Lua_UnityEngine_Material.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Material.CopyPropertiesFromMaterial);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache9);
		if (Lua_UnityEngine_Material.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Material.EnableKeyword);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cacheA);
		if (Lua_UnityEngine_Material.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Material.DisableKeyword);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cacheB);
		if (Lua_UnityEngine_Material.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Material.IsKeywordEnabled);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cacheC);
		if (Lua_UnityEngine_Material.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Material.SetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cacheD);
		if (Lua_UnityEngine_Material.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Material.SetInt);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cacheE);
		if (Lua_UnityEngine_Material.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Material.SetColor);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cacheF);
		if (Lua_UnityEngine_Material.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Material.SetVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache10);
		if (Lua_UnityEngine_Material.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Material.SetMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache11);
		if (Lua_UnityEngine_Material.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Material.SetTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache12);
		if (Lua_UnityEngine_Material.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Material.SetBuffer);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache13);
		if (Lua_UnityEngine_Material.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Material.SetTextureOffset);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache14);
		if (Lua_UnityEngine_Material.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Material.SetTextureScale);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache15);
		if (Lua_UnityEngine_Material.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Material.SetFloatArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache16);
		if (Lua_UnityEngine_Material.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Material.SetColorArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache17);
		if (Lua_UnityEngine_Material.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Material.SetVectorArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache18);
		if (Lua_UnityEngine_Material.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Material.SetMatrixArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache19);
		if (Lua_UnityEngine_Material.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Material.GetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache1A);
		if (Lua_UnityEngine_Material.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Material.GetInt);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache1B);
		if (Lua_UnityEngine_Material.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Material.GetColor);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache1C);
		if (Lua_UnityEngine_Material.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Material.GetVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache1D);
		if (Lua_UnityEngine_Material.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Material.GetMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache1E);
		if (Lua_UnityEngine_Material.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Material.GetFloatArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache1F);
		if (Lua_UnityEngine_Material.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Material.GetVectorArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache20);
		if (Lua_UnityEngine_Material.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Material.GetColorArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache21);
		if (Lua_UnityEngine_Material.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Material.GetMatrixArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache22);
		if (Lua_UnityEngine_Material.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Material.GetTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache23);
		if (Lua_UnityEngine_Material.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Material.GetTextureOffset);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache24);
		if (Lua_UnityEngine_Material.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Material.GetTextureScale);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Material.<>f__mg$cache25);
		string name = "shader";
		if (Lua_UnityEngine_Material.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Material.get_shader);
		}
		LuaCSFunction get = Lua_UnityEngine_Material.<>f__mg$cache26;
		if (Lua_UnityEngine_Material.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Material.set_shader);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Material.<>f__mg$cache27, true);
		string name2 = "color";
		if (Lua_UnityEngine_Material.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Material.get_color);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Material.<>f__mg$cache28;
		if (Lua_UnityEngine_Material.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Material.set_color);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Material.<>f__mg$cache29, true);
		string name3 = "mainTexture";
		if (Lua_UnityEngine_Material.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Material.get_mainTexture);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Material.<>f__mg$cache2A;
		if (Lua_UnityEngine_Material.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Material.set_mainTexture);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Material.<>f__mg$cache2B, true);
		string name4 = "mainTextureOffset";
		if (Lua_UnityEngine_Material.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Material.get_mainTextureOffset);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Material.<>f__mg$cache2C;
		if (Lua_UnityEngine_Material.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Material.set_mainTextureOffset);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Material.<>f__mg$cache2D, true);
		string name5 = "mainTextureScale";
		if (Lua_UnityEngine_Material.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Material.get_mainTextureScale);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Material.<>f__mg$cache2E;
		if (Lua_UnityEngine_Material.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Material.set_mainTextureScale);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Material.<>f__mg$cache2F, true);
		string name6 = "passCount";
		if (Lua_UnityEngine_Material.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Material.get_passCount);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Material.<>f__mg$cache30, null, true);
		string name7 = "renderQueue";
		if (Lua_UnityEngine_Material.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Material.get_renderQueue);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Material.<>f__mg$cache31;
		if (Lua_UnityEngine_Material.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Material.set_renderQueue);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_Material.<>f__mg$cache32, true);
		string name8 = "shaderKeywords";
		if (Lua_UnityEngine_Material.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Material.get_shaderKeywords);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Material.<>f__mg$cache33;
		if (Lua_UnityEngine_Material.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Material.set_shaderKeywords);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_Material.<>f__mg$cache34, true);
		string name9 = "globalIlluminationFlags";
		if (Lua_UnityEngine_Material.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Material.get_globalIlluminationFlags);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Material.<>f__mg$cache35;
		if (Lua_UnityEngine_Material.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Material.set_globalIlluminationFlags);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_Material.<>f__mg$cache36, true);
		string name10 = "enableInstancing";
		if (Lua_UnityEngine_Material.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Material.get_enableInstancing);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Material.<>f__mg$cache37;
		if (Lua_UnityEngine_Material.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Material.set_enableInstancing);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_Material.<>f__mg$cache38, true);
		string name11 = "doubleSidedGI";
		if (Lua_UnityEngine_Material.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_Material.get_doubleSidedGI);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Material.<>f__mg$cache39;
		if (Lua_UnityEngine_Material.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_Material.set_doubleSidedGI);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_Material.<>f__mg$cache3A, true);
		if (Lua_UnityEngine_Material.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_Material.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_Material.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Material.<>f__mg$cache3B, typeof(Material), typeof(UnityEngine.Object));
	}

	// Token: 0x04019382 RID: 103298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019383 RID: 103299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019384 RID: 103300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019385 RID: 103301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019386 RID: 103302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019387 RID: 103303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019388 RID: 103304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019389 RID: 103305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401938A RID: 103306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401938B RID: 103307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401938C RID: 103308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401938D RID: 103309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401938E RID: 103310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401938F RID: 103311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019390 RID: 103312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019391 RID: 103313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019392 RID: 103314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019393 RID: 103315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019394 RID: 103316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019395 RID: 103317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019396 RID: 103318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019397 RID: 103319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019398 RID: 103320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019399 RID: 103321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401939A RID: 103322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401939B RID: 103323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401939C RID: 103324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401939D RID: 103325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401939E RID: 103326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401939F RID: 103327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040193A0 RID: 103328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040193A1 RID: 103329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040193A2 RID: 103330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040193A3 RID: 103331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040193A4 RID: 103332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040193A5 RID: 103333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040193A6 RID: 103334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040193A7 RID: 103335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040193A8 RID: 103336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040193A9 RID: 103337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040193AA RID: 103338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040193AB RID: 103339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040193AC RID: 103340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040193AD RID: 103341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040193AE RID: 103342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040193AF RID: 103343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040193B0 RID: 103344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040193B1 RID: 103345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040193B2 RID: 103346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040193B3 RID: 103347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040193B4 RID: 103348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040193B5 RID: 103349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040193B6 RID: 103350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040193B7 RID: 103351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040193B8 RID: 103352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040193B9 RID: 103353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040193BA RID: 103354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040193BB RID: 103355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040193BC RID: 103356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040193BD RID: 103357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;
}
