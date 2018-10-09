using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006B3 RID: 1715
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProGuildMassiveCombatAttackResultNtf")]
	[Serializable]
	public class ProGuildMassiveCombatAttackResultNtf : IExtensible
	{
		// Token: 0x06005CE4 RID: 23780 RVA: 0x001A6FC8 File Offset: 0x001A51C8
		public ProGuildMassiveCombatAttackResultNtf()
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

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x06005CE5 RID: 23781 RVA: 0x001A7044 File Offset: 0x001A5244
		// (set) Token: 0x06005CE6 RID: 23782 RVA: 0x001A704C File Offset: 0x001A524C
		[ProtoMember(1, IsRequired = true, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06005CE7 RID: 23783 RVA: 0x001A7058 File Offset: 0x001A5258
		// (set) Token: 0x06005CE8 RID: 23784 RVA: 0x001A7060 File Offset: 0x001A5260
		[ProtoMember(2, IsRequired = true, Name = "Points", DataFormat = DataFormat.TwosComplement)]
		public int Points
		{
			get
			{
				return this._Points;
			}
			set
			{
				this._Points = value;
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06005CE9 RID: 23785 RVA: 0x001A706C File Offset: 0x001A526C
		[ProtoMember(3, Name = "UsedHeroIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> UsedHeroIds
		{
			get
			{
				return this._UsedHeroIds;
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06005CEA RID: 23786 RVA: 0x001A7074 File Offset: 0x001A5274
		// (set) Token: 0x06005CEB RID: 23787 RVA: 0x001A707C File Offset: 0x001A527C
		[ProtoMember(4, IsRequired = true, Name = "TotalPoints", DataFormat = DataFormat.TwosComplement)]
		public int TotalPoints
		{
			get
			{
				return this._TotalPoints;
			}
			set
			{
				this._TotalPoints = value;
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06005CEC RID: 23788 RVA: 0x001A7088 File Offset: 0x001A5288
		[ProtoMember(5, Name = "PointslRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> PointslRewards
		{
			get
			{
				return this._PointslRewards;
			}
		}

		// Token: 0x06005CED RID: 23789 RVA: 0x001A7090 File Offset: 0x001A5290
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x001A70A0 File Offset: 0x001A52A0
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

		// Token: 0x06005CEF RID: 23791 RVA: 0x001A716C File Offset: 0x001A536C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuildMassiveCombatAttackResultNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400457B RID: 17787
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x0400457C RID: 17788
		private int _Points;

		// Token: 0x0400457D RID: 17789
		private readonly List<int> _UsedHeroIds = new List<int>();

		// Token: 0x0400457E RID: 17790
		private int _TotalPoints;

		// Token: 0x0400457F RID: 17791
		private readonly List<ProGoods> _PointslRewards = new List<ProGoods>();

		// Token: 0x04004580 RID: 17792
		private IExtension extensionObject;

		// Token: 0x04004581 RID: 17793
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004582 RID: 17794
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004583 RID: 17795
		private LuaFunction m_ctor_hotfix;
	}
}
