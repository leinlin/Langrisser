using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007DC RID: 2012
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LevelWayPointMoveAck")]
	[Serializable]
	public class LevelWayPointMoveAck : IExtensible
	{
		// Token: 0x06006693 RID: 26259 RVA: 0x001C968C File Offset: 0x001C788C
		public LevelWayPointMoveAck()
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

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06006694 RID: 26260 RVA: 0x001C9700 File Offset: 0x001C7900
		// (set) Token: 0x06006695 RID: 26261 RVA: 0x001C9708 File Offset: 0x001C7908
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

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06006696 RID: 26262 RVA: 0x001C9714 File Offset: 0x001C7914
		// (set) Token: 0x06006697 RID: 26263 RVA: 0x001C971C File Offset: 0x001C791C
		[ProtoMember(2, IsRequired = true, Name = "WayPointId", DataFormat = DataFormat.TwosComplement)]
		public int WayPointId
		{
			get
			{
				return this._WayPointId;
			}
			set
			{
				this._WayPointId = value;
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06006698 RID: 26264 RVA: 0x001C9728 File Offset: 0x001C7928
		// (set) Token: 0x06006699 RID: 26265 RVA: 0x001C9730 File Offset: 0x001C7930
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

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x0600669A RID: 26266 RVA: 0x001C973C File Offset: 0x001C793C
		// (set) Token: 0x0600669B RID: 26267 RVA: 0x001C9744 File Offset: 0x001C7944
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

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x0600669C RID: 26268 RVA: 0x001C9750 File Offset: 0x001C7950
		[ProtoMember(5, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x001C9758 File Offset: 0x001C7958
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x001C9768 File Offset: 0x001C7968
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

		// Token: 0x0600669F RID: 26271 RVA: 0x001C9834 File Offset: 0x001C7A34
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelWayPointMoveAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004CD5 RID: 19669
		private int _Result;

		// Token: 0x04004CD6 RID: 19670
		private int _WayPointId;

		// Token: 0x04004CD7 RID: 19671
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004CD8 RID: 19672
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x04004CD9 RID: 19673
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004CDA RID: 19674
		private IExtension extensionObject;

		// Token: 0x04004CDB RID: 19675
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004CDC RID: 19676
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CDD RID: 19677
		private LuaFunction m_ctor_hotfix;
	}
}
