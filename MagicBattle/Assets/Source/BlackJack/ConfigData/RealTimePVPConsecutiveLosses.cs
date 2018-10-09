using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002FE RID: 766
	[ProtoContract(Name = "RealTimePVPConsecutiveLosses")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RealTimePVPConsecutiveLosses : IExtensible
	{
		// Token: 0x06002E0F RID: 11791 RVA: 0x000B87C0 File Offset: 0x000B69C0
		public RealTimePVPConsecutiveLosses()
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

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x000B8828 File Offset: 0x000B6A28
		// (set) Token: 0x06002E11 RID: 11793 RVA: 0x000B8830 File Offset: 0x000B6A30
		[ProtoMember(1, IsRequired = true, Name = "ConsecutiveLosses", DataFormat = DataFormat.TwosComplement)]
		public int ConsecutiveLosses
		{
			get
			{
				return this._ConsecutiveLosses;
			}
			set
			{
				this._ConsecutiveLosses = value;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002E12 RID: 11794 RVA: 0x000B883C File Offset: 0x000B6A3C
		// (set) Token: 0x06002E13 RID: 11795 RVA: 0x000B8844 File Offset: 0x000B6A44
		[ProtoMember(2, IsRequired = true, Name = "ScoreProtection", DataFormat = DataFormat.TwosComplement)]
		public int ScoreProtection
		{
			get
			{
				return this._ScoreProtection;
			}
			set
			{
				this._ScoreProtection = value;
			}
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x000B8850 File Offset: 0x000B6A50
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x000B8860 File Offset: 0x000B6A60
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

		// Token: 0x06002E16 RID: 11798 RVA: 0x000B892C File Offset: 0x000B6B2C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPConsecutiveLosses));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400235C RID: 9052
		private int _ConsecutiveLosses;

		// Token: 0x0400235D RID: 9053
		private int _ScoreProtection;

		// Token: 0x0400235E RID: 9054
		private IExtension extensionObject;

		// Token: 0x0400235F RID: 9055
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002360 RID: 9056
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002361 RID: 9057
		private LuaFunction m_ctor_hotfix;
	}
}
