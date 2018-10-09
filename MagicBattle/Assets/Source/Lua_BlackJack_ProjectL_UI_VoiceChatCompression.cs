using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using NSpeex;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015D9 RID: 5593
[Preserve]
public class Lua_BlackJack_ProjectL_UI_VoiceChatCompression : LuaObject
{
	// Token: 0x06022255 RID: 139861 RVA: 0x00BA7F78 File Offset: 0x00BA6178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Compress(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression voiceChatCompression = (VoiceChatCompression)LuaObject.checkSelf(l);
			float[] sample;
			LuaObject.checkArray<float>(l, 2, out sample);
			VoiceChatCompressionType type;
			LuaObject.checkEnum<VoiceChatCompressionType>(l, 3, out type);
			byte[] a = voiceChatCompression.Compress(sample, type);
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

	// Token: 0x06022256 RID: 139862 RVA: 0x00BA7FE8 File Offset: 0x00BA61E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Decompress(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression voiceChatCompression = (VoiceChatCompression)LuaObject.checkSelf(l);
			byte[] bytes;
			LuaObject.checkArray<byte>(l, 2, out bytes);
			int sampleLength;
			LuaObject.checkType(l, 3, out sampleLength);
			VoiceChatCompressionType type;
			LuaObject.checkEnum<VoiceChatCompressionType>(l, 4, out type);
			float[] a = voiceChatCompression.Decompress(bytes, sampleLength, type);
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

	// Token: 0x06022257 RID: 139863 RVA: 0x00BA8064 File Offset: 0x00BA6264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SpeexDecompress(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression voiceChatCompression = (VoiceChatCompression)LuaObject.checkSelf(l);
			byte[] data;
			LuaObject.checkArray<byte>(l, 2, out data);
			int dataLength;
			LuaObject.checkType(l, 3, out dataLength);
			int sampleLength;
			LuaObject.checkType(l, 4, out sampleLength);
			float[] a = voiceChatCompression.SpeexDecompress(data, dataLength, sampleLength);
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

	// Token: 0x06022258 RID: 139864 RVA: 0x00BA80E0 File Offset: 0x00BA62E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SpeexCompress(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression voiceChatCompression = (VoiceChatCompression)LuaObject.checkSelf(l);
			float[] input;
			LuaObject.checkArray<float>(l, 2, out input);
			byte[] a = voiceChatCompression.SpeexCompress(input);
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

	// Token: 0x06022259 RID: 139865 RVA: 0x00BA8144 File Offset: 0x00BA6344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FloatToShortArray(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression voiceChatCompression = (VoiceChatCompression)LuaObject.checkSelf(l);
			float[] input;
			LuaObject.checkArray<float>(l, 2, out input);
			short[] output;
			LuaObject.checkArray<short>(l, 3, out output);
			voiceChatCompression.m_luaExportHelper.FloatToShortArray(input, output);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602225A RID: 139866 RVA: 0x00BA81B0 File Offset: 0x00BA63B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShortToFloatArray(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression voiceChatCompression = (VoiceChatCompression)LuaObject.checkSelf(l);
			short[] input;
			LuaObject.checkArray<short>(l, 2, out input);
			float[] output;
			LuaObject.checkArray<float>(l, 3, out output);
			int length;
			LuaObject.checkType(l, 4, out length);
			voiceChatCompression.m_luaExportHelper.ShortToFloatArray(input, output, length);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602225B RID: 139867 RVA: 0x00BA8228 File Offset: 0x00BA6428
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, VoiceChatCompression.LuaExportHelper.m_instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602225C RID: 139868 RVA: 0x00BA8270 File Offset: 0x00BA6470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_instance(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression instance;
			LuaObject.checkType<VoiceChatCompression>(l, 2, out instance);
			VoiceChatCompression.LuaExportHelper.m_instance = instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602225D RID: 139869 RVA: 0x00BA82BC File Offset: 0x00BA64BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__speexEnc(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression voiceChatCompression = (VoiceChatCompression)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceChatCompression.m_luaExportHelper._speexEnc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602225E RID: 139870 RVA: 0x00BA8314 File Offset: 0x00BA6514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__speexEnc(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression voiceChatCompression = (VoiceChatCompression)LuaObject.checkSelf(l);
			SpeexEncoder speexEnc;
			LuaObject.checkType<SpeexEncoder>(l, 2, out speexEnc);
			voiceChatCompression.m_luaExportHelper._speexEnc = speexEnc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602225F RID: 139871 RVA: 0x00BA8370 File Offset: 0x00BA6570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__speexDec(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression voiceChatCompression = (VoiceChatCompression)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceChatCompression.m_luaExportHelper._speexDec);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022260 RID: 139872 RVA: 0x00BA83C8 File Offset: 0x00BA65C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__speexDec(IntPtr l)
	{
		int result;
		try
		{
			VoiceChatCompression voiceChatCompression = (VoiceChatCompression)LuaObject.checkSelf(l);
			SpeexDecoder speexDec;
			LuaObject.checkType<SpeexDecoder>(l, 2, out speexDec);
			voiceChatCompression.m_luaExportHelper._speexDec = speexDec;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022261 RID: 139873 RVA: 0x00BA8424 File Offset: 0x00BA6624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, VoiceChatCompression.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022262 RID: 139874 RVA: 0x00BA846C File Offset: 0x00BA666C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.VoiceChatCompression");
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.Compress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.Decompress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.SpeexDecompress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.SpeexCompress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.FloatToShortArray);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.ShortToFloatArray);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache5);
		string name = "m_instance";
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.get_m_instance);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.set_m_instance);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache7, false);
		string name2 = "_speexEnc";
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.get__speexEnc);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.set__speexEnc);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cache9, true);
		string name3 = "_speexDec";
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.get__speexDec);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.set__speexDec);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cacheB, true);
		string name4 = "Instance";
		if (Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.get_Instance);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_VoiceChatCompression.<>f__mg$cacheC, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(VoiceChatCompression));
	}

	// Token: 0x04018085 RID: 98437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018086 RID: 98438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018087 RID: 98439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018088 RID: 98440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018089 RID: 98441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401808A RID: 98442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401808B RID: 98443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401808C RID: 98444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401808D RID: 98445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401808E RID: 98446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401808F RID: 98447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018090 RID: 98448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018091 RID: 98449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
