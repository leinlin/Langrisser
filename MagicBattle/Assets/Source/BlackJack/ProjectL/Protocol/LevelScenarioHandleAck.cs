using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007E1 RID: 2017
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LevelScenarioHandleAck")]
	[Serializable]
	public class LevelScenarioHandleAck : IExtensible
	{
		// Token: 0x060066C4 RID: 26308 RVA: 0x001CA024 File Offset: 0x001C8224
		public LevelScenarioHandleAck()
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

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x060066C5 RID: 26309 RVA: 0x001CA098 File Offset: 0x001C8298
		// (set) Token: 0x060066C6 RID: 26310 RVA: 0x001CA0A0 File Offset: 0x001C82A0
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

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x060066C7 RID: 26311 RVA: 0x001CA0AC File Offset: 0x001C82AC
		// (set) Token: 0x060066C8 RID: 26312 RVA: 0x001CA0B4 File Offset: 0x001C82B4
		[ProtoMember(2, IsRequired = true, Name = "ScenarioId", DataFormat = DataFormat.TwosComplement)]
		public int ScenarioId
		{
			get
			{
				return this._ScenarioId;
			}
			set
			{
				this._ScenarioId = value;
			}
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x060066C9 RID: 26313 RVA: 0x001CA0C0 File Offset: 0x001C82C0
		// (set) Token: 0x060066CA RID: 26314 RVA: 0x001CA0C8 File Offset: 0x001C82C8
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x060066CB RID: 26315 RVA: 0x001CA0D4 File Offset: 0x001C82D4
		// (set) Token: 0x060066CC RID: 26316 RVA: 0x001CA0DC File Offset: 0x001C82DC
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "BattleBeginInfo", DataFormat = DataFormat.Default)]
		public ProBattleBeginInfo BattleBeginInfo
		{
			get
			{
				return this._BattleBeginInfo;
			}
			set
			{
				this._BattleBeginInfo = value;
			}
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x060066CD RID: 26317 RVA: 0x001CA0E8 File Offset: 0x001C82E8
		[ProtoMember(5, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x001CA0F0 File Offset: 0x001C82F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x001CA100 File Offset: 0x001C8300
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

		// Token: 0x060066D0 RID: 26320 RVA: 0x001CA1CC File Offset: 0x001C83CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelScenarioHandleAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CF9 RID: 19705
		private int _Result;

		// Token: 0x04004CFA RID: 19706
		private int _ScenarioId;

		// Token: 0x04004CFB RID: 19707
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004CFC RID: 19708
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04004CFD RID: 19709
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004CFE RID: 19710
		private IExtension extensionObject;

		// Token: 0x04004CFF RID: 19711
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D00 RID: 19712
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D01 RID: 19713
		private LuaFunction m_ctor_hotfix;
	}
}
