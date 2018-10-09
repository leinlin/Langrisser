using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000671 RID: 1649
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProHeroFetter")]
	[Serializable]
	public class ProHeroFetter : IExtensible
	{
		// Token: 0x060059DE RID: 23006 RVA: 0x0019EC04 File Offset: 0x0019CE04
		public ProHeroFetter()
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

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x060059DF RID: 23007 RVA: 0x0019EC6C File Offset: 0x0019CE6C
		// (set) Token: 0x060059E0 RID: 23008 RVA: 0x0019EC74 File Offset: 0x0019CE74
		[ProtoMember(1, IsRequired = true, Name = "FetterId", DataFormat = DataFormat.TwosComplement)]
		public int FetterId
		{
			get
			{
				return this._FetterId;
			}
			set
			{
				this._FetterId = value;
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x060059E1 RID: 23009 RVA: 0x0019EC80 File Offset: 0x0019CE80
		// (set) Token: 0x060059E2 RID: 23010 RVA: 0x0019EC88 File Offset: 0x0019CE88
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

		// Token: 0x060059E3 RID: 23011 RVA: 0x0019EC94 File Offset: 0x0019CE94
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060059E4 RID: 23012 RVA: 0x0019ECA4 File Offset: 0x0019CEA4
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

		// Token: 0x060059E5 RID: 23013 RVA: 0x0019ED70 File Offset: 0x0019CF70
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProHeroFetter));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400435F RID: 17247
		private int _FetterId;

		// Token: 0x04004360 RID: 17248
		private int _Level;

		// Token: 0x04004361 RID: 17249
		private IExtension extensionObject;

		// Token: 0x04004362 RID: 17250
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004363 RID: 17251
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004364 RID: 17252
		private LuaFunction m_ctor_hotfix;
	}
}
