using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200024C RID: 588
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataHeroLevelInfo")]
	[Serializable]
	public class ConfigDataHeroLevelInfo : IExtensible
	{
		// Token: 0x060024A5 RID: 9381 RVA: 0x000A77A0 File Offset: 0x000A59A0
		public ConfigDataHeroLevelInfo()
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

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x000A7808 File Offset: 0x000A5A08
		// (set) Token: 0x060024A7 RID: 9383 RVA: 0x000A7810 File Offset: 0x000A5A10
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

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x000A781C File Offset: 0x000A5A1C
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x000A7824 File Offset: 0x000A5A24
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

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x000A7830 File Offset: 0x000A5A30
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x000A7838 File Offset: 0x000A5A38
		[ProtoMember(4, IsRequired = true, Name = "SkillPoint", DataFormat = DataFormat.TwosComplement)]
		public int SkillPoint
		{
			get
			{
				return this._SkillPoint;
			}
			set
			{
				this._SkillPoint = value;
			}
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x000A7844 File Offset: 0x000A5A44
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x000A7854 File Offset: 0x000A5A54
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

		// Token: 0x060024AE RID: 9390 RVA: 0x000A7920 File Offset: 0x000A5B20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400165C RID: 5724
		private int _ID;

		// Token: 0x0400165D RID: 5725
		private int _Exp;

		// Token: 0x0400165E RID: 5726
		private int _SkillPoint;

		// Token: 0x0400165F RID: 5727
		private IExtension extensionObject;

		// Token: 0x04001660 RID: 5728
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001661 RID: 5729
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001662 RID: 5730
		private LuaFunction m_ctor_hotfix;
	}
}
