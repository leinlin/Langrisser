using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000680 RID: 1664
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBusinessCard")]
	[Serializable]
	public class ProBusinessCard : IExtensible
	{
		// Token: 0x06005AA6 RID: 23206 RVA: 0x001A0AC8 File Offset: 0x0019ECC8
		public ProBusinessCard()
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

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06005AA7 RID: 23207 RVA: 0x001A0B50 File Offset: 0x0019ED50
		// (set) Token: 0x06005AA8 RID: 23208 RVA: 0x001A0B58 File Offset: 0x0019ED58
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

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06005AA9 RID: 23209 RVA: 0x001A0B64 File Offset: 0x0019ED64
		// (set) Token: 0x06005AAA RID: 23210 RVA: 0x001A0B6C File Offset: 0x0019ED6C
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

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06005AAB RID: 23211 RVA: 0x001A0B78 File Offset: 0x0019ED78
		// (set) Token: 0x06005AAC RID: 23212 RVA: 0x001A0B80 File Offset: 0x0019ED80
		[ProtoMember(3, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06005AAD RID: 23213 RVA: 0x001A0B8C File Offset: 0x0019ED8C
		// (set) Token: 0x06005AAE RID: 23214 RVA: 0x001A0B94 File Offset: 0x0019ED94
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

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x001A0BA0 File Offset: 0x0019EDA0
		// (set) Token: 0x06005AB0 RID: 23216 RVA: 0x001A0BA8 File Offset: 0x0019EDA8
		[ProtoMember(5, IsRequired = true, Name = "ArenaPoints", DataFormat = DataFormat.TwosComplement)]
		public int ArenaPoints
		{
			get
			{
				return this._ArenaPoints;
			}
			set
			{
				this._ArenaPoints = value;
			}
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06005AB1 RID: 23217 RVA: 0x001A0BB4 File Offset: 0x0019EDB4
		// (set) Token: 0x06005AB2 RID: 23218 RVA: 0x001A0BBC File Offset: 0x0019EDBC
		[ProtoMember(6, IsRequired = true, Name = "Likes", DataFormat = DataFormat.TwosComplement)]
		public int Likes
		{
			get
			{
				return this._Likes;
			}
			set
			{
				this._Likes = value;
			}
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06005AB3 RID: 23219 RVA: 0x001A0BC8 File Offset: 0x0019EDC8
		// (set) Token: 0x06005AB4 RID: 23220 RVA: 0x001A0BD0 File Offset: 0x0019EDD0
		[ProtoMember(7, IsRequired = true, Name = "IsOnLine", DataFormat = DataFormat.Default)]
		public bool IsOnLine
		{
			get
			{
				return this._IsOnLine;
			}
			set
			{
				this._IsOnLine = value;
			}
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x001A0BDC File Offset: 0x0019EDDC
		[ProtoMember(8, Name = "Heroes", DataFormat = DataFormat.Default)]
		public List<ProBattleHero> Heroes
		{
			get
			{
				return this._Heroes;
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06005AB6 RID: 23222 RVA: 0x001A0BE4 File Offset: 0x0019EDE4
		// (set) Token: 0x06005AB7 RID: 23223 RVA: 0x001A0BEC File Offset: 0x0019EDEC
		[ProtoMember(9, IsRequired = true, Name = "SetInfo", DataFormat = DataFormat.Default)]
		public ProBusinessCardInfoSet SetInfo
		{
			get
			{
				return this._SetInfo;
			}
			set
			{
				this._SetInfo = value;
			}
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06005AB8 RID: 23224 RVA: 0x001A0BF8 File Offset: 0x0019EDF8
		// (set) Token: 0x06005AB9 RID: 23225 RVA: 0x001A0C00 File Offset: 0x0019EE00
		[ProtoMember(10, IsRequired = true, Name = "StatisticalData", DataFormat = DataFormat.Default)]
		public ProBusinessCardStatisticalData StatisticalData
		{
			get
			{
				return this._StatisticalData;
			}
			set
			{
				this._StatisticalData = value;
			}
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06005ABA RID: 23226 RVA: 0x001A0C0C File Offset: 0x0019EE0C
		[ProtoMember(11, Name = "Techs", DataFormat = DataFormat.Default)]
		public List<ProTrainingTech> Techs
		{
			get
			{
				return this._Techs;
			}
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06005ABB RID: 23227 RVA: 0x001A0C14 File Offset: 0x0019EE14
		[ProtoMember(12, Name = "MostSkilledHeroes", DataFormat = DataFormat.Default)]
		public List<ProBattleHero> MostSkilledHeroes
		{
			get
			{
				return this._MostSkilledHeroes;
			}
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x001A0C1C File Offset: 0x0019EE1C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x001A0C2C File Offset: 0x0019EE2C
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

		// Token: 0x06005ABE RID: 23230 RVA: 0x001A0CF8 File Offset: 0x0019EEF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBusinessCard));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040043E4 RID: 17380
		private string _UserId;

		// Token: 0x040043E5 RID: 17381
		private string _Name;

		// Token: 0x040043E6 RID: 17382
		private int _Level;

		// Token: 0x040043E7 RID: 17383
		private int _HeadIcon;

		// Token: 0x040043E8 RID: 17384
		private int _ArenaPoints;

		// Token: 0x040043E9 RID: 17385
		private int _Likes;

		// Token: 0x040043EA RID: 17386
		private bool _IsOnLine;

		// Token: 0x040043EB RID: 17387
		private readonly List<ProBattleHero> _Heroes = new List<ProBattleHero>();

		// Token: 0x040043EC RID: 17388
		private ProBusinessCardInfoSet _SetInfo;

		// Token: 0x040043ED RID: 17389
		private ProBusinessCardStatisticalData _StatisticalData;

		// Token: 0x040043EE RID: 17390
		private readonly List<ProTrainingTech> _Techs = new List<ProTrainingTech>();

		// Token: 0x040043EF RID: 17391
		private readonly List<ProBattleHero> _MostSkilledHeroes = new List<ProBattleHero>();

		// Token: 0x040043F0 RID: 17392
		private IExtension extensionObject;

		// Token: 0x040043F1 RID: 17393
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040043F2 RID: 17394
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040043F3 RID: 17395
		private LuaFunction m_ctor_hotfix;
	}
}
