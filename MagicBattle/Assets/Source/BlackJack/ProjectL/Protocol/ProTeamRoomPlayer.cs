using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000676 RID: 1654
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProTeamRoomPlayer")]
	[Serializable]
	public class ProTeamRoomPlayer : IExtensible
	{
		// Token: 0x06005A18 RID: 23064 RVA: 0x0019F5EC File Offset: 0x0019D7EC
		public ProTeamRoomPlayer()
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

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06005A19 RID: 23065 RVA: 0x0019F654 File Offset: 0x0019D854
		// (set) Token: 0x06005A1A RID: 23066 RVA: 0x0019F65C File Offset: 0x0019D85C
		[ProtoMember(1, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06005A1B RID: 23067 RVA: 0x0019F668 File Offset: 0x0019D868
		// (set) Token: 0x06005A1C RID: 23068 RVA: 0x0019F670 File Offset: 0x0019D870
		[ProtoMember(2, IsRequired = true, Name = "ChannelId", DataFormat = DataFormat.TwosComplement)]
		public int ChannelId
		{
			get
			{
				return this._ChannelId;
			}
			set
			{
				this._ChannelId = value;
			}
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06005A1D RID: 23069 RVA: 0x0019F67C File Offset: 0x0019D87C
		// (set) Token: 0x06005A1E RID: 23070 RVA: 0x0019F684 File Offset: 0x0019D884
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06005A1F RID: 23071 RVA: 0x0019F690 File Offset: 0x0019D890
		// (set) Token: 0x06005A20 RID: 23072 RVA: 0x0019F698 File Offset: 0x0019D898
		[ProtoMember(4, IsRequired = true, Name = "HeadIcon", DataFormat = DataFormat.TwosComplement)]
		public int HeadIcon
		{
			get
			{
				return this._HeadIcon;
			}
			set
			{
				this._HeadIcon = value;
			}
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06005A21 RID: 23073 RVA: 0x0019F6A4 File Offset: 0x0019D8A4
		// (set) Token: 0x06005A22 RID: 23074 RVA: 0x0019F6AC File Offset: 0x0019D8AC
		[ProtoMember(5, IsRequired = true, Name = "ActiveHeroJobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int ActiveHeroJobRelatedId
		{
			get
			{
				return this._ActiveHeroJobRelatedId;
			}
			set
			{
				this._ActiveHeroJobRelatedId = value;
			}
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06005A23 RID: 23075 RVA: 0x0019F6B8 File Offset: 0x0019D8B8
		// (set) Token: 0x06005A24 RID: 23076 RVA: 0x0019F6C0 File Offset: 0x0019D8C0
		[ProtoMember(6, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06005A25 RID: 23077 RVA: 0x0019F6CC File Offset: 0x0019D8CC
		// (set) Token: 0x06005A26 RID: 23078 RVA: 0x0019F6D4 File Offset: 0x0019D8D4
		[ProtoMember(7, IsRequired = true, Name = "Position", DataFormat = DataFormat.TwosComplement)]
		public int Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				this._Position = value;
			}
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06005A27 RID: 23079 RVA: 0x0019F6E0 File Offset: 0x0019D8E0
		// (set) Token: 0x06005A28 RID: 23080 RVA: 0x0019F6E8 File Offset: 0x0019D8E8
		[ProtoMember(8, IsRequired = true, Name = "SessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				this._SessionId = value;
			}
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06005A29 RID: 23081 RVA: 0x0019F6F4 File Offset: 0x0019D8F4
		// (set) Token: 0x06005A2A RID: 23082 RVA: 0x0019F6FC File Offset: 0x0019D8FC
		[ProtoMember(9, IsRequired = true, Name = "ModenSkinId", DataFormat = DataFormat.TwosComplement)]
		public int ModenSkinId
		{
			get
			{
				return this._ModenSkinId;
			}
			set
			{
				this._ModenSkinId = value;
			}
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x0019F708 File Offset: 0x0019D908
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x0019F718 File Offset: 0x0019D918
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

		// Token: 0x06005A2D RID: 23085 RVA: 0x0019F7E4 File Offset: 0x0019D9E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProTeamRoomPlayer));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004387 RID: 17287
		private string _UserId;

		// Token: 0x04004388 RID: 17288
		private int _ChannelId;

		// Token: 0x04004389 RID: 17289
		private string _Name;

		// Token: 0x0400438A RID: 17290
		private int _HeadIcon;

		// Token: 0x0400438B RID: 17291
		private int _ActiveHeroJobRelatedId;

		// Token: 0x0400438C RID: 17292
		private int _Level;

		// Token: 0x0400438D RID: 17293
		private int _Position;

		// Token: 0x0400438E RID: 17294
		private ulong _SessionId;

		// Token: 0x0400438F RID: 17295
		private int _ModenSkinId;

		// Token: 0x04004390 RID: 17296
		private IExtension extensionObject;

		// Token: 0x04004391 RID: 17297
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004392 RID: 17298
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004393 RID: 17299
		private LuaFunction m_ctor_hotfix;
	}
}
