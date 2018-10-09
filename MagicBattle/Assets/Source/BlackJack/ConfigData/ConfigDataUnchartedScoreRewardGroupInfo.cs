using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002AF RID: 687
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataUnchartedScoreRewardGroupInfo")]
	[Serializable]
	public class ConfigDataUnchartedScoreRewardGroupInfo : IExtensible
	{
		// Token: 0x06002D22 RID: 11554 RVA: 0x000B68F8 File Offset: 0x000B4AF8
		public ConfigDataUnchartedScoreRewardGroupInfo()
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

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x000B696C File Offset: 0x000B4B6C
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x000B6974 File Offset: 0x000B4B74
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x000B6980 File Offset: 0x000B4B80
		// (set) Token: 0x06002D26 RID: 11558 RVA: 0x000B6988 File Offset: 0x000B4B88
		[ProtoMember(3, IsRequired = true, Name = "GroupId", DataFormat = DataFormat.TwosComplement)]
		public int GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				this._GroupId = value;
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000B6994 File Offset: 0x000B4B94
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x000B699C File Offset: 0x000B4B9C
		[ProtoMember(4, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
		public int Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				this._Score = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000B69A8 File Offset: 0x000B4BA8
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x000B69B0 File Offset: 0x000B4BB0
		[ProtoMember(5, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x000B69BC File Offset: 0x000B4BBC
		[ProtoMember(6, Name = "RewardList", DataFormat = DataFormat.Default)]
		public List<Goods> RewardList
		{
			get
			{
				return this._RewardList;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002D2C RID: 11564 RVA: 0x000B69C4 File Offset: 0x000B4BC4
		// (set) Token: 0x06002D2D RID: 11565 RVA: 0x000B69CC File Offset: 0x000B4BCC
		[ProtoMember(7, IsRequired = true, Name = "RewardDisplayCount", DataFormat = DataFormat.TwosComplement)]
		public int RewardDisplayCount
		{
			get
			{
				return this._RewardDisplayCount;
			}
			set
			{
				this._RewardDisplayCount = value;
			}
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000B69D8 File Offset: 0x000B4BD8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x000B69E8 File Offset: 0x000B4BE8
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

		// Token: 0x06002D30 RID: 11568 RVA: 0x000B6AB4 File Offset: 0x000B4CB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataUnchartedScoreRewardGroupInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001BE6 RID: 7142
		private int _ID;

		// Token: 0x04001BE7 RID: 7143
		private int _GroupId;

		// Token: 0x04001BE8 RID: 7144
		private int _Score;

		// Token: 0x04001BE9 RID: 7145
		private string _Name;

		// Token: 0x04001BEA RID: 7146
		private readonly List<Goods> _RewardList = new List<Goods>();

		// Token: 0x04001BEB RID: 7147
		private int _RewardDisplayCount;

		// Token: 0x04001BEC RID: 7148
		private IExtension extensionObject;

		// Token: 0x04001BED RID: 7149
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001BEE RID: 7150
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001BEF RID: 7151
		private LuaFunction m_ctor_hotfix;
	}
}
