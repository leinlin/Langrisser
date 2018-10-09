using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000685 RID: 1669
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBattleRoomPlayer")]
	[Serializable]
	public class ProBattleRoomPlayer : IExtensible
	{
		// Token: 0x06005AEA RID: 23274 RVA: 0x001A1528 File Offset: 0x0019F728
		public ProBattleRoomPlayer()
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

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06005AEB RID: 23275 RVA: 0x001A159C File Offset: 0x0019F79C
		// (set) Token: 0x06005AEC RID: 23276 RVA: 0x001A15A4 File Offset: 0x0019F7A4
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

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06005AED RID: 23277 RVA: 0x001A15B0 File Offset: 0x0019F7B0
		// (set) Token: 0x06005AEE RID: 23278 RVA: 0x001A15B8 File Offset: 0x0019F7B8
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

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06005AEF RID: 23279 RVA: 0x001A15C4 File Offset: 0x0019F7C4
		// (set) Token: 0x06005AF0 RID: 23280 RVA: 0x001A15CC File Offset: 0x0019F7CC
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

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06005AF1 RID: 23281 RVA: 0x001A15D8 File Offset: 0x0019F7D8
		// (set) Token: 0x06005AF2 RID: 23282 RVA: 0x001A15E0 File Offset: 0x0019F7E0
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

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06005AF3 RID: 23283 RVA: 0x001A15EC File Offset: 0x0019F7EC
		// (set) Token: 0x06005AF4 RID: 23284 RVA: 0x001A15F4 File Offset: 0x0019F7F4
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

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06005AF5 RID: 23285 RVA: 0x001A1600 File Offset: 0x0019F800
		// (set) Token: 0x06005AF6 RID: 23286 RVA: 0x001A1608 File Offset: 0x0019F808
		[ProtoMember(7, IsRequired = true, Name = "PlayerBattleStatus", DataFormat = DataFormat.TwosComplement)]
		public int PlayerBattleStatus
		{
			get
			{
				return this._PlayerBattleStatus;
			}
			set
			{
				this._PlayerBattleStatus = value;
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06005AF7 RID: 23287 RVA: 0x001A1614 File Offset: 0x0019F814
		// (set) Token: 0x06005AF8 RID: 23288 RVA: 0x001A161C File Offset: 0x0019F81C
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

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06005AF9 RID: 23289 RVA: 0x001A1628 File Offset: 0x0019F828
		// (set) Token: 0x06005AFA RID: 23290 RVA: 0x001A1630 File Offset: 0x0019F830
		[ProtoMember(9, IsRequired = true, Name = "Offline", DataFormat = DataFormat.Default)]
		public bool Offline
		{
			get
			{
				return this._Offline;
			}
			set
			{
				this._Offline = value;
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06005AFB RID: 23291 RVA: 0x001A163C File Offset: 0x0019F83C
		[ProtoMember(10, Name = "Techs", DataFormat = DataFormat.Default)]
		public List<ProTrainingTech> Techs
		{
			get
			{
				return this._Techs;
			}
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06005AFC RID: 23292 RVA: 0x001A1644 File Offset: 0x0019F844
		// (set) Token: 0x06005AFD RID: 23293 RVA: 0x001A164C File Offset: 0x0019F84C
		[DefaultValue(null)]
		[ProtoMember(11, IsRequired = false, Name = "RealTimePVPInfo", DataFormat = DataFormat.Default)]
		public ProRealTimePVPUserInfo RealTimePVPInfo
		{
			get
			{
				return this._RealTimePVPInfo;
			}
			set
			{
				this._RealTimePVPInfo = value;
			}
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x001A1658 File Offset: 0x0019F858
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x001A1668 File Offset: 0x0019F868
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

		// Token: 0x06005B00 RID: 23296 RVA: 0x001A1734 File Offset: 0x0019F934
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBattleRoomPlayer));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004412 RID: 17426
		private string _UserId;

		// Token: 0x04004413 RID: 17427
		private int _ChannelId;

		// Token: 0x04004414 RID: 17428
		private string _Name;

		// Token: 0x04004415 RID: 17429
		private int _HeadIcon;

		// Token: 0x04004416 RID: 17430
		private int _Level;

		// Token: 0x04004417 RID: 17431
		private int _PlayerBattleStatus;

		// Token: 0x04004418 RID: 17432
		private ulong _SessionId;

		// Token: 0x04004419 RID: 17433
		private bool _Offline;

		// Token: 0x0400441A RID: 17434
		private readonly List<ProTrainingTech> _Techs = new List<ProTrainingTech>();

		// Token: 0x0400441B RID: 17435
		private ProRealTimePVPUserInfo _RealTimePVPInfo;

		// Token: 0x0400441C RID: 17436
		private IExtension extensionObject;

		// Token: 0x0400441D RID: 17437
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400441E RID: 17438
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400441F RID: 17439
		private LuaFunction m_ctor_hotfix;
	}
}
