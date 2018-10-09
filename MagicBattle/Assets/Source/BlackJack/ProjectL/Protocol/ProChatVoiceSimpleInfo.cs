using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200062C RID: 1580
	[ProtoContract(Name = "ProChatVoiceSimpleInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProChatVoiceSimpleInfo : IExtensible
	{
		// Token: 0x060056B7 RID: 22199 RVA: 0x001961D8 File Offset: 0x001943D8
		public ProChatVoiceSimpleInfo()
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

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x060056B8 RID: 22200 RVA: 0x00196240 File Offset: 0x00194440
		// (set) Token: 0x060056B9 RID: 22201 RVA: 0x00196248 File Offset: 0x00194448
		[ProtoMember(1, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x060056BA RID: 22202 RVA: 0x00196254 File Offset: 0x00194454
		// (set) Token: 0x060056BB RID: 22203 RVA: 0x0019625C File Offset: 0x0019445C
		[ProtoMember(2, IsRequired = true, Name = "VoiceLength", DataFormat = DataFormat.TwosComplement)]
		public int VoiceLength
		{
			get
			{
				return this._VoiceLength;
			}
			set
			{
				this._VoiceLength = value;
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x060056BC RID: 22204 RVA: 0x00196268 File Offset: 0x00194468
		// (set) Token: 0x060056BD RID: 22205 RVA: 0x00196270 File Offset: 0x00194470
		[ProtoMember(3, IsRequired = true, Name = "TranslateText", DataFormat = DataFormat.Default)]
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

		// Token: 0x060056BE RID: 22206 RVA: 0x0019627C File Offset: 0x0019447C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x0019628C File Offset: 0x0019448C
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

		// Token: 0x060056C0 RID: 22208 RVA: 0x00196358 File Offset: 0x00194558
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProChatVoiceSimpleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004129 RID: 16681
		private ulong _InstanceId;

		// Token: 0x0400412A RID: 16682
		private int _VoiceLength;

		// Token: 0x0400412B RID: 16683
		private string _TranslateText;

		// Token: 0x0400412C RID: 16684
		private IExtension extensionObject;

		// Token: 0x0400412D RID: 16685
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400412E RID: 16686
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400412F RID: 16687
		private LuaFunction m_ctor_hotfix;
	}
}
