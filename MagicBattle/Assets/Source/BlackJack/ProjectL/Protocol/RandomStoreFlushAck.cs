using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000809 RID: 2057
	[ProtoContract(Name = "RandomStoreFlushAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RandomStoreFlushAck : IExtensible
	{
		// Token: 0x06006807 RID: 26631 RVA: 0x001D5DB8 File Offset: 0x001D3FB8
		public RandomStoreFlushAck()
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

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06006808 RID: 26632 RVA: 0x001D5E20 File Offset: 0x001D4020
		// (set) Token: 0x06006809 RID: 26633 RVA: 0x001D5E28 File Offset: 0x001D4028
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x0600680A RID: 26634 RVA: 0x001D5E34 File Offset: 0x001D4034
		// (set) Token: 0x0600680B RID: 26635 RVA: 0x001D5E3C File Offset: 0x001D403C
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "Store", DataFormat = DataFormat.Default)]
		public ProRandomStore Store
		{
			get
			{
				return this._Store;
			}
			set
			{
				this._Store = value;
			}
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x001D5E48 File Offset: 0x001D4048
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x001D5E58 File Offset: 0x001D4058
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

		// Token: 0x0600680E RID: 26638 RVA: 0x001D5F24 File Offset: 0x001D4124
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomStoreFlushAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400502E RID: 20526
		private int _Result;

		// Token: 0x0400502F RID: 20527
		private ProRandomStore _Store;

		// Token: 0x04005030 RID: 20528
		private IExtension extensionObject;

		// Token: 0x04005031 RID: 20529
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005032 RID: 20530
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005033 RID: 20531
		private LuaFunction m_ctor_hotfix;
	}
}
