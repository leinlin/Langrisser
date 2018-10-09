using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200069A RID: 1690
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProRealTimePVPBattleReportPlayerData")]
	[Serializable]
	public class ProRealTimePVPBattleReportPlayerData : IExtensible
	{
		// Token: 0x06005BB1 RID: 23473 RVA: 0x001A3D3C File Offset: 0x001A1F3C
		public ProRealTimePVPBattleReportPlayerData()
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

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x001A3DB8 File Offset: 0x001A1FB8
		// (set) Token: 0x06005BB3 RID: 23475 RVA: 0x001A3DC0 File Offset: 0x001A1FC0
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

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06005BB4 RID: 23476 RVA: 0x001A3DCC File Offset: 0x001A1FCC
		// (set) Token: 0x06005BB5 RID: 23477 RVA: 0x001A3DD4 File Offset: 0x001A1FD4
		[ProtoMember(2, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06005BB6 RID: 23478 RVA: 0x001A3DE0 File Offset: 0x001A1FE0
		// (set) Token: 0x06005BB7 RID: 23479 RVA: 0x001A3DE8 File Offset: 0x001A1FE8
		[ProtoMember(3, IsRequired = true, Name = "HeadIcon", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x001A3DF4 File Offset: 0x001A1FF4
		// (set) Token: 0x06005BB9 RID: 23481 RVA: 0x001A3DFC File Offset: 0x001A1FFC
		[ProtoMember(4, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06005BBA RID: 23482 RVA: 0x001A3E08 File Offset: 0x001A2008
		[ProtoMember(5, Name = "Heroes", DataFormat = DataFormat.Default)]
		public List<ProBattleHero> Heroes
		{
			get
			{
				return this._Heroes;
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06005BBB RID: 23483 RVA: 0x001A3E10 File Offset: 0x001A2010
		[ProtoMember(6, Name = "Techs", DataFormat = DataFormat.Default)]
		public List<ProTrainingTech> Techs
		{
			get
			{
				return this._Techs;
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06005BBC RID: 23484 RVA: 0x001A3E18 File Offset: 0x001A2018
		// (set) Token: 0x06005BBD RID: 23485 RVA: 0x001A3E20 File Offset: 0x001A2020
		[ProtoMember(7, IsRequired = true, Name = "ScoreDiff", DataFormat = DataFormat.TwosComplement)]
		public int ScoreDiff
		{
			get
			{
				return this._ScoreDiff;
			}
			set
			{
				this._ScoreDiff = value;
			}
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x001A3E2C File Offset: 0x001A202C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x001A3E3C File Offset: 0x001A203C
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

		// Token: 0x06005BC0 RID: 23488 RVA: 0x001A3F08 File Offset: 0x001A2108
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRealTimePVPBattleReportPlayerData));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044A6 RID: 17574
		private string _UserId;

		// Token: 0x040044A7 RID: 17575
		private string _Name;

		// Token: 0x040044A8 RID: 17576
		private int _HeadIcon;

		// Token: 0x040044A9 RID: 17577
		private int _Level;

		// Token: 0x040044AA RID: 17578
		private readonly List<ProBattleHero> _Heroes = new List<ProBattleHero>();

		// Token: 0x040044AB RID: 17579
		private readonly List<ProTrainingTech> _Techs = new List<ProTrainingTech>();

		// Token: 0x040044AC RID: 17580
		private int _ScoreDiff;

		// Token: 0x040044AD RID: 17581
		private IExtension extensionObject;

		// Token: 0x040044AE RID: 17582
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040044AF RID: 17583
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040044B0 RID: 17584
		private LuaFunction m_ctor_hotfix;
	}
}
