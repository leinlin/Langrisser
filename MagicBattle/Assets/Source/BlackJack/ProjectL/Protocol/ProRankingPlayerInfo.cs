using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000678 RID: 1656
	[ProtoContract(Name = "ProRankingPlayerInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProRankingPlayerInfo : IExtensible
	{
		// Token: 0x06005A3B RID: 23099 RVA: 0x0019FA5C File Offset: 0x0019DC5C
		public ProRankingPlayerInfo()
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

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06005A3C RID: 23100 RVA: 0x0019FAC4 File Offset: 0x0019DCC4
		// (set) Token: 0x06005A3D RID: 23101 RVA: 0x0019FACC File Offset: 0x0019DCCC
		[ProtoMember(1, IsRequired = true, Name = "HeadIcon", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06005A3E RID: 23102 RVA: 0x0019FAD8 File Offset: 0x0019DCD8
		// (set) Token: 0x06005A3F RID: 23103 RVA: 0x0019FAE0 File Offset: 0x0019DCE0
		[ProtoMember(2, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06005A40 RID: 23104 RVA: 0x0019FAEC File Offset: 0x0019DCEC
		// (set) Token: 0x06005A41 RID: 23105 RVA: 0x0019FAF4 File Offset: 0x0019DCF4
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

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06005A42 RID: 23106 RVA: 0x0019FB00 File Offset: 0x0019DD00
		// (set) Token: 0x06005A43 RID: 23107 RVA: 0x0019FB08 File Offset: 0x0019DD08
		[ProtoMember(4, IsRequired = true, Name = "ChampionHeroId", DataFormat = DataFormat.TwosComplement)]
		public int ChampionHeroId
		{
			get
			{
				return this._ChampionHeroId;
			}
			set
			{
				this._ChampionHeroId = value;
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x0019FB14 File Offset: 0x0019DD14
		// (set) Token: 0x06005A45 RID: 23109 RVA: 0x0019FB1C File Offset: 0x0019DD1C
		[ProtoMember(5, IsRequired = true, Name = "Score", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005A46 RID: 23110 RVA: 0x0019FB28 File Offset: 0x0019DD28
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x0019FB38 File Offset: 0x0019DD38
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

		// Token: 0x06005A48 RID: 23112 RVA: 0x0019FC04 File Offset: 0x0019DE04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRankingPlayerInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400439D RID: 17309
		private int _HeadIcon;

		// Token: 0x0400439E RID: 17310
		private int _Level;

		// Token: 0x0400439F RID: 17311
		private string _Name;

		// Token: 0x040043A0 RID: 17312
		private int _ChampionHeroId;

		// Token: 0x040043A1 RID: 17313
		private int _Score;

		// Token: 0x040043A2 RID: 17314
		private IExtension extensionObject;

		// Token: 0x040043A3 RID: 17315
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040043A4 RID: 17316
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040043A5 RID: 17317
		private LuaFunction m_ctor_hotfix;
	}
}
