using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000807 RID: 2055
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RandomStoreGetAck")]
	[Serializable]
	public class RandomStoreGetAck : IExtensible
	{
		// Token: 0x060067F9 RID: 26617 RVA: 0x001D5A24 File Offset: 0x001D3C24
		public RandomStoreGetAck()
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

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x060067FA RID: 26618 RVA: 0x001D5A8C File Offset: 0x001D3C8C
		// (set) Token: 0x060067FB RID: 26619 RVA: 0x001D5A94 File Offset: 0x001D3C94
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

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x060067FC RID: 26620 RVA: 0x001D5AA0 File Offset: 0x001D3CA0
		// (set) Token: 0x060067FD RID: 26621 RVA: 0x001D5AA8 File Offset: 0x001D3CA8
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

		// Token: 0x060067FE RID: 26622 RVA: 0x001D5AB4 File Offset: 0x001D3CB4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x001D5AC4 File Offset: 0x001D3CC4
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

		// Token: 0x06006800 RID: 26624 RVA: 0x001D5B90 File Offset: 0x001D3D90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomStoreGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005023 RID: 20515
		private int _Result;

		// Token: 0x04005024 RID: 20516
		private ProRandomStore _Store;

		// Token: 0x04005025 RID: 20517
		private IExtension extensionObject;

		// Token: 0x04005026 RID: 20518
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005027 RID: 20519
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005028 RID: 20520
		private LuaFunction m_ctor_hotfix;
	}
}
