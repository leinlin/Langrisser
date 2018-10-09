using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200068B RID: 1675
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProCommonBattleProperty")]
	[Serializable]
	public class ProCommonBattleProperty : IExtensible
	{
		// Token: 0x06005B2E RID: 23342 RVA: 0x001A2110 File Offset: 0x001A0310
		public ProCommonBattleProperty()
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

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06005B2F RID: 23343 RVA: 0x001A2178 File Offset: 0x001A0378
		// (set) Token: 0x06005B30 RID: 23344 RVA: 0x001A2180 File Offset: 0x001A0380
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

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06005B31 RID: 23345 RVA: 0x001A218C File Offset: 0x001A038C
		// (set) Token: 0x06005B32 RID: 23346 RVA: 0x001A2194 File Offset: 0x001A0394
		[ProtoMember(2, IsRequired = true, Name = "Value", DataFormat = DataFormat.TwosComplement)]
		public int Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				this._Value = value;
			}
		}

		// Token: 0x06005B33 RID: 23347 RVA: 0x001A21A0 File Offset: 0x001A03A0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x001A21B0 File Offset: 0x001A03B0
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

		// Token: 0x06005B35 RID: 23349 RVA: 0x001A227C File Offset: 0x001A047C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProCommonBattleProperty));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004442 RID: 17474
		private int _Id;

		// Token: 0x04004443 RID: 17475
		private int _Value;

		// Token: 0x04004444 RID: 17476
		private IExtension extensionObject;

		// Token: 0x04004445 RID: 17477
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004446 RID: 17478
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004447 RID: 17479
		private LuaFunction m_ctor_hotfix;
	}
}
