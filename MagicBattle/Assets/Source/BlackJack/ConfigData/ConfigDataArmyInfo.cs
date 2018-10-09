using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000203 RID: 515
	[ProtoContract(Name = "ConfigDataArmyInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataArmyInfo : IExtensible
	{
		// Token: 0x06001D94 RID: 7572 RVA: 0x0009B570 File Offset: 0x00099770
		public ConfigDataArmyInfo()
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

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x0009B5D8 File Offset: 0x000997D8
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x0009B5E0 File Offset: 0x000997E0
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

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x0009B5EC File Offset: 0x000997EC
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x0009B5F4 File Offset: 0x000997F4
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

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0009B600 File Offset: 0x00099800
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x0009B608 File Offset: 0x00099808
		[ProtoMember(4, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
		public string NameStrKey
		{
			get
			{
				return this._NameStrKey;
			}
			set
			{
				this._NameStrKey = value;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x0009B614 File Offset: 0x00099814
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0009B61C File Offset: 0x0009981C
		[ProtoMember(5, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x0009B628 File Offset: 0x00099828
		// (set) Token: 0x06001D9E RID: 7582 RVA: 0x0009B630 File Offset: 0x00099830
		[ProtoMember(6, IsRequired = true, Name = "DescStrKey", DataFormat = DataFormat.Default)]
		public string DescStrKey
		{
			get
			{
				return this._DescStrKey;
			}
			set
			{
				this._DescStrKey = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x0009B63C File Offset: 0x0009983C
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0009B644 File Offset: 0x00099844
		[ProtoMember(7, IsRequired = true, Name = "ArmyTag", DataFormat = DataFormat.TwosComplement)]
		public ArmyTag ArmyTag
		{
			get
			{
				return this._ArmyTag;
			}
			set
			{
				this._ArmyTag = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x0009B650 File Offset: 0x00099850
		// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x0009B658 File Offset: 0x00099858
		[ProtoMember(8, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x0009B664 File Offset: 0x00099864
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x0009B66C File Offset: 0x0009986C
		[ProtoMember(9, IsRequired = true, Name = "Icon_NoBack", DataFormat = DataFormat.Default)]
		public string Icon_NoBack
		{
			get
			{
				return this._Icon_NoBack;
			}
			set
			{
				this._Icon_NoBack = value;
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0009B678 File Offset: 0x00099878
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x0009B688 File Offset: 0x00099888
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

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0009B754 File Offset: 0x00099954
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataArmyInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040011B1 RID: 4529
		private int _ID;

		// Token: 0x040011B2 RID: 4530
		private string _Name;

		// Token: 0x040011B3 RID: 4531
		private string _NameStrKey;

		// Token: 0x040011B4 RID: 4532
		private string _Desc;

		// Token: 0x040011B5 RID: 4533
		private string _DescStrKey;

		// Token: 0x040011B6 RID: 4534
		private ArmyTag _ArmyTag;

		// Token: 0x040011B7 RID: 4535
		private string _Icon;

		// Token: 0x040011B8 RID: 4536
		private string _Icon_NoBack;

		// Token: 0x040011B9 RID: 4537
		private IExtension extensionObject;

		// Token: 0x040011BA RID: 4538
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040011BB RID: 4539
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040011BC RID: 4540
		private LuaFunction m_ctor_hotfix;
	}
}
