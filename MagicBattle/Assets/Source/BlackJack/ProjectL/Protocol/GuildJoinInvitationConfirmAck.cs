using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000762 RID: 1890
	[ProtoContract(Name = "GuildJoinInvitationConfirmAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildJoinInvitationConfirmAck : IExtensible
	{
		// Token: 0x06006289 RID: 25225 RVA: 0x001BB460 File Offset: 0x001B9660
		public GuildJoinInvitationConfirmAck()
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

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x0600628A RID: 25226 RVA: 0x001BB4C8 File Offset: 0x001B96C8
		// (set) Token: 0x0600628B RID: 25227 RVA: 0x001BB4D0 File Offset: 0x001B96D0
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

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x0600628C RID: 25228 RVA: 0x001BB4DC File Offset: 0x001B96DC
		// (set) Token: 0x0600628D RID: 25229 RVA: 0x001BB4E4 File Offset: 0x001B96E4
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

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x0600628E RID: 25230 RVA: 0x001BB4F0 File Offset: 0x001B96F0
		// (set) Token: 0x0600628F RID: 25231 RVA: 0x001BB4F8 File Offset: 0x001B96F8
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "Guild", DataFormat = DataFormat.Default)]
		public ProGuild Guild
		{
			get
			{
				return this._Guild;
			}
			set
			{
				this._Guild = value;
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06006290 RID: 25232 RVA: 0x001BB504 File Offset: 0x001B9704
		// (set) Token: 0x06006291 RID: 25233 RVA: 0x001BB50C File Offset: 0x001B970C
		[DefaultValue(0L)]
		[ProtoMember(4, IsRequired = false, Name = "LastUpdateTime", DataFormat = DataFormat.TwosComplement)]
		public long LastUpdateTime
		{
			get
			{
				return this._LastUpdateTime;
			}
			set
			{
				this._LastUpdateTime = value;
			}
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x001BB518 File Offset: 0x001B9718
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x001BB528 File Offset: 0x001B9728
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

		// Token: 0x06006294 RID: 25236 RVA: 0x001BB5F4 File Offset: 0x001B97F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinInvitationConfirmAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049D1 RID: 18897
		private int _Result;

		// Token: 0x040049D2 RID: 18898
		private string _GuildId;

		// Token: 0x040049D3 RID: 18899
		private ProGuild _Guild;

		// Token: 0x040049D4 RID: 18900
		private long _LastUpdateTime;

		// Token: 0x040049D5 RID: 18901
		private IExtension extensionObject;

		// Token: 0x040049D6 RID: 18902
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049D7 RID: 18903
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049D8 RID: 18904
		private LuaFunction m_ctor_hotfix;
	}
}
