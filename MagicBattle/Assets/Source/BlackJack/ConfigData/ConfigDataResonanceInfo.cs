using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000281 RID: 641
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataResonanceInfo")]
	[Serializable]
	public class ConfigDataResonanceInfo : IExtensible
	{
		// Token: 0x06002916 RID: 10518 RVA: 0x000AF700 File Offset: 0x000AD900
		public ConfigDataResonanceInfo()
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

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000AF768 File Offset: 0x000AD968
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x000AF770 File Offset: 0x000AD970
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

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x000AF77C File Offset: 0x000AD97C
		// (set) Token: 0x0600291A RID: 10522 RVA: 0x000AF784 File Offset: 0x000AD984
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

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x000AF790 File Offset: 0x000AD990
		// (set) Token: 0x0600291C RID: 10524 RVA: 0x000AF798 File Offset: 0x000AD998
		[ProtoMember(4, IsRequired = true, Name = "SmallIcon", DataFormat = DataFormat.Default)]
		public string SmallIcon
		{
			get
			{
				return this._SmallIcon;
			}
			set
			{
				this._SmallIcon = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x0600291D RID: 10525 RVA: 0x000AF7A4 File Offset: 0x000AD9A4
		// (set) Token: 0x0600291E RID: 10526 RVA: 0x000AF7AC File Offset: 0x000AD9AC
		[ProtoMember(5, IsRequired = true, Name = "InactiveIcon", DataFormat = DataFormat.Default)]
		public string InactiveIcon
		{
			get
			{
				return this._InactiveIcon;
			}
			set
			{
				this._InactiveIcon = value;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x000AF7B8 File Offset: 0x000AD9B8
		// (set) Token: 0x06002920 RID: 10528 RVA: 0x000AF7C0 File Offset: 0x000AD9C0
		[ProtoMember(6, IsRequired = true, Name = "ActiveIcon", DataFormat = DataFormat.Default)]
		public string ActiveIcon
		{
			get
			{
				return this._ActiveIcon;
			}
			set
			{
				this._ActiveIcon = value;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x000AF7CC File Offset: 0x000AD9CC
		// (set) Token: 0x06002922 RID: 10530 RVA: 0x000AF7D4 File Offset: 0x000AD9D4
		[ProtoMember(7, IsRequired = true, Name = "Affix", DataFormat = DataFormat.Default)]
		public string Affix
		{
			get
			{
				return this._Affix;
			}
			set
			{
				this._Affix = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x000AF7E0 File Offset: 0x000AD9E0
		// (set) Token: 0x06002924 RID: 10532 RVA: 0x000AF7E8 File Offset: 0x000AD9E8
		[ProtoMember(8, IsRequired = true, Name = "Effect1", DataFormat = DataFormat.TwosComplement)]
		public int Effect1
		{
			get
			{
				return this._Effect1;
			}
			set
			{
				this._Effect1 = value;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x000AF7F4 File Offset: 0x000AD9F4
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x000AF7FC File Offset: 0x000AD9FC
		[ProtoMember(9, IsRequired = true, Name = "Effect2", DataFormat = DataFormat.TwosComplement)]
		public int Effect2
		{
			get
			{
				return this._Effect2;
			}
			set
			{
				this._Effect2 = value;
			}
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000AF808 File Offset: 0x000ADA08
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000AF818 File Offset: 0x000ADA18
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

		// Token: 0x06002929 RID: 10537 RVA: 0x000AF8E4 File Offset: 0x000ADAE4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataResonanceInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001948 RID: 6472
		private int _ID;

		// Token: 0x04001949 RID: 6473
		private string _Name;

		// Token: 0x0400194A RID: 6474
		private string _SmallIcon;

		// Token: 0x0400194B RID: 6475
		private string _InactiveIcon;

		// Token: 0x0400194C RID: 6476
		private string _ActiveIcon;

		// Token: 0x0400194D RID: 6477
		private string _Affix;

		// Token: 0x0400194E RID: 6478
		private int _Effect1;

		// Token: 0x0400194F RID: 6479
		private int _Effect2;

		// Token: 0x04001950 RID: 6480
		private IExtension extensionObject;

		// Token: 0x04001951 RID: 6481
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001952 RID: 6482
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001953 RID: 6483
		private LuaFunction m_ctor_hotfix;
	}
}
