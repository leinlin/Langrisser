using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000764 RID: 1892
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinInvitationRefuseAck")]
	[Serializable]
	public class GuildJoinInvitationRefuseAck : IExtensible
	{
		// Token: 0x0600629B RID: 25243 RVA: 0x001BB81C File Offset: 0x001B9A1C
		public GuildJoinInvitationRefuseAck()
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

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x0600629C RID: 25244 RVA: 0x001BB884 File Offset: 0x001B9A84
		// (set) Token: 0x0600629D RID: 25245 RVA: 0x001BB88C File Offset: 0x001B9A8C
		[DefaultValue(0)]
		[ProtoMember(1, IsRequired = false, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x0600629E RID: 25246 RVA: 0x001BB898 File Offset: 0x001B9A98
		// (set) Token: 0x0600629F RID: 25247 RVA: 0x001BB8A0 File Offset: 0x001B9AA0
		[ProtoMember(2, IsRequired = true, Name = "GuildId", DataFormat = DataFormat.Default)]
		public string GuildId
		{
			get
			{
				return this._GuildId;
			}
			set
			{
				this._GuildId = value;
			}
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x001BB8AC File Offset: 0x001B9AAC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062A1 RID: 25249 RVA: 0x001BB8BC File Offset: 0x001B9ABC
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

		// Token: 0x060062A2 RID: 25250 RVA: 0x001BB988 File Offset: 0x001B9B88
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinInvitationRefuseAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049DE RID: 18910
		private int _Result;

		// Token: 0x040049DF RID: 18911
		private string _GuildId;

		// Token: 0x040049E0 RID: 18912
		private IExtension extensionObject;

		// Token: 0x040049E1 RID: 18913
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049E2 RID: 18914
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049E3 RID: 18915
		private LuaFunction m_ctor_hotfix;
	}
}
