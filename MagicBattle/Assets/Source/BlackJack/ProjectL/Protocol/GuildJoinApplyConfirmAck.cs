using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200075A RID: 1882
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinApplyConfirmAck")]
	[Serializable]
	public class GuildJoinApplyConfirmAck : IExtensible
	{
		// Token: 0x06006256 RID: 25174 RVA: 0x001BA638 File Offset: 0x001B8838
		public GuildJoinApplyConfirmAck()
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

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06006257 RID: 25175 RVA: 0x001BA6A0 File Offset: 0x001B88A0
		// (set) Token: 0x06006258 RID: 25176 RVA: 0x001BA6A8 File Offset: 0x001B88A8
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06006259 RID: 25177 RVA: 0x001BA6B4 File Offset: 0x001B88B4
		// (set) Token: 0x0600625A RID: 25178 RVA: 0x001BA6BC File Offset: 0x001B88BC
		[ProtoMember(2, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x0600625B RID: 25179 RVA: 0x001BA6C8 File Offset: 0x001B88C8
		// (set) Token: 0x0600625C RID: 25180 RVA: 0x001BA6D0 File Offset: 0x001B88D0
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "Member", DataFormat = DataFormat.Default)]
		public ProGuildMember Member
		{
			get
			{
				return this._Member;
			}
			set
			{
				this._Member = value;
			}
		}

		// Token: 0x0600625D RID: 25181 RVA: 0x001BA6DC File Offset: 0x001B88DC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600625E RID: 25182 RVA: 0x001BA6EC File Offset: 0x001B88EC
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

		// Token: 0x0600625F RID: 25183 RVA: 0x001BA7B8 File Offset: 0x001B89B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinApplyConfirmAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049A7 RID: 18855
		private int _Result;

		// Token: 0x040049A8 RID: 18856
		private string _UserId;

		// Token: 0x040049A9 RID: 18857
		private ProGuildMember _Member;

		// Token: 0x040049AA RID: 18858
		private IExtension extensionObject;

		// Token: 0x040049AB RID: 18859
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049AC RID: 18860
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049AD RID: 18861
		private LuaFunction m_ctor_hotfix;
	}
}
