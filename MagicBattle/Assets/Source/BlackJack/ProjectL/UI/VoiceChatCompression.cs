using System;
using BlackJack.BJFramework.Runtime.Lua;
using NSpeex;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B66 RID: 2918
	[HotFix]
	public class VoiceChatCompression
	{
		// Token: 0x0600C6CD RID: 50893 RVA: 0x00370E5C File Offset: 0x0036F05C
		private VoiceChatCompression()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600C6CE RID: 50894 RVA: 0x00370EDC File Offset: 0x0036F0DC
		public byte[] Compress(float[] sample, VoiceChatCompressionType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CompressSinglebeVoiceChatCompressionType_hotfix != null)
			{
				return (byte[])this.m_CompressSinglebeVoiceChatCompressionType_hotfix.call(new object[]
				{
					this,
					sample,
					type
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			byte[] result = null;
			if (type == VoiceChatCompressionType.Speex)
			{
				result = this.SpeexCompress(sample);
			}
			return result;
		}

		// Token: 0x0600C6CF RID: 50895 RVA: 0x00370F88 File Offset: 0x0036F188
		public float[] Decompress(byte[] bytes, int sampleLength, VoiceChatCompressionType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DecompressBytebeInt32VoiceChatCompressionType_hotfix != null)
			{
				return (float[])this.m_DecompressBytebeInt32VoiceChatCompressionType_hotfix.call(new object[]
				{
					this,
					bytes,
					sampleLength,
					type
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float[] result = null;
			if (type == VoiceChatCompressionType.Speex)
			{
				result = this.SpeexDecompress(bytes, bytes.Length, sampleLength);
			}
			return result;
		}

		// Token: 0x0600C6D0 RID: 50896 RVA: 0x00371048 File Offset: 0x0036F248
		private void FloatToShortArray(float[] input, short[] output)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FloatToShortArraySinglebeInt16be_hotfix != null)
			{
				this.m_FloatToShortArraySinglebeInt16be_hotfix.call(new object[]
				{
					this,
					input,
					output
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (output.Length < input.Length)
			{
				throw new ArgumentException(string.Concat(new object[]
				{
					"in: ",
					input.Length,
					", out: ",
					output.Length
				}));
			}
			for (int i = 0; i < input.Length; i++)
			{
				output[i] = (short)Mathf.Clamp((int)(input[i] * 32767f), -32768, 32767);
			}
		}

		// Token: 0x0600C6D1 RID: 50897 RVA: 0x0037113C File Offset: 0x0036F33C
		private void ShortToFloatArray(short[] input, float[] output, int length)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShortToFloatArrayInt16beSinglebeInt32_hotfix != null)
			{
				this.m_ShortToFloatArrayInt16beSinglebeInt32_hotfix.call(new object[]
				{
					this,
					input,
					output,
					length
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (output.Length < length || input.Length < length)
			{
				throw new ArgumentException();
			}
			for (int i = 0; i < length; i++)
			{
				output[i] = (float)input[i] / 32767f;
			}
		}

		// Token: 0x0600C6D2 RID: 50898 RVA: 0x00371204 File Offset: 0x0036F404
		public float[] SpeexDecompress(byte[] data, int dataLength, int sampleLength)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SpeexDecompressBytebeInt32Int32_hotfix != null)
			{
				return (float[])this.m_SpeexDecompressBytebeInt32Int32_hotfix.call(new object[]
				{
					this,
					data,
					dataLength,
					sampleLength
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = sampleLength;
			int num2 = sampleLength % this._speexDec.FrameSize;
			if (num2 != 0)
			{
				num = sampleLength + this._speexDec.FrameSize - num2;
			}
			short[] array = new short[num];
			this._speexDec.Decode(data, 0, dataLength, array, 0, false);
			float[] array2 = new float[num];
			this.ShortToFloatArray(array, array2, sampleLength);
			return array2;
		}

		// Token: 0x0600C6D3 RID: 50899 RVA: 0x003712F0 File Offset: 0x0036F4F0
		public byte[] SpeexCompress(float[] input)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SpeexCompressSinglebe_hotfix != null)
			{
				return (byte[])this.m_SpeexCompressSinglebe_hotfix.call(new object[]
				{
					this,
					input
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			short[] array = new short[input.Length];
			this.FloatToShortArray(input, array);
			int num = input.Length;
			int num2 = array.Length % this._speexEnc.FrameSize;
			if (num2 != 0)
			{
				num = array.Length + this._speexEnc.FrameSize - num2;
			}
			short[] array2 = new short[num];
			Array.Copy(array, 0, array2, 0, array.Length);
			byte[] array3 = new byte[num * 2];
			int num3 = this._speexEnc.Encode(array2, 0, num, array3, 0, array3.Length);
			byte[] array4 = new byte[num3];
			Array.Copy(array3, array4, num3);
			return array4;
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x0600C6D4 RID: 50900 RVA: 0x003713F4 File Offset: 0x0036F5F4
		public static VoiceChatCompression Instance
		{
			get
			{
				if (VoiceChatCompression.m_instance == null)
				{
					VoiceChatCompression.m_instance = new VoiceChatCompression();
				}
				return VoiceChatCompression.m_instance;
			}
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x0600C6D5 RID: 50901 RVA: 0x00371410 File Offset: 0x0036F610
		// (set) Token: 0x0600C6D6 RID: 50902 RVA: 0x00371430 File Offset: 0x0036F630
		[DoNotToLua]
		public VoiceChatCompression.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new VoiceChatCompression.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C6D7 RID: 50903 RVA: 0x0037143C File Offset: 0x0036F63C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_CompressSinglebeVoiceChatCompressionType_hotfix = (luaObj.RawGet("Compress") as LuaFunction);
					this.m_DecompressBytebeInt32VoiceChatCompressionType_hotfix = (luaObj.RawGet("Decompress") as LuaFunction);
					this.m_FloatToShortArraySinglebeInt16be_hotfix = (luaObj.RawGet("FloatToShortArray") as LuaFunction);
					this.m_ShortToFloatArrayInt16beSinglebeInt32_hotfix = (luaObj.RawGet("ShortToFloatArray") as LuaFunction);
					this.m_SpeexDecompressBytebeInt32Int32_hotfix = (luaObj.RawGet("SpeexDecompress") as LuaFunction);
					this.m_SpeexCompressSinglebe_hotfix = (luaObj.RawGet("SpeexCompress") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C6D8 RID: 50904 RVA: 0x003715A0 File Offset: 0x0036F7A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(VoiceChatCompression));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007DCB RID: 32203
		private static VoiceChatCompression m_instance;

		// Token: 0x04007DCC RID: 32204
		private SpeexEncoder _speexEnc = new SpeexEncoder(BandMode.UltraWide);

		// Token: 0x04007DCD RID: 32205
		private SpeexDecoder _speexDec = new SpeexDecoder(BandMode.UltraWide, true);

		// Token: 0x04007DCE RID: 32206
		[DoNotToLua]
		private VoiceChatCompression.LuaExportHelper luaExportHelper;

		// Token: 0x04007DCF RID: 32207
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007DD0 RID: 32208
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007DD1 RID: 32209
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04007DD2 RID: 32210
		private LuaFunction m_CompressSinglebeVoiceChatCompressionType_hotfix;

		// Token: 0x04007DD3 RID: 32211
		private LuaFunction m_DecompressBytebeInt32VoiceChatCompressionType_hotfix;

		// Token: 0x04007DD4 RID: 32212
		private LuaFunction m_FloatToShortArraySinglebeInt16be_hotfix;

		// Token: 0x04007DD5 RID: 32213
		private LuaFunction m_ShortToFloatArrayInt16beSinglebeInt32_hotfix;

		// Token: 0x04007DD6 RID: 32214
		private LuaFunction m_SpeexDecompressBytebeInt32Int32_hotfix;

		// Token: 0x04007DD7 RID: 32215
		private LuaFunction m_SpeexCompressSinglebe_hotfix;

		// Token: 0x02000B67 RID: 2919
		public class LuaExportHelper
		{
			// Token: 0x0600C6D9 RID: 50905 RVA: 0x00371608 File Offset: 0x0036F808
			public LuaExportHelper(VoiceChatCompression owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17002794 RID: 10132
			// (get) Token: 0x0600C6DA RID: 50906 RVA: 0x00371618 File Offset: 0x0036F818
			// (set) Token: 0x0600C6DB RID: 50907 RVA: 0x00371620 File Offset: 0x0036F820
			public static VoiceChatCompression m_instance
			{
				get
				{
					return VoiceChatCompression.m_instance;
				}
				set
				{
					VoiceChatCompression.m_instance = value;
				}
			}

			// Token: 0x17002795 RID: 10133
			// (get) Token: 0x0600C6DC RID: 50908 RVA: 0x00371628 File Offset: 0x0036F828
			// (set) Token: 0x0600C6DD RID: 50909 RVA: 0x00371638 File Offset: 0x0036F838
			public SpeexEncoder _speexEnc
			{
				get
				{
					return this.m_owner._speexEnc;
				}
				set
				{
					this.m_owner._speexEnc = value;
				}
			}

			// Token: 0x17002796 RID: 10134
			// (get) Token: 0x0600C6DE RID: 50910 RVA: 0x00371648 File Offset: 0x0036F848
			// (set) Token: 0x0600C6DF RID: 50911 RVA: 0x00371658 File Offset: 0x0036F858
			public SpeexDecoder _speexDec
			{
				get
				{
					return this.m_owner._speexDec;
				}
				set
				{
					this.m_owner._speexDec = value;
				}
			}

			// Token: 0x0600C6E0 RID: 50912 RVA: 0x00371668 File Offset: 0x0036F868
			public void FloatToShortArray(float[] input, short[] output)
			{
				this.m_owner.FloatToShortArray(input, output);
			}

			// Token: 0x0600C6E1 RID: 50913 RVA: 0x00371678 File Offset: 0x0036F878
			public void ShortToFloatArray(short[] input, float[] output, int length)
			{
				this.m_owner.ShortToFloatArray(input, output, length);
			}

			// Token: 0x04007DD8 RID: 32216
			private VoiceChatCompression m_owner;
		}
	}
}
