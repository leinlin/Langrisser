using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000643 RID: 1603
	[ProtoContract(Name = "ProEquipment")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProEquipment : IExtensible
	{
		// Token: 0x060057B7 RID: 22455 RVA: 0x00198F18 File Offset: 0x00197118
		public ProEquipment()
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

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x00198F8C File Offset: 0x0019718C
		// (set) Token: 0x060057B9 RID: 22457 RVA: 0x00198F94 File Offset: 0x00197194
		[ProtoMember(1, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x060057BA RID: 22458 RVA: 0x00198FA0 File Offset: 0x001971A0
		// (set) Token: 0x060057BB RID: 22459 RVA: 0x00198FA8 File Offset: 0x001971A8
		[ProtoMember(2, IsRequired = true, Name = "Exp", DataFormat = DataFormat.TwosComplement)]
		public int Exp
		{
			get
			{
				return this._Exp;
			}
			set
			{
				this._Exp = value;
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x060057BC RID: 22460 RVA: 0x00198FB4 File Offset: 0x001971B4
		// (set) Token: 0x060057BD RID: 22461 RVA: 0x00198FBC File Offset: 0x001971BC
		[ProtoMember(3, IsRequired = true, Name = "StarLevel", DataFormat = DataFormat.TwosComplement)]
		public int StarLevel
		{
			get
			{
				return this._StarLevel;
			}
			set
			{
				this._StarLevel = value;
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x060057BE RID: 22462 RVA: 0x00198FC8 File Offset: 0x001971C8
		// (set) Token: 0x060057BF RID: 22463 RVA: 0x00198FD0 File Offset: 0x001971D0
		[ProtoMember(4, IsRequired = true, Name = "Locked", DataFormat = DataFormat.Default)]
		public bool Locked
		{
			get
			{
				return this._Locked;
			}
			set
			{
				this._Locked = value;
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x060057C0 RID: 22464 RVA: 0x00198FDC File Offset: 0x001971DC
		[ProtoMember(5, Name = "EnchantProperties", DataFormat = DataFormat.Default)]
		public List<ProCommonBattleProperty> EnchantProperties
		{
			get
			{
				return this._EnchantProperties;
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x060057C1 RID: 22465 RVA: 0x00198FE4 File Offset: 0x001971E4
		// (set) Token: 0x060057C2 RID: 22466 RVA: 0x00198FEC File Offset: 0x001971EC
		[ProtoMember(6, IsRequired = false, Name = "ResonanceId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int ResonanceId
		{
			get
			{
				return this._ResonanceId;
			}
			set
			{
				this._ResonanceId = value;
			}
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x00198FF8 File Offset: 0x001971F8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x00199008 File Offset: 0x00197208
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

		// Token: 0x060057C5 RID: 22469 RVA: 0x001990D4 File Offset: 0x001972D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProEquipment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041DC RID: 16860
		private int _Level;

		// Token: 0x040041DD RID: 16861
		private int _Exp;

		// Token: 0x040041DE RID: 16862
		private int _StarLevel;

		// Token: 0x040041DF RID: 16863
		private bool _Locked;

		// Token: 0x040041E0 RID: 16864
		private readonly List<ProCommonBattleProperty> _EnchantProperties = new List<ProCommonBattleProperty>();

		// Token: 0x040041E1 RID: 16865
		private int _ResonanceId;

		// Token: 0x040041E2 RID: 16866
		private IExtension extensionObject;

		// Token: 0x040041E3 RID: 16867
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041E4 RID: 16868
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041E5 RID: 16869
		private LuaFunction m_ctor_hotfix;
	}
}
