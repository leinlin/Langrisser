using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200066B RID: 1643
	[ProtoContract(Name = "ProBattleHeroEquipment")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProBattleHeroEquipment : IExtensible
	{
		// Token: 0x060059A5 RID: 22949 RVA: 0x0019E094 File Offset: 0x0019C294
		public ProBattleHeroEquipment()
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

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x060059A6 RID: 22950 RVA: 0x0019E108 File Offset: 0x0019C308
		// (set) Token: 0x060059A7 RID: 22951 RVA: 0x0019E110 File Offset: 0x0019C310
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x060059A8 RID: 22952 RVA: 0x0019E11C File Offset: 0x0019C31C
		// (set) Token: 0x060059A9 RID: 22953 RVA: 0x0019E124 File Offset: 0x0019C324
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

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x060059AA RID: 22954 RVA: 0x0019E130 File Offset: 0x0019C330
		// (set) Token: 0x060059AB RID: 22955 RVA: 0x0019E138 File Offset: 0x0019C338
		[ProtoMember(3, IsRequired = true, Name = "Exp", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x0019E144 File Offset: 0x0019C344
		// (set) Token: 0x060059AD RID: 22957 RVA: 0x0019E14C File Offset: 0x0019C34C
		[ProtoMember(4, IsRequired = true, Name = "StarLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x060059AE RID: 22958 RVA: 0x0019E158 File Offset: 0x0019C358
		[ProtoMember(5, Name = "EnchantProperties", DataFormat = DataFormat.Default)]
		public List<ProCommonBattleProperty> EnchantProperties
		{
			get
			{
				return this._EnchantProperties;
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x060059AF RID: 22959 RVA: 0x0019E160 File Offset: 0x0019C360
		// (set) Token: 0x060059B0 RID: 22960 RVA: 0x0019E168 File Offset: 0x0019C368
		[DefaultValue(0)]
		[ProtoMember(6, IsRequired = false, Name = "ResonanceId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060059B1 RID: 22961 RVA: 0x0019E174 File Offset: 0x0019C374
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x0019E184 File Offset: 0x0019C384
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

		// Token: 0x060059B3 RID: 22963 RVA: 0x0019E250 File Offset: 0x0019C450
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBattleHeroEquipment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004335 RID: 17205
		private int _Id;

		// Token: 0x04004336 RID: 17206
		private int _Level;

		// Token: 0x04004337 RID: 17207
		private int _Exp;

		// Token: 0x04004338 RID: 17208
		private int _StarLevel;

		// Token: 0x04004339 RID: 17209
		private readonly List<ProCommonBattleProperty> _EnchantProperties = new List<ProCommonBattleProperty>();

		// Token: 0x0400433A RID: 17210
		private int _ResonanceId;

		// Token: 0x0400433B RID: 17211
		private IExtension extensionObject;

		// Token: 0x0400433C RID: 17212
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400433D RID: 17213
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400433E RID: 17214
		private LuaFunction m_ctor_hotfix;
	}
}
