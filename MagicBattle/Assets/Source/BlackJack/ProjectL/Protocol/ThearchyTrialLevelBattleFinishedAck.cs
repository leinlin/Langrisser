using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200084D RID: 2125
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ThearchyTrialLevelBattleFinishedAck")]
	[Serializable]
	public class ThearchyTrialLevelBattleFinishedAck : IExtensible
	{
		// Token: 0x06006A1C RID: 27164 RVA: 0x001DDA24 File Offset: 0x001DBC24
		public ThearchyTrialLevelBattleFinishedAck()
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

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06006A1D RID: 27165 RVA: 0x001DDAAC File Offset: 0x001DBCAC
		// (set) Token: 0x06006A1E RID: 27166 RVA: 0x001DDAB4 File Offset: 0x001DBCB4
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

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06006A1F RID: 27167 RVA: 0x001DDAC0 File Offset: 0x001DBCC0
		// (set) Token: 0x06006A20 RID: 27168 RVA: 0x001DDAC8 File Offset: 0x001DBCC8
		[ProtoMember(2, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06006A21 RID: 27169 RVA: 0x001DDAD4 File Offset: 0x001DBCD4
		// (set) Token: 0x06006A22 RID: 27170 RVA: 0x001DDADC File Offset: 0x001DBCDC
		[ProtoMember(3, IsRequired = true, Name = "Win", DataFormat = DataFormat.Default)]
		public bool Win
		{
			get
			{
				return this._Win;
			}
			set
			{
				this._Win = value;
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06006A23 RID: 27171 RVA: 0x001DDAE8 File Offset: 0x001DBCE8
		// (set) Token: 0x06006A24 RID: 27172 RVA: 0x001DDAF0 File Offset: 0x001DBCF0
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06006A25 RID: 27173 RVA: 0x001DDAFC File Offset: 0x001DBCFC
		// (set) Token: 0x06006A26 RID: 27174 RVA: 0x001DDB04 File Offset: 0x001DBD04
		[DefaultValue(null)]
		[ProtoMember(5, IsRequired = false, Name = "Treasure", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Treasure
		{
			get
			{
				return this._Treasure;
			}
			set
			{
				this._Treasure = value;
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06006A27 RID: 27175 RVA: 0x001DDB10 File Offset: 0x001DBD10
		[ProtoMember(6, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06006A28 RID: 27176 RVA: 0x001DDB18 File Offset: 0x001DBD18
		[ProtoMember(7, Name = "DailyRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> DailyRewards
		{
			get
			{
				return this._DailyRewards;
			}
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06006A29 RID: 27177 RVA: 0x001DDB20 File Offset: 0x001DBD20
		[ProtoMember(8, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x001DDB28 File Offset: 0x001DBD28
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x001DDB38 File Offset: 0x001DBD38
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

		// Token: 0x06006A2C RID: 27180 RVA: 0x001DDC04 File Offset: 0x001DBE04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ThearchyTrialLevelBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051C8 RID: 20936
		private int _Result;

		// Token: 0x040051C9 RID: 20937
		private int _LevelId;

		// Token: 0x040051CA RID: 20938
		private bool _Win;

		// Token: 0x040051CB RID: 20939
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x040051CC RID: 20940
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x040051CD RID: 20941
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x040051CE RID: 20942
		private readonly List<ProGoods> _DailyRewards = new List<ProGoods>();

		// Token: 0x040051CF RID: 20943
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x040051D0 RID: 20944
		private IExtension extensionObject;

		// Token: 0x040051D1 RID: 20945
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051D2 RID: 20946
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051D3 RID: 20947
		private LuaFunction m_ctor_hotfix;
	}
}
