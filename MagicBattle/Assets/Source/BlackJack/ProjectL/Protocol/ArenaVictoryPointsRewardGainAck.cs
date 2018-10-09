using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005BF RID: 1471
	[ProtoContract(Name = "ArenaVictoryPointsRewardGainAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaVictoryPointsRewardGainAck : IExtensible
	{
		// Token: 0x06005314 RID: 21268 RVA: 0x00189690 File Offset: 0x00187890
		public ArenaVictoryPointsRewardGainAck()
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

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06005315 RID: 21269 RVA: 0x00189704 File Offset: 0x00187904
		// (set) Token: 0x06005316 RID: 21270 RVA: 0x0018970C File Offset: 0x0018790C
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

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06005317 RID: 21271 RVA: 0x00189718 File Offset: 0x00187918
		// (set) Token: 0x06005318 RID: 21272 RVA: 0x00189720 File Offset: 0x00187920
		[ProtoMember(2, IsRequired = true, Name = "RewardIndex", DataFormat = DataFormat.TwosComplement)]
		public int RewardIndex
		{
			get
			{
				return this._RewardIndex;
			}
			set
			{
				this._RewardIndex = value;
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x0018972C File Offset: 0x0018792C
		// (set) Token: 0x0600531A RID: 21274 RVA: 0x00189734 File Offset: 0x00187934
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

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x0600531B RID: 21275 RVA: 0x00189740 File Offset: 0x00187940
		[ProtoMember(4, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x00189748 File Offset: 0x00187948
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x00189758 File Offset: 0x00187958
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

		// Token: 0x0600531E RID: 21278 RVA: 0x00189824 File Offset: 0x00187A24
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaVictoryPointsRewardGainAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E6A RID: 15978
		private int _Result;

		// Token: 0x04003E6B RID: 15979
		private int _RewardIndex;

		// Token: 0x04003E6C RID: 15980
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04003E6D RID: 15981
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04003E6E RID: 15982
		private IExtension extensionObject;

		// Token: 0x04003E6F RID: 15983
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E70 RID: 15984
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E71 RID: 15985
		private LuaFunction m_ctor_hotfix;
	}
}
