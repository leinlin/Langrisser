using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000758 RID: 1880
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinInviteAck")]
	[Serializable]
	public class GuildJoinInviteAck : IExtensible
	{
		// Token: 0x06006248 RID: 25160 RVA: 0x001BA2A4 File Offset: 0x001B84A4
		public GuildJoinInviteAck()
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

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06006249 RID: 25161 RVA: 0x001BA30C File Offset: 0x001B850C
		// (set) Token: 0x0600624A RID: 25162 RVA: 0x001BA314 File Offset: 0x001B8514
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

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x0600624B RID: 25163 RVA: 0x001BA320 File Offset: 0x001B8520
		// (set) Token: 0x0600624C RID: 25164 RVA: 0x001BA328 File Offset: 0x001B8528
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

		// Token: 0x0600624D RID: 25165 RVA: 0x001BA334 File Offset: 0x001B8534
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x001BA344 File Offset: 0x001B8544
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

		// Token: 0x0600624F RID: 25167 RVA: 0x001BA410 File Offset: 0x001B8610
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinInviteAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400499C RID: 18844
		private int _Result;

		// Token: 0x0400499D RID: 18845
		private string _UserId;

		// Token: 0x0400499E RID: 18846
		private IExtension extensionObject;

		// Token: 0x0400499F RID: 18847
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049A0 RID: 18848
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049A1 RID: 18849
		private LuaFunction m_ctor_hotfix;
	}
}
