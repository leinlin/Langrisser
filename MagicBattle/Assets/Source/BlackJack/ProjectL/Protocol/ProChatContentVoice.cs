using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200062D RID: 1581
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProChatContentVoice")]
	[Serializable]
	public class ProChatContentVoice : IExtensible
	{
		// Token: 0x060056C1 RID: 22209 RVA: 0x001963C0 File Offset: 0x001945C0
		public ProChatContentVoice()
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

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x060056C2 RID: 22210 RVA: 0x00196434 File Offset: 0x00194634
		// (set) Token: 0x060056C3 RID: 22211 RVA: 0x0019643C File Offset: 0x0019463C
		[ProtoMember(1, IsRequired = false, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0f)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x060056C4 RID: 22212 RVA: 0x00196448 File Offset: 0x00194648
		// (set) Token: 0x060056C5 RID: 22213 RVA: 0x00196450 File Offset: 0x00194650
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "Voice", DataFormat = DataFormat.Default)]
		public byte[] Voice
		{
			get
			{
				return this._Voice;
			}
			set
			{
				this._Voice = value;
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x060056C6 RID: 22214 RVA: 0x0019645C File Offset: 0x0019465C
		// (set) Token: 0x060056C7 RID: 22215 RVA: 0x00196464 File Offset: 0x00194664
		[DefaultValue(0)]
		[ProtoMember(3, IsRequired = false, Name = "VoiceLenth", DataFormat = DataFormat.TwosComplement)]
		public int VoiceLenth
		{
			get
			{
				return this._VoiceLenth;
			}
			set
			{
				this._VoiceLenth = value;
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x060056C8 RID: 22216 RVA: 0x00196470 File Offset: 0x00194670
		// (set) Token: 0x060056C9 RID: 22217 RVA: 0x00196478 File Offset: 0x00194678
		[DefaultValue(0)]
		[ProtoMember(4, IsRequired = false, Name = "AudioFrequency", DataFormat = DataFormat.TwosComplement)]
		public int AudioFrequency
		{
			get
			{
				return this._AudioFrequency;
			}
			set
			{
				this._AudioFrequency = value;
			}
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x060056CA RID: 22218 RVA: 0x00196484 File Offset: 0x00194684
		// (set) Token: 0x060056CB RID: 22219 RVA: 0x0019648C File Offset: 0x0019468C
		[ProtoMember(5, IsRequired = false, Name = "AudioSampleLength", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int AudioSampleLength
		{
			get
			{
				return this._AudioSampleLength;
			}
			set
			{
				this._AudioSampleLength = value;
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x060056CC RID: 22220 RVA: 0x00196498 File Offset: 0x00194698
		// (set) Token: 0x060056CD RID: 22221 RVA: 0x001964A0 File Offset: 0x001946A0
		[ProtoMember(6, IsRequired = false, Name = "TranslateText", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
		public string TranslateText
		{
			get
			{
				return this._TranslateText;
			}
			set
			{
				this._TranslateText = value;
			}
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x001964AC File Offset: 0x001946AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x001964BC File Offset: 0x001946BC
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x00196588 File Offset: 0x00194788
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProChatContentVoice));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004130 RID: 16688
		private ulong _InstanceId;

		// Token: 0x04004131 RID: 16689
		private byte[] _Voice;

		// Token: 0x04004132 RID: 16690
		private int _VoiceLenth;

		// Token: 0x04004133 RID: 16691
		private int _AudioFrequency;

		// Token: 0x04004134 RID: 16692
		private int _AudioSampleLength;

		// Token: 0x04004135 RID: 16693
		private string _TranslateText = string.Empty;

		// Token: 0x04004136 RID: 16694
		private IExtension extensionObject;

		// Token: 0x04004137 RID: 16695
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004138 RID: 16696
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004139 RID: 16697
		private LuaFunction m_ctor_hotfix;
	}
}
