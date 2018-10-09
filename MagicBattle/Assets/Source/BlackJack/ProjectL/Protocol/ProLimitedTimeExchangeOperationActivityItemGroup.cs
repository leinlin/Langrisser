using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000667 RID: 1639
	[ProtoContract(Name = "ProLimitedTimeExchangeOperationActivityItemGroup")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProLimitedTimeExchangeOperationActivityItemGroup : IExtensible
	{
		// Token: 0x0600597F RID: 22911 RVA: 0x0019D908 File Offset: 0x0019BB08
		public ProLimitedTimeExchangeOperationActivityItemGroup()
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

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06005980 RID: 22912 RVA: 0x0019D970 File Offset: 0x0019BB70
		// (set) Token: 0x06005981 RID: 22913 RVA: 0x0019D978 File Offset: 0x0019BB78
		[ProtoMember(1, IsRequired = true, Name = "ItemGroupIndex", DataFormat = DataFormat.TwosComplement)]
		public int ItemGroupIndex
		{
			get
			{
				return this._ItemGroupIndex;
			}
			set
			{
				this._ItemGroupIndex = value;
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06005982 RID: 22914 RVA: 0x0019D984 File Offset: 0x0019BB84
		// (set) Token: 0x06005983 RID: 22915 RVA: 0x0019D98C File Offset: 0x0019BB8C
		[ProtoMember(2, IsRequired = true, Name = "ExchangedNums", DataFormat = DataFormat.TwosComplement)]
		public int ExchangedNums
		{
			get
			{
				return this._ExchangedNums;
			}
			set
			{
				this._ExchangedNums = value;
			}
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x0019D998 File Offset: 0x0019BB98
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x0019D9A8 File Offset: 0x0019BBA8
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

		// Token: 0x06005986 RID: 22918 RVA: 0x0019DA74 File Offset: 0x0019BC74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProLimitedTimeExchangeOperationActivityItemGroup));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400431A RID: 17178
		private int _ItemGroupIndex;

		// Token: 0x0400431B RID: 17179
		private int _ExchangedNums;

		// Token: 0x0400431C RID: 17180
		private IExtension extensionObject;

		// Token: 0x0400431D RID: 17181
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400431E RID: 17182
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400431F RID: 17183
		private LuaFunction m_ctor_hotfix;
	}
}
