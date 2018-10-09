using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200020C RID: 524
	[ProtoContract(Name = "ConfigDataBattlefieldInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataBattlefieldInfo : IExtensible
	{
		// Token: 0x06001E4A RID: 7754 RVA: 0x0009CBC4 File Offset: 0x0009ADC4
		public ConfigDataBattlefieldInfo()
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

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x0009CC38 File Offset: 0x0009AE38
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x0009CC40 File Offset: 0x0009AE40
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

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x0009CC4C File Offset: 0x0009AE4C
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x0009CC54 File Offset: 0x0009AE54
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

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x0009CC60 File Offset: 0x0009AE60
		// (set) Token: 0x06001E50 RID: 7760 RVA: 0x0009CC68 File Offset: 0x0009AE68
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

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x0009CC74 File Offset: 0x0009AE74
		// (set) Token: 0x06001E52 RID: 7762 RVA: 0x0009CC7C File Offset: 0x0009AE7C
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x0009CC88 File Offset: 0x0009AE88
		// (set) Token: 0x06001E54 RID: 7764 RVA: 0x0009CC90 File Offset: 0x0009AE90
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

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x0009CC9C File Offset: 0x0009AE9C
		// (set) Token: 0x06001E56 RID: 7766 RVA: 0x0009CCA4 File Offset: 0x0009AEA4
		[ProtoMember(7, IsRequired = true, Name = "Width", DataFormat = DataFormat.TwosComplement)]
		public int Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				this._Width = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x0009CCB0 File Offset: 0x0009AEB0
		// (set) Token: 0x06001E58 RID: 7768 RVA: 0x0009CCB8 File Offset: 0x0009AEB8
		[ProtoMember(8, IsRequired = true, Name = "Height", DataFormat = DataFormat.TwosComplement)]
		public int Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				this._Height = value;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x0009CCC4 File Offset: 0x0009AEC4
		[ProtoMember(9, Name = "Terrains", DataFormat = DataFormat.TwosComplement)]
		public List<int> Terrains
		{
			get
			{
				return this._Terrains;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x0009CCCC File Offset: 0x0009AECC
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x0009CCD4 File Offset: 0x0009AED4
		[ProtoMember(10, IsRequired = true, Name = "BattleMap", DataFormat = DataFormat.Default)]
		public string BattleMap
		{
			get
			{
				return this._BattleMap;
			}
			set
			{
				this._BattleMap = value;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x0009CCE0 File Offset: 0x0009AEE0
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x0009CCE8 File Offset: 0x0009AEE8
		[ProtoMember(11, IsRequired = true, Name = "BackgroundWidth", DataFormat = DataFormat.TwosComplement)]
		public int BackgroundWidth
		{
			get
			{
				return this._BackgroundWidth;
			}
			set
			{
				this._BackgroundWidth = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0009CCF4 File Offset: 0x0009AEF4
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0009CCFC File Offset: 0x0009AEFC
		[ProtoMember(12, IsRequired = true, Name = "BackgroundHeight", DataFormat = DataFormat.TwosComplement)]
		public int BackgroundHeight
		{
			get
			{
				return this._BackgroundHeight;
			}
			set
			{
				this._BackgroundHeight = value;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0009CD08 File Offset: 0x0009AF08
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0009CD10 File Offset: 0x0009AF10
		[ProtoMember(13, IsRequired = true, Name = "BackgroundOffsetX", DataFormat = DataFormat.FixedSize)]
		public float BackgroundOffsetX
		{
			get
			{
				return this._BackgroundOffsetX;
			}
			set
			{
				this._BackgroundOffsetX = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0009CD1C File Offset: 0x0009AF1C
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0009CD24 File Offset: 0x0009AF24
		[ProtoMember(14, IsRequired = true, Name = "BackgroundOffsetY", DataFormat = DataFormat.FixedSize)]
		public float BackgroundOffsetY
		{
			get
			{
				return this._BackgroundOffsetY;
			}
			set
			{
				this._BackgroundOffsetY = value;
			}
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0009CD30 File Offset: 0x0009AF30
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0009CD40 File Offset: 0x0009AF40
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

		// Token: 0x06001E66 RID: 7782 RVA: 0x0009CE0C File Offset: 0x0009B00C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattlefieldInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001229 RID: 4649
		private int _ID;

		// Token: 0x0400122A RID: 4650
		private string _Name;

		// Token: 0x0400122B RID: 4651
		private string _NameStrKey;

		// Token: 0x0400122C RID: 4652
		private string _Desc;

		// Token: 0x0400122D RID: 4653
		private string _DescStrKey;

		// Token: 0x0400122E RID: 4654
		private int _Width;

		// Token: 0x0400122F RID: 4655
		private int _Height;

		// Token: 0x04001230 RID: 4656
		private readonly List<int> _Terrains = new List<int>();

		// Token: 0x04001231 RID: 4657
		private string _BattleMap;

		// Token: 0x04001232 RID: 4658
		private int _BackgroundWidth;

		// Token: 0x04001233 RID: 4659
		private int _BackgroundHeight;

		// Token: 0x04001234 RID: 4660
		private float _BackgroundOffsetX;

		// Token: 0x04001235 RID: 4661
		private float _BackgroundOffsetY;

		// Token: 0x04001236 RID: 4662
		private IExtension extensionObject;

		// Token: 0x04001237 RID: 4663
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001238 RID: 4664
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001239 RID: 4665
		private LuaFunction m_ctor_hotfix;
	}
}
