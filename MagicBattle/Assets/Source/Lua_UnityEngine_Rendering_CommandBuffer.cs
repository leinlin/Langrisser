using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x02001783 RID: 6019
[Preserve]
public class Lua_UnityEngine_Rendering_CommandBuffer : LuaObject
{
	// Token: 0x06023A81 RID: 146049 RVA: 0x00C76DF4 File Offset: 0x00C74FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer o = new CommandBuffer();
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

	// Token: 0x06023A82 RID: 146050 RVA: 0x00C76E3C File Offset: 0x00C7503C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			commandBuffer.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A83 RID: 146051 RVA: 0x00C76E88 File Offset: 0x00C75088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Release(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			commandBuffer.Release();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A84 RID: 146052 RVA: 0x00C76ED4 File Offset: 0x00C750D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGPUFence(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				GPUFence gpufence = commandBuffer.CreateGPUFence();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, gpufence);
				result = 2;
			}
			else if (num == 2)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				SynchronisationStage stage;
				LuaObject.checkEnum<SynchronisationStage>(l, 2, out stage);
				GPUFence gpufence2 = commandBuffer2.CreateGPUFence(stage);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, gpufence2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CreateGPUFence to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A85 RID: 146053 RVA: 0x00C76F9C File Offset: 0x00C7519C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WaitOnGPUFence(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				GPUFence fence;
				LuaObject.checkValueType<GPUFence>(l, 2, out fence);
				commandBuffer.WaitOnGPUFence(fence);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				GPUFence fence2;
				LuaObject.checkValueType<GPUFence>(l, 2, out fence2);
				SynchronisationStage stage;
				LuaObject.checkEnum<SynchronisationStage>(l, 3, out stage);
				commandBuffer2.WaitOnGPUFence(fence2, stage);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function WaitOnGPUFence to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A86 RID: 146054 RVA: 0x00C77060 File Offset: 0x00C75260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComputeFloatParam(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(float)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				float val;
				LuaObject.checkType(l, 4, out val);
				commandBuffer.SetComputeFloatParam(computeShader, nameID, val);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(string), typeof(float)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				string name;
				LuaObject.checkType(l, 3, out name);
				float val2;
				LuaObject.checkType(l, 4, out val2);
				commandBuffer2.SetComputeFloatParam(computeShader2, name, val2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetComputeFloatParam to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A87 RID: 146055 RVA: 0x00C771A0 File Offset: 0x00C753A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComputeIntParam(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(int)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				int val;
				LuaObject.checkType(l, 4, out val);
				commandBuffer.SetComputeIntParam(computeShader, nameID, val);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(string), typeof(int)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				string name;
				LuaObject.checkType(l, 3, out name);
				int val2;
				LuaObject.checkType(l, 4, out val2);
				commandBuffer2.SetComputeIntParam(computeShader2, name, val2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetComputeIntParam to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A88 RID: 146056 RVA: 0x00C772E0 File Offset: 0x00C754E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComputeVectorParam(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(Vector4)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				Vector4 val;
				LuaObject.checkType(l, 4, out val);
				commandBuffer.SetComputeVectorParam(computeShader, nameID, val);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(string), typeof(Vector4)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				string name;
				LuaObject.checkType(l, 3, out name);
				Vector4 val2;
				LuaObject.checkType(l, 4, out val2);
				commandBuffer2.SetComputeVectorParam(computeShader2, name, val2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetComputeVectorParam to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A89 RID: 146057 RVA: 0x00C77420 File Offset: 0x00C75620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComputeVectorArrayParam(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(Vector4[])))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				Vector4[] values;
				LuaObject.checkArray<Vector4>(l, 4, out values);
				commandBuffer.SetComputeVectorArrayParam(computeShader, nameID, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(string), typeof(Vector4[])))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				string name;
				LuaObject.checkType(l, 3, out name);
				Vector4[] values2;
				LuaObject.checkArray<Vector4>(l, 4, out values2);
				commandBuffer2.SetComputeVectorArrayParam(computeShader2, name, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetComputeVectorArrayParam to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A8A RID: 146058 RVA: 0x00C77560 File Offset: 0x00C75760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComputeMatrixParam(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(Matrix4x4)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				Matrix4x4 val;
				LuaObject.checkValueType<Matrix4x4>(l, 4, out val);
				commandBuffer.SetComputeMatrixParam(computeShader, nameID, val);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(string), typeof(Matrix4x4)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				string name;
				LuaObject.checkType(l, 3, out name);
				Matrix4x4 val2;
				LuaObject.checkValueType<Matrix4x4>(l, 4, out val2);
				commandBuffer2.SetComputeMatrixParam(computeShader2, name, val2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetComputeMatrixParam to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A8B RID: 146059 RVA: 0x00C776A0 File Offset: 0x00C758A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComputeMatrixArrayParam(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(Matrix4x4[])))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				Matrix4x4[] values;
				LuaObject.checkArray<Matrix4x4>(l, 4, out values);
				commandBuffer.SetComputeMatrixArrayParam(computeShader, nameID, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(string), typeof(Matrix4x4[])))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				string name;
				LuaObject.checkType(l, 3, out name);
				Matrix4x4[] values2;
				LuaObject.checkArray<Matrix4x4>(l, 4, out values2);
				commandBuffer2.SetComputeMatrixArrayParam(computeShader2, name, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetComputeMatrixArrayParam to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A8C RID: 146060 RVA: 0x00C777E0 File Offset: 0x00C759E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComputeFloatParams(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(float[])))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				float[] values;
				LuaObject.checkParams(l, 4, out values);
				commandBuffer.SetComputeFloatParams(computeShader, nameID, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(string), typeof(float[])))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				string name;
				LuaObject.checkType(l, 3, out name);
				float[] values2;
				LuaObject.checkParams(l, 4, out values2);
				commandBuffer2.SetComputeFloatParams(computeShader2, name, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetComputeFloatParams to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A8D RID: 146061 RVA: 0x00C77920 File Offset: 0x00C75B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComputeIntParams(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(int[])))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int nameID;
				LuaObject.checkType(l, 3, out nameID);
				int[] values;
				LuaObject.checkParams(l, 4, out values);
				commandBuffer.SetComputeIntParams(computeShader, nameID, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(string), typeof(int[])))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				string name;
				LuaObject.checkType(l, 3, out name);
				int[] values2;
				LuaObject.checkParams(l, 4, out values2);
				commandBuffer2.SetComputeIntParams(computeShader2, name, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetComputeIntParams to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A8E RID: 146062 RVA: 0x00C77A60 File Offset: 0x00C75C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComputeTextureParam(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(int), typeof(RenderTargetIdentifier)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int kernelIndex;
				LuaObject.checkType(l, 3, out kernelIndex);
				int nameID;
				LuaObject.checkType(l, 4, out nameID);
				RenderTargetIdentifier rt;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 5, out rt);
				commandBuffer.SetComputeTextureParam(computeShader, kernelIndex, nameID, rt);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(string), typeof(RenderTargetIdentifier)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				int kernelIndex2;
				LuaObject.checkType(l, 3, out kernelIndex2);
				string name;
				LuaObject.checkType(l, 4, out name);
				RenderTargetIdentifier rt2;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 5, out rt2);
				commandBuffer2.SetComputeTextureParam(computeShader2, kernelIndex2, name, rt2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetComputeTextureParam to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A8F RID: 146063 RVA: 0x00C77BCC File Offset: 0x00C75DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComputeBufferParam(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(int), typeof(ComputeBuffer)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int kernelIndex;
				LuaObject.checkType(l, 3, out kernelIndex);
				int nameID;
				LuaObject.checkType(l, 4, out nameID);
				ComputeBuffer buffer;
				LuaObject.checkType<ComputeBuffer>(l, 5, out buffer);
				commandBuffer.SetComputeBufferParam(computeShader, kernelIndex, nameID, buffer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ComputeShader), typeof(int), typeof(string), typeof(ComputeBuffer)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				int kernelIndex2;
				LuaObject.checkType(l, 3, out kernelIndex2);
				string name;
				LuaObject.checkType(l, 4, out name);
				ComputeBuffer buffer2;
				LuaObject.checkType<ComputeBuffer>(l, 5, out buffer2);
				commandBuffer2.SetComputeBufferParam(computeShader2, kernelIndex2, name, buffer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetComputeBufferParam to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A90 RID: 146064 RVA: 0x00C77D38 File Offset: 0x00C75F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DispatchCompute(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader);
				int kernelIndex;
				LuaObject.checkType(l, 3, out kernelIndex);
				ComputeBuffer indirectBuffer;
				LuaObject.checkType<ComputeBuffer>(l, 4, out indirectBuffer);
				uint argsOffset;
				LuaObject.checkType(l, 5, out argsOffset);
				commandBuffer.DispatchCompute(computeShader, kernelIndex, indirectBuffer, argsOffset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				ComputeShader computeShader2;
				LuaObject.checkType<ComputeShader>(l, 2, out computeShader2);
				int kernelIndex2;
				LuaObject.checkType(l, 3, out kernelIndex2);
				int threadGroupsX;
				LuaObject.checkType(l, 4, out threadGroupsX);
				int threadGroupsY;
				LuaObject.checkType(l, 5, out threadGroupsY);
				int threadGroupsZ;
				LuaObject.checkType(l, 6, out threadGroupsZ);
				commandBuffer2.DispatchCompute(computeShader2, kernelIndex2, threadGroupsX, threadGroupsY, threadGroupsZ);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DispatchCompute to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A91 RID: 146065 RVA: 0x00C77E48 File Offset: 0x00C76048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GenerateMips(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			RenderTexture rt;
			LuaObject.checkType<RenderTexture>(l, 2, out rt);
			commandBuffer.GenerateMips(rt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A92 RID: 146066 RVA: 0x00C77EA0 File Offset: 0x00C760A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CopyCounterValue(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			ComputeBuffer src;
			LuaObject.checkType<ComputeBuffer>(l, 2, out src);
			ComputeBuffer dst;
			LuaObject.checkType<ComputeBuffer>(l, 3, out dst);
			uint dstOffsetBytes;
			LuaObject.checkType(l, 4, out dstOffsetBytes);
			commandBuffer.CopyCounterValue(src, dst, dstOffsetBytes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A93 RID: 146067 RVA: 0x00C77F14 File Offset: 0x00C76114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			commandBuffer.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A94 RID: 146068 RVA: 0x00C77F60 File Offset: 0x00C76160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawMesh(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				Mesh mesh;
				LuaObject.checkType<Mesh>(l, 2, out mesh);
				Matrix4x4 matrix;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out matrix);
				Material material;
				LuaObject.checkType<Material>(l, 4, out material);
				commandBuffer.DrawMesh(mesh, matrix, material);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				Mesh mesh2;
				LuaObject.checkType<Mesh>(l, 2, out mesh2);
				Matrix4x4 matrix2;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out matrix2);
				Material material2;
				LuaObject.checkType<Material>(l, 4, out material2);
				int submeshIndex;
				LuaObject.checkType(l, 5, out submeshIndex);
				commandBuffer2.DrawMesh(mesh2, matrix2, material2, submeshIndex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				Mesh mesh3;
				LuaObject.checkType<Mesh>(l, 2, out mesh3);
				Matrix4x4 matrix3;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out matrix3);
				Material material3;
				LuaObject.checkType<Material>(l, 4, out material3);
				int submeshIndex2;
				LuaObject.checkType(l, 5, out submeshIndex2);
				int shaderPass;
				LuaObject.checkType(l, 6, out shaderPass);
				commandBuffer3.DrawMesh(mesh3, matrix3, material3, submeshIndex2, shaderPass);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				CommandBuffer commandBuffer4 = (CommandBuffer)LuaObject.checkSelf(l);
				Mesh mesh4;
				LuaObject.checkType<Mesh>(l, 2, out mesh4);
				Matrix4x4 matrix4;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out matrix4);
				Material material4;
				LuaObject.checkType<Material>(l, 4, out material4);
				int submeshIndex3;
				LuaObject.checkType(l, 5, out submeshIndex3);
				int shaderPass2;
				LuaObject.checkType(l, 6, out shaderPass2);
				MaterialPropertyBlock properties;
				LuaObject.checkType<MaterialPropertyBlock>(l, 7, out properties);
				commandBuffer4.DrawMesh(mesh4, matrix4, material4, submeshIndex3, shaderPass2, properties);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawMesh to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A95 RID: 146069 RVA: 0x00C7813C File Offset: 0x00C7633C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawRenderer(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				Renderer renderer;
				LuaObject.checkType<Renderer>(l, 2, out renderer);
				Material material;
				LuaObject.checkType<Material>(l, 3, out material);
				commandBuffer.DrawRenderer(renderer, material);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				Renderer renderer2;
				LuaObject.checkType<Renderer>(l, 2, out renderer2);
				Material material2;
				LuaObject.checkType<Material>(l, 3, out material2);
				int submeshIndex;
				LuaObject.checkType(l, 4, out submeshIndex);
				commandBuffer2.DrawRenderer(renderer2, material2, submeshIndex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				Renderer renderer3;
				LuaObject.checkType<Renderer>(l, 2, out renderer3);
				Material material3;
				LuaObject.checkType<Material>(l, 3, out material3);
				int submeshIndex2;
				LuaObject.checkType(l, 4, out submeshIndex2);
				int shaderPass;
				LuaObject.checkType(l, 5, out shaderPass);
				commandBuffer3.DrawRenderer(renderer3, material3, submeshIndex2, shaderPass);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawRenderer to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A96 RID: 146070 RVA: 0x00C78280 File Offset: 0x00C76480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawProcedural(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 6)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				Matrix4x4 matrix;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix);
				Material material;
				LuaObject.checkType<Material>(l, 3, out material);
				int shaderPass;
				LuaObject.checkType(l, 4, out shaderPass);
				MeshTopology topology;
				LuaObject.checkEnum<MeshTopology>(l, 5, out topology);
				int vertexCount;
				LuaObject.checkType(l, 6, out vertexCount);
				commandBuffer.DrawProcedural(matrix, material, shaderPass, topology, vertexCount);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				Matrix4x4 matrix2;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix2);
				Material material2;
				LuaObject.checkType<Material>(l, 3, out material2);
				int shaderPass2;
				LuaObject.checkType(l, 4, out shaderPass2);
				MeshTopology topology2;
				LuaObject.checkEnum<MeshTopology>(l, 5, out topology2);
				int vertexCount2;
				LuaObject.checkType(l, 6, out vertexCount2);
				int instanceCount;
				LuaObject.checkType(l, 7, out instanceCount);
				commandBuffer2.DrawProcedural(matrix2, material2, shaderPass2, topology2, vertexCount2, instanceCount);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 8)
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				Matrix4x4 matrix3;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix3);
				Material material3;
				LuaObject.checkType<Material>(l, 3, out material3);
				int shaderPass3;
				LuaObject.checkType(l, 4, out shaderPass3);
				MeshTopology topology3;
				LuaObject.checkEnum<MeshTopology>(l, 5, out topology3);
				int vertexCount3;
				LuaObject.checkType(l, 6, out vertexCount3);
				int instanceCount2;
				LuaObject.checkType(l, 7, out instanceCount2);
				MaterialPropertyBlock properties;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties);
				commandBuffer3.DrawProcedural(matrix3, material3, shaderPass3, topology3, vertexCount3, instanceCount2, properties);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawProcedural to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A97 RID: 146071 RVA: 0x00C78430 File Offset: 0x00C76630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawProceduralIndirect(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 6)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				Matrix4x4 matrix;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix);
				Material material;
				LuaObject.checkType<Material>(l, 3, out material);
				int shaderPass;
				LuaObject.checkType(l, 4, out shaderPass);
				MeshTopology topology;
				LuaObject.checkEnum<MeshTopology>(l, 5, out topology);
				ComputeBuffer bufferWithArgs;
				LuaObject.checkType<ComputeBuffer>(l, 6, out bufferWithArgs);
				commandBuffer.DrawProceduralIndirect(matrix, material, shaderPass, topology, bufferWithArgs);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				Matrix4x4 matrix2;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix2);
				Material material2;
				LuaObject.checkType<Material>(l, 3, out material2);
				int shaderPass2;
				LuaObject.checkType(l, 4, out shaderPass2);
				MeshTopology topology2;
				LuaObject.checkEnum<MeshTopology>(l, 5, out topology2);
				ComputeBuffer bufferWithArgs2;
				LuaObject.checkType<ComputeBuffer>(l, 6, out bufferWithArgs2);
				int argsOffset;
				LuaObject.checkType(l, 7, out argsOffset);
				commandBuffer2.DrawProceduralIndirect(matrix2, material2, shaderPass2, topology2, bufferWithArgs2, argsOffset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 8)
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				Matrix4x4 matrix3;
				LuaObject.checkValueType<Matrix4x4>(l, 2, out matrix3);
				Material material3;
				LuaObject.checkType<Material>(l, 3, out material3);
				int shaderPass3;
				LuaObject.checkType(l, 4, out shaderPass3);
				MeshTopology topology3;
				LuaObject.checkEnum<MeshTopology>(l, 5, out topology3);
				ComputeBuffer bufferWithArgs3;
				LuaObject.checkType<ComputeBuffer>(l, 6, out bufferWithArgs3);
				int argsOffset2;
				LuaObject.checkType(l, 7, out argsOffset2);
				MaterialPropertyBlock properties;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties);
				commandBuffer3.DrawProceduralIndirect(matrix3, material3, shaderPass3, topology3, bufferWithArgs3, argsOffset2, properties);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawProceduralIndirect to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A98 RID: 146072 RVA: 0x00C785E0 File Offset: 0x00C767E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawMeshInstanced(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 6)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				Mesh mesh;
				LuaObject.checkType<Mesh>(l, 2, out mesh);
				int submeshIndex;
				LuaObject.checkType(l, 3, out submeshIndex);
				Material material;
				LuaObject.checkType<Material>(l, 4, out material);
				int shaderPass;
				LuaObject.checkType(l, 5, out shaderPass);
				Matrix4x4[] matrices;
				LuaObject.checkArray<Matrix4x4>(l, 6, out matrices);
				commandBuffer.DrawMeshInstanced(mesh, submeshIndex, material, shaderPass, matrices);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				Mesh mesh2;
				LuaObject.checkType<Mesh>(l, 2, out mesh2);
				int submeshIndex2;
				LuaObject.checkType(l, 3, out submeshIndex2);
				Material material2;
				LuaObject.checkType<Material>(l, 4, out material2);
				int shaderPass2;
				LuaObject.checkType(l, 5, out shaderPass2);
				Matrix4x4[] matrices2;
				LuaObject.checkArray<Matrix4x4>(l, 6, out matrices2);
				int count;
				LuaObject.checkType(l, 7, out count);
				commandBuffer2.DrawMeshInstanced(mesh2, submeshIndex2, material2, shaderPass2, matrices2, count);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 8)
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				Mesh mesh3;
				LuaObject.checkType<Mesh>(l, 2, out mesh3);
				int submeshIndex3;
				LuaObject.checkType(l, 3, out submeshIndex3);
				Material material3;
				LuaObject.checkType<Material>(l, 4, out material3);
				int shaderPass3;
				LuaObject.checkType(l, 5, out shaderPass3);
				Matrix4x4[] matrices3;
				LuaObject.checkArray<Matrix4x4>(l, 6, out matrices3);
				int count2;
				LuaObject.checkType(l, 7, out count2);
				MaterialPropertyBlock properties;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties);
				commandBuffer3.DrawMeshInstanced(mesh3, submeshIndex3, material3, shaderPass3, matrices3, count2, properties);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawMeshInstanced to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A99 RID: 146073 RVA: 0x00C78790 File Offset: 0x00C76990
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DrawMeshInstancedIndirect(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 6)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				Mesh mesh;
				LuaObject.checkType<Mesh>(l, 2, out mesh);
				int submeshIndex;
				LuaObject.checkType(l, 3, out submeshIndex);
				Material material;
				LuaObject.checkType<Material>(l, 4, out material);
				int shaderPass;
				LuaObject.checkType(l, 5, out shaderPass);
				ComputeBuffer bufferWithArgs;
				LuaObject.checkType<ComputeBuffer>(l, 6, out bufferWithArgs);
				commandBuffer.DrawMeshInstancedIndirect(mesh, submeshIndex, material, shaderPass, bufferWithArgs);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				Mesh mesh2;
				LuaObject.checkType<Mesh>(l, 2, out mesh2);
				int submeshIndex2;
				LuaObject.checkType(l, 3, out submeshIndex2);
				Material material2;
				LuaObject.checkType<Material>(l, 4, out material2);
				int shaderPass2;
				LuaObject.checkType(l, 5, out shaderPass2);
				ComputeBuffer bufferWithArgs2;
				LuaObject.checkType<ComputeBuffer>(l, 6, out bufferWithArgs2);
				int argsOffset;
				LuaObject.checkType(l, 7, out argsOffset);
				commandBuffer2.DrawMeshInstancedIndirect(mesh2, submeshIndex2, material2, shaderPass2, bufferWithArgs2, argsOffset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 8)
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				Mesh mesh3;
				LuaObject.checkType<Mesh>(l, 2, out mesh3);
				int submeshIndex3;
				LuaObject.checkType(l, 3, out submeshIndex3);
				Material material3;
				LuaObject.checkType<Material>(l, 4, out material3);
				int shaderPass3;
				LuaObject.checkType(l, 5, out shaderPass3);
				ComputeBuffer bufferWithArgs3;
				LuaObject.checkType<ComputeBuffer>(l, 6, out bufferWithArgs3);
				int argsOffset2;
				LuaObject.checkType(l, 7, out argsOffset2);
				MaterialPropertyBlock properties;
				LuaObject.checkType<MaterialPropertyBlock>(l, 8, out properties);
				commandBuffer3.DrawMeshInstancedIndirect(mesh3, submeshIndex3, material3, shaderPass3, bufferWithArgs3, argsOffset2, properties);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawMeshInstancedIndirect to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A9A RID: 146074 RVA: 0x00C78940 File Offset: 0x00C76B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRenderTarget(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier renderTarget;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out renderTarget);
				commandBuffer.SetRenderTarget(renderTarget);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier color;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out color);
				RenderTargetIdentifier depth;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out depth);
				commandBuffer2.SetRenderTarget(color, depth);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier)))
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier[] colors;
				LuaObject.checkArray<RenderTargetIdentifier>(l, 2, out colors);
				RenderTargetIdentifier depth2;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out depth2);
				commandBuffer3.SetRenderTarget(colors, depth2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderTargetIdentifier), typeof(int)))
			{
				CommandBuffer commandBuffer4 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier rt;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out rt);
				int mipLevel;
				LuaObject.checkType(l, 3, out mipLevel);
				commandBuffer4.SetRenderTarget(rt, mipLevel);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(int)))
			{
				CommandBuffer commandBuffer5 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier color2;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out color2);
				RenderTargetIdentifier depth3;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out depth3);
				int mipLevel2;
				LuaObject.checkType(l, 4, out mipLevel2);
				commandBuffer5.SetRenderTarget(color2, depth3, mipLevel2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace)))
			{
				CommandBuffer commandBuffer6 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier rt2;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out rt2);
				int mipLevel3;
				LuaObject.checkType(l, 3, out mipLevel3);
				CubemapFace cubemapFace;
				LuaObject.checkEnum<CubemapFace>(l, 4, out cubemapFace);
				commandBuffer6.SetRenderTarget(rt2, mipLevel3, cubemapFace);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace), typeof(int)))
			{
				CommandBuffer commandBuffer7 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier rt3;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out rt3);
				int mipLevel4;
				LuaObject.checkType(l, 3, out mipLevel4);
				CubemapFace cubemapFace2;
				LuaObject.checkEnum<CubemapFace>(l, 4, out cubemapFace2);
				int depthSlice;
				LuaObject.checkType(l, 5, out depthSlice);
				commandBuffer7.SetRenderTarget(rt3, mipLevel4, cubemapFace2, depthSlice);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(int), typeof(CubemapFace)))
			{
				CommandBuffer commandBuffer8 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier color3;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out color3);
				RenderTargetIdentifier depth4;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out depth4);
				int mipLevel5;
				LuaObject.checkType(l, 4, out mipLevel5);
				CubemapFace cubemapFace3;
				LuaObject.checkEnum<CubemapFace>(l, 5, out cubemapFace3);
				commandBuffer8.SetRenderTarget(color3, depth4, mipLevel5, cubemapFace3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				CommandBuffer commandBuffer9 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier color4;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out color4);
				RenderTargetIdentifier depth5;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out depth5);
				int mipLevel6;
				LuaObject.checkType(l, 4, out mipLevel6);
				CubemapFace cubemapFace4;
				LuaObject.checkEnum<CubemapFace>(l, 5, out cubemapFace4);
				int depthSlice2;
				LuaObject.checkType(l, 6, out depthSlice2);
				commandBuffer9.SetRenderTarget(color4, depth5, mipLevel6, cubemapFace4, depthSlice2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetRenderTarget to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A9B RID: 146075 RVA: 0x00C78D34 File Offset: 0x00C76F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomWriteTarget(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(int), typeof(ComputeBuffer)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				int index;
				LuaObject.checkType(l, 2, out index);
				ComputeBuffer buffer;
				LuaObject.checkType<ComputeBuffer>(l, 3, out buffer);
				commandBuffer.SetRandomWriteTarget(index, buffer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(RenderTargetIdentifier)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				int index2;
				LuaObject.checkType(l, 2, out index2);
				RenderTargetIdentifier rt;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out rt);
				commandBuffer2.SetRandomWriteTarget(index2, rt);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				int index3;
				LuaObject.checkType(l, 2, out index3);
				ComputeBuffer buffer2;
				LuaObject.checkType<ComputeBuffer>(l, 3, out buffer2);
				bool preserveCounterValue;
				LuaObject.checkType(l, 4, out preserveCounterValue);
				commandBuffer3.SetRandomWriteTarget(index3, buffer2, preserveCounterValue);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetRandomWriteTarget to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A9C RID: 146076 RVA: 0x00C78E94 File Offset: 0x00C77094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRandomWriteTargets(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			commandBuffer.ClearRandomWriteTargets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A9D RID: 146077 RVA: 0x00C78EE0 File Offset: 0x00C770E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CopyTexture(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier src;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out src);
				RenderTargetIdentifier dst;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out dst);
				commandBuffer.CopyTexture(src, dst);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier src2;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out src2);
				int srcElement;
				LuaObject.checkType(l, 3, out srcElement);
				RenderTargetIdentifier dst2;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 4, out dst2);
				int dstElement;
				LuaObject.checkType(l, 5, out dstElement);
				commandBuffer2.CopyTexture(src2, srcElement, dst2, dstElement);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier src3;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out src3);
				int srcElement2;
				LuaObject.checkType(l, 3, out srcElement2);
				int srcMip;
				LuaObject.checkType(l, 4, out srcMip);
				RenderTargetIdentifier dst3;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 5, out dst3);
				int dstElement2;
				LuaObject.checkType(l, 6, out dstElement2);
				int dstMip;
				LuaObject.checkType(l, 7, out dstMip);
				commandBuffer3.CopyTexture(src3, srcElement2, srcMip, dst3, dstElement2, dstMip);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 13)
			{
				CommandBuffer commandBuffer4 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier src4;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out src4);
				int srcElement3;
				LuaObject.checkType(l, 3, out srcElement3);
				int srcMip2;
				LuaObject.checkType(l, 4, out srcMip2);
				int srcX;
				LuaObject.checkType(l, 5, out srcX);
				int srcY;
				LuaObject.checkType(l, 6, out srcY);
				int srcWidth;
				LuaObject.checkType(l, 7, out srcWidth);
				int srcHeight;
				LuaObject.checkType(l, 8, out srcHeight);
				RenderTargetIdentifier dst4;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 9, out dst4);
				int dstElement3;
				LuaObject.checkType(l, 10, out dstElement3);
				int dstMip2;
				LuaObject.checkType(l, 11, out dstMip2);
				int dstX;
				LuaObject.checkType(l, 12, out dstX);
				int dstY;
				LuaObject.checkType(l, 13, out dstY);
				commandBuffer4.CopyTexture(src4, srcElement3, srcMip2, srcX, srcY, srcWidth, srcHeight, dst4, dstElement3, dstMip2, dstX, dstY);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CopyTexture to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A9E RID: 146078 RVA: 0x00C79108 File Offset: 0x00C77308
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetViewport(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			Rect viewport;
			LuaObject.checkValueType<Rect>(l, 2, out viewport);
			commandBuffer.SetViewport(viewport);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A9F RID: 146079 RVA: 0x00C79160 File Offset: 0x00C77360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Blit(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier source;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out source);
				RenderTargetIdentifier dest;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out dest);
				commandBuffer.Blit(source, dest);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Texture), typeof(RenderTargetIdentifier)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				Texture source2;
				LuaObject.checkType<Texture>(l, 2, out source2);
				RenderTargetIdentifier dest2;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out dest2);
				commandBuffer2.Blit(source2, dest2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(Material)))
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier source3;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out source3);
				RenderTargetIdentifier dest3;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out dest3);
				Material mat;
				LuaObject.checkType<Material>(l, 4, out mat);
				commandBuffer3.Blit(source3, dest3, mat);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Texture), typeof(RenderTargetIdentifier), typeof(Material)))
			{
				CommandBuffer commandBuffer4 = (CommandBuffer)LuaObject.checkSelf(l);
				Texture source4;
				LuaObject.checkType<Texture>(l, 2, out source4);
				RenderTargetIdentifier dest4;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out dest4);
				Material mat2;
				LuaObject.checkType<Material>(l, 4, out mat2);
				commandBuffer4.Blit(source4, dest4, mat2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(Material), typeof(int)))
			{
				CommandBuffer commandBuffer5 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier source5;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out source5);
				RenderTargetIdentifier dest5;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out dest5);
				Material mat3;
				LuaObject.checkType<Material>(l, 4, out mat3);
				int pass;
				LuaObject.checkType(l, 5, out pass);
				commandBuffer5.Blit(source5, dest5, mat3, pass);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(Vector2), typeof(Vector2)))
			{
				CommandBuffer commandBuffer6 = (CommandBuffer)LuaObject.checkSelf(l);
				RenderTargetIdentifier source6;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out source6);
				RenderTargetIdentifier dest6;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out dest6);
				Vector2 scale;
				LuaObject.checkType(l, 4, out scale);
				Vector2 offset;
				LuaObject.checkType(l, 5, out offset);
				commandBuffer6.Blit(source6, dest6, scale, offset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Texture), typeof(RenderTargetIdentifier), typeof(Vector2), typeof(Vector2)))
			{
				CommandBuffer commandBuffer7 = (CommandBuffer)LuaObject.checkSelf(l);
				Texture source7;
				LuaObject.checkType<Texture>(l, 2, out source7);
				RenderTargetIdentifier dest7;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out dest7);
				Vector2 scale2;
				LuaObject.checkType(l, 4, out scale2);
				Vector2 offset2;
				LuaObject.checkType(l, 5, out offset2);
				commandBuffer7.Blit(source7, dest7, scale2, offset2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Texture), typeof(RenderTargetIdentifier), typeof(Material), typeof(int)))
			{
				CommandBuffer commandBuffer8 = (CommandBuffer)LuaObject.checkSelf(l);
				Texture source8;
				LuaObject.checkType<Texture>(l, 2, out source8);
				RenderTargetIdentifier dest8;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out dest8);
				Material mat4;
				LuaObject.checkType<Material>(l, 4, out mat4);
				int pass2;
				LuaObject.checkType(l, 5, out pass2);
				commandBuffer8.Blit(source8, dest8, mat4, pass2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Blit to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AA0 RID: 146080 RVA: 0x00C79578 File Offset: 0x00C77778
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTemporaryRT(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				RenderTextureDescriptor desc;
				LuaObject.checkValueType<RenderTextureDescriptor>(l, 3, out desc);
				commandBuffer.GetTemporaryRT(nameID, desc);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(int), typeof(int)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				int width;
				LuaObject.checkType(l, 3, out width);
				int height;
				LuaObject.checkType(l, 4, out height);
				commandBuffer2.GetTemporaryRT(nameID2, width, height);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(RenderTextureDescriptor), typeof(FilterMode)))
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID3;
				LuaObject.checkType(l, 2, out nameID3);
				RenderTextureDescriptor desc2;
				LuaObject.checkValueType<RenderTextureDescriptor>(l, 3, out desc2);
				FilterMode filter;
				LuaObject.checkEnum<FilterMode>(l, 4, out filter);
				commandBuffer3.GetTemporaryRT(nameID3, desc2, filter);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				CommandBuffer commandBuffer4 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID4;
				LuaObject.checkType(l, 2, out nameID4);
				int width2;
				LuaObject.checkType(l, 3, out width2);
				int height2;
				LuaObject.checkType(l, 4, out height2);
				int depthBuffer;
				LuaObject.checkType(l, 5, out depthBuffer);
				commandBuffer4.GetTemporaryRT(nameID4, width2, height2, depthBuffer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				CommandBuffer commandBuffer5 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID5;
				LuaObject.checkType(l, 2, out nameID5);
				int width3;
				LuaObject.checkType(l, 3, out width3);
				int height3;
				LuaObject.checkType(l, 4, out height3);
				int depthBuffer2;
				LuaObject.checkType(l, 5, out depthBuffer2);
				FilterMode filter2;
				LuaObject.checkEnum<FilterMode>(l, 6, out filter2);
				commandBuffer5.GetTemporaryRT(nameID5, width3, height3, depthBuffer2, filter2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				CommandBuffer commandBuffer6 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID6;
				LuaObject.checkType(l, 2, out nameID6);
				int width4;
				LuaObject.checkType(l, 3, out width4);
				int height4;
				LuaObject.checkType(l, 4, out height4);
				int depthBuffer3;
				LuaObject.checkType(l, 5, out depthBuffer3);
				FilterMode filter3;
				LuaObject.checkEnum<FilterMode>(l, 6, out filter3);
				RenderTextureFormat format;
				LuaObject.checkEnum<RenderTextureFormat>(l, 7, out format);
				commandBuffer6.GetTemporaryRT(nameID6, width4, height4, depthBuffer3, filter3, format);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 8)
			{
				CommandBuffer commandBuffer7 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID7;
				LuaObject.checkType(l, 2, out nameID7);
				int width5;
				LuaObject.checkType(l, 3, out width5);
				int height5;
				LuaObject.checkType(l, 4, out height5);
				int depthBuffer4;
				LuaObject.checkType(l, 5, out depthBuffer4);
				FilterMode filter4;
				LuaObject.checkEnum<FilterMode>(l, 6, out filter4);
				RenderTextureFormat format2;
				LuaObject.checkEnum<RenderTextureFormat>(l, 7, out format2);
				RenderTextureReadWrite readWrite;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 8, out readWrite);
				commandBuffer7.GetTemporaryRT(nameID7, width5, height5, depthBuffer4, filter4, format2, readWrite);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 9)
			{
				CommandBuffer commandBuffer8 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID8;
				LuaObject.checkType(l, 2, out nameID8);
				int width6;
				LuaObject.checkType(l, 3, out width6);
				int height6;
				LuaObject.checkType(l, 4, out height6);
				int depthBuffer5;
				LuaObject.checkType(l, 5, out depthBuffer5);
				FilterMode filter5;
				LuaObject.checkEnum<FilterMode>(l, 6, out filter5);
				RenderTextureFormat format3;
				LuaObject.checkEnum<RenderTextureFormat>(l, 7, out format3);
				RenderTextureReadWrite readWrite2;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 8, out readWrite2);
				int antiAliasing;
				LuaObject.checkType(l, 9, out antiAliasing);
				commandBuffer8.GetTemporaryRT(nameID8, width6, height6, depthBuffer5, filter5, format3, readWrite2, antiAliasing);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 10)
			{
				CommandBuffer commandBuffer9 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID9;
				LuaObject.checkType(l, 2, out nameID9);
				int width7;
				LuaObject.checkType(l, 3, out width7);
				int height7;
				LuaObject.checkType(l, 4, out height7);
				int depthBuffer6;
				LuaObject.checkType(l, 5, out depthBuffer6);
				FilterMode filter6;
				LuaObject.checkEnum<FilterMode>(l, 6, out filter6);
				RenderTextureFormat format4;
				LuaObject.checkEnum<RenderTextureFormat>(l, 7, out format4);
				RenderTextureReadWrite readWrite3;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 8, out readWrite3);
				int antiAliasing2;
				LuaObject.checkType(l, 9, out antiAliasing2);
				bool enableRandomWrite;
				LuaObject.checkType(l, 10, out enableRandomWrite);
				commandBuffer9.GetTemporaryRT(nameID9, width7, height7, depthBuffer6, filter6, format4, readWrite3, antiAliasing2, enableRandomWrite);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 11)
			{
				CommandBuffer commandBuffer10 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID10;
				LuaObject.checkType(l, 2, out nameID10);
				int width8;
				LuaObject.checkType(l, 3, out width8);
				int height8;
				LuaObject.checkType(l, 4, out height8);
				int depthBuffer7;
				LuaObject.checkType(l, 5, out depthBuffer7);
				FilterMode filter7;
				LuaObject.checkEnum<FilterMode>(l, 6, out filter7);
				RenderTextureFormat format5;
				LuaObject.checkEnum<RenderTextureFormat>(l, 7, out format5);
				RenderTextureReadWrite readWrite4;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 8, out readWrite4);
				int antiAliasing3;
				LuaObject.checkType(l, 9, out antiAliasing3);
				bool enableRandomWrite2;
				LuaObject.checkType(l, 10, out enableRandomWrite2);
				RenderTextureMemoryless memorylessMode;
				LuaObject.checkEnum<RenderTextureMemoryless>(l, 11, out memorylessMode);
				commandBuffer10.GetTemporaryRT(nameID10, width8, height8, depthBuffer7, filter7, format5, readWrite4, antiAliasing3, enableRandomWrite2, memorylessMode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 12)
			{
				CommandBuffer commandBuffer11 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID11;
				LuaObject.checkType(l, 2, out nameID11);
				int width9;
				LuaObject.checkType(l, 3, out width9);
				int height9;
				LuaObject.checkType(l, 4, out height9);
				int depthBuffer8;
				LuaObject.checkType(l, 5, out depthBuffer8);
				FilterMode filter8;
				LuaObject.checkEnum<FilterMode>(l, 6, out filter8);
				RenderTextureFormat format6;
				LuaObject.checkEnum<RenderTextureFormat>(l, 7, out format6);
				RenderTextureReadWrite readWrite5;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 8, out readWrite5);
				int antiAliasing4;
				LuaObject.checkType(l, 9, out antiAliasing4);
				bool enableRandomWrite3;
				LuaObject.checkType(l, 10, out enableRandomWrite3);
				RenderTextureMemoryless memorylessMode2;
				LuaObject.checkEnum<RenderTextureMemoryless>(l, 11, out memorylessMode2);
				bool useDynamicScale;
				LuaObject.checkType(l, 12, out useDynamicScale);
				commandBuffer11.GetTemporaryRT(nameID11, width9, height9, depthBuffer8, filter8, format6, readWrite5, antiAliasing4, enableRandomWrite3, memorylessMode2, useDynamicScale);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetTemporaryRT to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AA1 RID: 146081 RVA: 0x00C79B28 File Offset: 0x00C77D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTemporaryRTArray(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				int width;
				LuaObject.checkType(l, 3, out width);
				int height;
				LuaObject.checkType(l, 4, out height);
				int slices;
				LuaObject.checkType(l, 5, out slices);
				commandBuffer.GetTemporaryRTArray(nameID, width, height, slices);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				int width2;
				LuaObject.checkType(l, 3, out width2);
				int height2;
				LuaObject.checkType(l, 4, out height2);
				int slices2;
				LuaObject.checkType(l, 5, out slices2);
				int depthBuffer;
				LuaObject.checkType(l, 6, out depthBuffer);
				commandBuffer2.GetTemporaryRTArray(nameID2, width2, height2, slices2, depthBuffer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID3;
				LuaObject.checkType(l, 2, out nameID3);
				int width3;
				LuaObject.checkType(l, 3, out width3);
				int height3;
				LuaObject.checkType(l, 4, out height3);
				int slices3;
				LuaObject.checkType(l, 5, out slices3);
				int depthBuffer2;
				LuaObject.checkType(l, 6, out depthBuffer2);
				FilterMode filter;
				LuaObject.checkEnum<FilterMode>(l, 7, out filter);
				commandBuffer3.GetTemporaryRTArray(nameID3, width3, height3, slices3, depthBuffer2, filter);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 8)
			{
				CommandBuffer commandBuffer4 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID4;
				LuaObject.checkType(l, 2, out nameID4);
				int width4;
				LuaObject.checkType(l, 3, out width4);
				int height4;
				LuaObject.checkType(l, 4, out height4);
				int slices4;
				LuaObject.checkType(l, 5, out slices4);
				int depthBuffer3;
				LuaObject.checkType(l, 6, out depthBuffer3);
				FilterMode filter2;
				LuaObject.checkEnum<FilterMode>(l, 7, out filter2);
				RenderTextureFormat format;
				LuaObject.checkEnum<RenderTextureFormat>(l, 8, out format);
				commandBuffer4.GetTemporaryRTArray(nameID4, width4, height4, slices4, depthBuffer3, filter2, format);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 9)
			{
				CommandBuffer commandBuffer5 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID5;
				LuaObject.checkType(l, 2, out nameID5);
				int width5;
				LuaObject.checkType(l, 3, out width5);
				int height5;
				LuaObject.checkType(l, 4, out height5);
				int slices5;
				LuaObject.checkType(l, 5, out slices5);
				int depthBuffer4;
				LuaObject.checkType(l, 6, out depthBuffer4);
				FilterMode filter3;
				LuaObject.checkEnum<FilterMode>(l, 7, out filter3);
				RenderTextureFormat format2;
				LuaObject.checkEnum<RenderTextureFormat>(l, 8, out format2);
				RenderTextureReadWrite readWrite;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 9, out readWrite);
				commandBuffer5.GetTemporaryRTArray(nameID5, width5, height5, slices5, depthBuffer4, filter3, format2, readWrite);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 10)
			{
				CommandBuffer commandBuffer6 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID6;
				LuaObject.checkType(l, 2, out nameID6);
				int width6;
				LuaObject.checkType(l, 3, out width6);
				int height6;
				LuaObject.checkType(l, 4, out height6);
				int slices6;
				LuaObject.checkType(l, 5, out slices6);
				int depthBuffer5;
				LuaObject.checkType(l, 6, out depthBuffer5);
				FilterMode filter4;
				LuaObject.checkEnum<FilterMode>(l, 7, out filter4);
				RenderTextureFormat format3;
				LuaObject.checkEnum<RenderTextureFormat>(l, 8, out format3);
				RenderTextureReadWrite readWrite2;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 9, out readWrite2);
				int antiAliasing;
				LuaObject.checkType(l, 10, out antiAliasing);
				commandBuffer6.GetTemporaryRTArray(nameID6, width6, height6, slices6, depthBuffer5, filter4, format3, readWrite2, antiAliasing);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 11)
			{
				CommandBuffer commandBuffer7 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID7;
				LuaObject.checkType(l, 2, out nameID7);
				int width7;
				LuaObject.checkType(l, 3, out width7);
				int height7;
				LuaObject.checkType(l, 4, out height7);
				int slices7;
				LuaObject.checkType(l, 5, out slices7);
				int depthBuffer6;
				LuaObject.checkType(l, 6, out depthBuffer6);
				FilterMode filter5;
				LuaObject.checkEnum<FilterMode>(l, 7, out filter5);
				RenderTextureFormat format4;
				LuaObject.checkEnum<RenderTextureFormat>(l, 8, out format4);
				RenderTextureReadWrite readWrite3;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 9, out readWrite3);
				int antiAliasing2;
				LuaObject.checkType(l, 10, out antiAliasing2);
				bool enableRandomWrite;
				LuaObject.checkType(l, 11, out enableRandomWrite);
				commandBuffer7.GetTemporaryRTArray(nameID7, width7, height7, slices7, depthBuffer6, filter5, format4, readWrite3, antiAliasing2, enableRandomWrite);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 12)
			{
				CommandBuffer commandBuffer8 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID8;
				LuaObject.checkType(l, 2, out nameID8);
				int width8;
				LuaObject.checkType(l, 3, out width8);
				int height8;
				LuaObject.checkType(l, 4, out height8);
				int slices8;
				LuaObject.checkType(l, 5, out slices8);
				int depthBuffer7;
				LuaObject.checkType(l, 6, out depthBuffer7);
				FilterMode filter6;
				LuaObject.checkEnum<FilterMode>(l, 7, out filter6);
				RenderTextureFormat format5;
				LuaObject.checkEnum<RenderTextureFormat>(l, 8, out format5);
				RenderTextureReadWrite readWrite4;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 9, out readWrite4);
				int antiAliasing3;
				LuaObject.checkType(l, 10, out antiAliasing3);
				bool enableRandomWrite2;
				LuaObject.checkType(l, 11, out enableRandomWrite2);
				bool useDynamicScale;
				LuaObject.checkType(l, 12, out useDynamicScale);
				commandBuffer8.GetTemporaryRTArray(nameID8, width8, height8, slices8, depthBuffer7, filter6, format5, readWrite4, antiAliasing3, enableRandomWrite2, useDynamicScale);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetTemporaryRTArray to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AA2 RID: 146082 RVA: 0x00C79FB0 File Offset: 0x00C781B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReleaseTemporaryRT(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			int nameID;
			LuaObject.checkType(l, 2, out nameID);
			commandBuffer.ReleaseTemporaryRT(nameID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AA3 RID: 146083 RVA: 0x00C7A008 File Offset: 0x00C78208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRenderTarget(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				bool clearDepth;
				LuaObject.checkType(l, 2, out clearDepth);
				bool clearColor;
				LuaObject.checkType(l, 3, out clearColor);
				Color backgroundColor;
				LuaObject.checkType(l, 4, out backgroundColor);
				commandBuffer.ClearRenderTarget(clearDepth, clearColor, backgroundColor);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				bool clearDepth2;
				LuaObject.checkType(l, 2, out clearDepth2);
				bool clearColor2;
				LuaObject.checkType(l, 3, out clearColor2);
				Color backgroundColor2;
				LuaObject.checkType(l, 4, out backgroundColor2);
				float depth;
				LuaObject.checkType(l, 5, out depth);
				commandBuffer2.ClearRenderTarget(clearDepth2, clearColor2, backgroundColor2, depth);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ClearRenderTarget to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AA4 RID: 146084 RVA: 0x00C7A100 File Offset: 0x00C78300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalFloat(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float value;
				LuaObject.checkType(l, 3, out value);
				commandBuffer.SetGlobalFloat(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float value2;
				LuaObject.checkType(l, 3, out value2);
				commandBuffer2.SetGlobalFloat(name, value2);
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

	// Token: 0x06023AA5 RID: 146085 RVA: 0x00C7A208 File Offset: 0x00C78408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalVector(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Vector4)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4 value;
				LuaObject.checkType(l, 3, out value);
				commandBuffer.SetGlobalVector(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Vector4)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Vector4 value2;
				LuaObject.checkType(l, 3, out value2);
				commandBuffer2.SetGlobalVector(name, value2);
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

	// Token: 0x06023AA6 RID: 146086 RVA: 0x00C7A310 File Offset: 0x00C78510
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGlobalColor(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Color)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Color value;
				LuaObject.checkType(l, 3, out value);
				commandBuffer.SetGlobalColor(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Color)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Color value2;
				LuaObject.checkType(l, 3, out value2);
				commandBuffer2.SetGlobalColor(name, value2);
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

	// Token: 0x06023AA7 RID: 146087 RVA: 0x00C7A418 File Offset: 0x00C78618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalMatrix(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Matrix4x4)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4 value;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out value);
				commandBuffer.SetGlobalMatrix(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Matrix4x4)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				Matrix4x4 value2;
				LuaObject.checkValueType<Matrix4x4>(l, 3, out value2);
				commandBuffer2.SetGlobalMatrix(name, value2);
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

	// Token: 0x06023AA8 RID: 146088 RVA: 0x00C7A520 File Offset: 0x00C78720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableShaderKeyword(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			string keyword;
			LuaObject.checkType(l, 2, out keyword);
			commandBuffer.EnableShaderKeyword(keyword);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AA9 RID: 146089 RVA: 0x00C7A578 File Offset: 0x00C78778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DisableShaderKeyword(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			string keyword;
			LuaObject.checkType(l, 2, out keyword);
			commandBuffer.DisableShaderKeyword(keyword);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AAA RID: 146090 RVA: 0x00C7A5D0 File Offset: 0x00C787D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetViewMatrix(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			Matrix4x4 viewMatrix;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out viewMatrix);
			commandBuffer.SetViewMatrix(viewMatrix);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AAB RID: 146091 RVA: 0x00C7A628 File Offset: 0x00C78828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetProjectionMatrix(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			Matrix4x4 projectionMatrix;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out projectionMatrix);
			commandBuffer.SetProjectionMatrix(projectionMatrix);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AAC RID: 146092 RVA: 0x00C7A680 File Offset: 0x00C78880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetViewProjectionMatrices(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			Matrix4x4 view;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out view);
			Matrix4x4 proj;
			LuaObject.checkValueType<Matrix4x4>(l, 3, out proj);
			commandBuffer.SetViewProjectionMatrices(view, proj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AAD RID: 146093 RVA: 0x00C7A6E4 File Offset: 0x00C788E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalDepthBias(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			float bias;
			LuaObject.checkType(l, 2, out bias);
			float slopeBias;
			LuaObject.checkType(l, 3, out slopeBias);
			commandBuffer.SetGlobalDepthBias(bias, slopeBias);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AAE RID: 146094 RVA: 0x00C7A748 File Offset: 0x00C78948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGlobalFloatArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float[])))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				string propertyName;
				LuaObject.checkType(l, 2, out propertyName);
				float[] values;
				LuaObject.checkArray<float>(l, 3, out values);
				commandBuffer.SetGlobalFloatArray(propertyName, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float[])))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				float[] values2;
				LuaObject.checkArray<float>(l, 3, out values2);
				commandBuffer2.SetGlobalFloatArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<float>)))
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				string propertyName2;
				LuaObject.checkType(l, 2, out propertyName2);
				List<float> values3;
				LuaObject.checkType<List<float>>(l, 3, out values3);
				commandBuffer3.SetGlobalFloatArray(propertyName2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<float>)))
			{
				CommandBuffer commandBuffer4 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<float> values4;
				LuaObject.checkType<List<float>>(l, 3, out values4);
				commandBuffer4.SetGlobalFloatArray(nameID2, values4);
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

	// Token: 0x06023AAF RID: 146095 RVA: 0x00C7A914 File Offset: 0x00C78B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalVectorArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Vector4[])))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				string propertyName;
				LuaObject.checkType(l, 2, out propertyName);
				Vector4[] values;
				LuaObject.checkArray<Vector4>(l, 3, out values);
				commandBuffer.SetGlobalVectorArray(propertyName, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Vector4[])))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Vector4[] values2;
				LuaObject.checkArray<Vector4>(l, 3, out values2);
				commandBuffer2.SetGlobalVectorArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Vector4>)))
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				string propertyName2;
				LuaObject.checkType(l, 2, out propertyName2);
				List<Vector4> values3;
				LuaObject.checkType<List<Vector4>>(l, 3, out values3);
				commandBuffer3.SetGlobalVectorArray(propertyName2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector4>)))
			{
				CommandBuffer commandBuffer4 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Vector4> values4;
				LuaObject.checkType<List<Vector4>>(l, 3, out values4);
				commandBuffer4.SetGlobalVectorArray(nameID2, values4);
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

	// Token: 0x06023AB0 RID: 146096 RVA: 0x00C7AAE0 File Offset: 0x00C78CE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGlobalMatrixArray(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Matrix4x4[])))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				string propertyName;
				LuaObject.checkType(l, 2, out propertyName);
				Matrix4x4[] values;
				LuaObject.checkArray<Matrix4x4>(l, 3, out values);
				commandBuffer.SetGlobalMatrixArray(propertyName, values);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(Matrix4x4[])))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				Matrix4x4[] values2;
				LuaObject.checkArray<Matrix4x4>(l, 3, out values2);
				commandBuffer2.SetGlobalMatrixArray(nameID, values2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(List<Matrix4x4>)))
			{
				CommandBuffer commandBuffer3 = (CommandBuffer)LuaObject.checkSelf(l);
				string propertyName2;
				LuaObject.checkType(l, 2, out propertyName2);
				List<Matrix4x4> values3;
				LuaObject.checkType<List<Matrix4x4>>(l, 3, out values3);
				commandBuffer3.SetGlobalMatrixArray(propertyName2, values3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Matrix4x4>)))
			{
				CommandBuffer commandBuffer4 = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				List<Matrix4x4> values4;
				LuaObject.checkType<List<Matrix4x4>>(l, 3, out values4);
				commandBuffer4.SetGlobalMatrixArray(nameID2, values4);
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

	// Token: 0x06023AB1 RID: 146097 RVA: 0x00C7ACAC File Offset: 0x00C78EAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGlobalTexture(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(RenderTargetIdentifier)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				RenderTargetIdentifier value;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out value);
				commandBuffer.SetGlobalTexture(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(RenderTargetIdentifier)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				RenderTargetIdentifier value2;
				LuaObject.checkValueType<RenderTargetIdentifier>(l, 3, out value2);
				commandBuffer2.SetGlobalTexture(name, value2);
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

	// Token: 0x06023AB2 RID: 146098 RVA: 0x00C7ADB4 File Offset: 0x00C78FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalBuffer(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(ComputeBuffer)))
			{
				CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				ComputeBuffer value;
				LuaObject.checkType<ComputeBuffer>(l, 3, out value);
				commandBuffer.SetGlobalBuffer(nameID, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(ComputeBuffer)))
			{
				CommandBuffer commandBuffer2 = (CommandBuffer)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				ComputeBuffer value2;
				LuaObject.checkType<ComputeBuffer>(l, 3, out value2);
				commandBuffer2.SetGlobalBuffer(name, value2);
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

	// Token: 0x06023AB3 RID: 146099 RVA: 0x00C7AEBC File Offset: 0x00C790BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetShadowSamplingMode(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			RenderTargetIdentifier shadowmap;
			LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out shadowmap);
			ShadowSamplingMode mode;
			LuaObject.checkEnum<ShadowSamplingMode>(l, 3, out mode);
			commandBuffer.SetShadowSamplingMode(shadowmap, mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AB4 RID: 146100 RVA: 0x00C7AF20 File Offset: 0x00C79120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IssuePluginEvent(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			IntPtr callback;
			LuaObject.checkType(l, 2, out callback);
			int eventID;
			LuaObject.checkType(l, 3, out eventID);
			commandBuffer.IssuePluginEvent(callback, eventID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AB5 RID: 146101 RVA: 0x00C7AF84 File Offset: 0x00C79184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BeginSample(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			commandBuffer.BeginSample(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AB6 RID: 146102 RVA: 0x00C7AFDC File Offset: 0x00C791DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EndSample(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			commandBuffer.EndSample(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AB7 RID: 146103 RVA: 0x00C7B034 File Offset: 0x00C79234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IssuePluginEventAndData(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			IntPtr callback;
			LuaObject.checkType(l, 2, out callback);
			int eventID;
			LuaObject.checkType(l, 3, out eventID);
			IntPtr data;
			LuaObject.checkType(l, 4, out data);
			commandBuffer.IssuePluginEventAndData(callback, eventID, data);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AB8 RID: 146104 RVA: 0x00C7B0A8 File Offset: 0x00C792A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IssuePluginCustomBlit(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			IntPtr callback;
			LuaObject.checkType(l, 2, out callback);
			uint command;
			LuaObject.checkType(l, 3, out command);
			RenderTargetIdentifier source;
			LuaObject.checkValueType<RenderTargetIdentifier>(l, 4, out source);
			RenderTargetIdentifier dest;
			LuaObject.checkValueType<RenderTargetIdentifier>(l, 5, out dest);
			uint commandParam;
			LuaObject.checkType(l, 6, out commandParam);
			uint commandFlags;
			LuaObject.checkType(l, 7, out commandFlags);
			commandBuffer.IssuePluginCustomBlit(callback, command, source, dest, commandParam, commandFlags);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AB9 RID: 146105 RVA: 0x00C7B140 File Offset: 0x00C79340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IssuePluginCustomTextureUpdate(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			IntPtr callback;
			LuaObject.checkType(l, 2, out callback);
			Texture targetTexture;
			LuaObject.checkType<Texture>(l, 3, out targetTexture);
			uint userData;
			LuaObject.checkType(l, 4, out userData);
			commandBuffer.IssuePluginCustomTextureUpdate(callback, targetTexture, userData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ABA RID: 146106 RVA: 0x00C7B1B4 File Offset: 0x00C793B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_name(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commandBuffer.name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ABB RID: 146107 RVA: 0x00C7B208 File Offset: 0x00C79408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_name(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			commandBuffer.name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ABC RID: 146108 RVA: 0x00C7B260 File Offset: 0x00C79460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_sizeInBytes(IntPtr l)
	{
		int result;
		try
		{
			CommandBuffer commandBuffer = (CommandBuffer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commandBuffer.sizeInBytes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ABD RID: 146109 RVA: 0x00C7B2B4 File Offset: 0x00C794B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rendering.CommandBuffer");
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.Dispose);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache0);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.Release);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.CreateGPUFence);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.WaitOnGPUFence);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache3);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetComputeFloatParam);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache4);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetComputeIntParam);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache5);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetComputeVectorParam);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache6);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetComputeVectorArrayParam);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache7);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetComputeMatrixParam);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache8);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetComputeMatrixArrayParam);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache9);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetComputeFloatParams);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheA);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetComputeIntParams);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheB);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetComputeTextureParam);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheC);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetComputeBufferParam);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheD);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.DispatchCompute);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheE);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.GenerateMips);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cacheF);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.CopyCounterValue);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache10);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.Clear);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache11);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.DrawMesh);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache12);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.DrawRenderer);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache13);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.DrawProcedural);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache14);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.DrawProceduralIndirect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache15);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.DrawMeshInstanced);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache16);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.DrawMeshInstancedIndirect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache17);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetRenderTarget);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache18);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetRandomWriteTarget);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache19);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.ClearRandomWriteTargets);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1A);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.CopyTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1B);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetViewport);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1C);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.Blit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1D);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.GetTemporaryRT);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1E);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.GetTemporaryRTArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache1F);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.ReleaseTemporaryRT);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache20);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.ClearRenderTarget);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache21);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetGlobalFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache22);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetGlobalVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache23);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetGlobalColor);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache24);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetGlobalMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache25);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.EnableShaderKeyword);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache26);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.DisableShaderKeyword);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache27);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetViewMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache28);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetProjectionMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache29);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetViewProjectionMatrices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2A);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetGlobalDepthBias);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2B);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetGlobalFloatArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2C);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetGlobalVectorArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2D);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetGlobalMatrixArray);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2E);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetGlobalTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache2F);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetGlobalBuffer);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache30);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.SetShadowSamplingMode);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache31);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.IssuePluginEvent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache32);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.BeginSample);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache33);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.EndSample);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache34);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.IssuePluginEventAndData);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache35);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.IssuePluginCustomBlit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache36);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.IssuePluginCustomTextureUpdate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache37);
		string name = "name";
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.get_name);
		}
		LuaCSFunction get = Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache38;
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.set_name);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache39, true);
		string name2 = "sizeInBytes";
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.get_sizeInBytes);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache3A, null, true);
		if (Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_Rendering_CommandBuffer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Rendering_CommandBuffer.<>f__mg$cache3B, typeof(CommandBuffer));
	}

	// Token: 0x040197D9 RID: 104409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040197DA RID: 104410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040197DB RID: 104411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040197DC RID: 104412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040197DD RID: 104413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040197DE RID: 104414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040197DF RID: 104415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040197E0 RID: 104416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040197E1 RID: 104417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040197E2 RID: 104418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040197E3 RID: 104419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040197E4 RID: 104420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040197E5 RID: 104421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040197E6 RID: 104422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040197E7 RID: 104423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040197E8 RID: 104424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040197E9 RID: 104425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040197EA RID: 104426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040197EB RID: 104427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040197EC RID: 104428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040197ED RID: 104429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040197EE RID: 104430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040197EF RID: 104431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040197F0 RID: 104432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040197F1 RID: 104433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040197F2 RID: 104434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040197F3 RID: 104435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040197F4 RID: 104436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040197F5 RID: 104437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040197F6 RID: 104438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040197F7 RID: 104439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040197F8 RID: 104440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040197F9 RID: 104441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040197FA RID: 104442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040197FB RID: 104443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040197FC RID: 104444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040197FD RID: 104445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040197FE RID: 104446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040197FF RID: 104447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019800 RID: 104448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019801 RID: 104449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019802 RID: 104450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019803 RID: 104451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019804 RID: 104452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019805 RID: 104453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019806 RID: 104454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019807 RID: 104455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019808 RID: 104456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019809 RID: 104457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401980A RID: 104458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401980B RID: 104459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401980C RID: 104460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401980D RID: 104461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401980E RID: 104462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401980F RID: 104463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04019810 RID: 104464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019811 RID: 104465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04019812 RID: 104466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04019813 RID: 104467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04019814 RID: 104468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;
}
