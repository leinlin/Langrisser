using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000743 RID: 1859
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "MonthCardUpdateNtf")]
	[Serializable]
	public class MonthCardUpdateNtf : IExtensible
	{
		// Token: 0x060061A5 RID: 24997 RVA: 0x001B7C5C File Offset: 0x001B5E5C
		public MonthCardUpdateNtf()
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

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x060061A6 RID: 24998 RVA: 0x001B7CC4 File Offset: 0x001B5EC4
		// (set) Token: 0x060061A7 RID: 24999 RVA: 0x001B7CCC File Offset: 0x001B5ECC
		[ProtoMember(1, IsRequired = true, Name = "MonthCard", DataFormat = DataFormat.Default)]
		public ProMonthCard MonthCard
		{
			get
			{
				return this._MonthCard;
			}
			set
			{
				this._MonthCard = value;
			}
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x001B7CD8 File Offset: 0x001B5ED8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x001B7CE8 File Offset: 0x001B5EE8
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

		// Token: 0x060061AA RID: 25002 RVA: 0x001B7DB4 File Offset: 0x001B5FB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MonthCardUpdateNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004920 RID: 18720
		private ProMonthCard _MonthCard;

		// Token: 0x04004921 RID: 18721
		private IExtension extensionObject;

		// Token: 0x04004922 RID: 18722
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004923 RID: 18723
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004924 RID: 18724
		private LuaFunction m_ctor_hotfix;
	}
}
