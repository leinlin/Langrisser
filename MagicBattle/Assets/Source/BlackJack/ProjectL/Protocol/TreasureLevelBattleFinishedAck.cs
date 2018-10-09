using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000853 RID: 2131
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TreasureLevelBattleFinishedAck")]
	[Serializable]
	public class TreasureLevelBattleFinishedAck : IExtensible
	{
		// Token: 0x06006A55 RID: 27221 RVA: 0x001DE590 File Offset: 0x001DC790
		public TreasureLevelBattleFinishedAck()
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

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06006A56 RID: 27222 RVA: 0x001DE60C File Offset: 0x001DC80C
		// (set) Token: 0x06006A57 RID: 27223 RVA: 0x001DE614 File Offset: 0x001DC814
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

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06006A58 RID: 27224 RVA: 0x001DE620 File Offset: 0x001DC820
		// (set) Token: 0x06006A59 RID: 27225 RVA: 0x001DE628 File Offset: 0x001DC828
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

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06006A5A RID: 27226 RVA: 0x001DE634 File Offset: 0x001DC834
		// (set) Token: 0x06006A5B RID: 27227 RVA: 0x001DE63C File Offset: 0x001DC83C
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

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06006A5C RID: 27228 RVA: 0x001DE648 File Offset: 0x001DC848
		// (set) Token: 0x06006A5D RID: 27229 RVA: 0x001DE650 File Offset: 0x001DC850
		[ProtoMember(4, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
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

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06006A5E RID: 27230 RVA: 0x001DE65C File Offset: 0x001DC85C
		// (set) Token: 0x06006A5F RID: 27231 RVA: 0x001DE664 File Offset: 0x001DC864
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

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06006A60 RID: 27232 RVA: 0x001DE670 File Offset: 0x001DC870
		[ProtoMember(6, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06006A61 RID: 27233 RVA: 0x001DE678 File Offset: 0x001DC878
		[ProtoMember(7, Name = "BattleTreasures", DataFormat = DataFormat.TwosComplement)]
		public List<int> BattleTreasures
		{
			get
			{
				return this._BattleTreasures;
			}
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x001DE680 File Offset: 0x001DC880
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x001DE690 File Offset: 0x001DC890
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

		// Token: 0x06006A64 RID: 27236 RVA: 0x001DE75C File Offset: 0x001DC95C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TreasureLevelBattleFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051F2 RID: 20978
		private int _Result;

		// Token: 0x040051F3 RID: 20979
		private int _LevelId;

		// Token: 0x040051F4 RID: 20980
		private bool _Win;

		// Token: 0x040051F5 RID: 20981
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x040051F6 RID: 20982
		private ProChangedGoodsNtf _Treasure;

		// Token: 0x040051F7 RID: 20983
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x040051F8 RID: 20984
		private readonly List<int> _BattleTreasures = new List<int>();

		// Token: 0x040051F9 RID: 20985
		private IExtension extensionObject;

		// Token: 0x040051FA RID: 20986
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051FB RID: 20987
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051FC RID: 20988
		private LuaFunction m_ctor_hotfix;
	}
}
