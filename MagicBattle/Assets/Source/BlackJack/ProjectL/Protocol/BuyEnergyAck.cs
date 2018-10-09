using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006F4 RID: 1780
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BuyEnergyAck")]
	[Serializable]
	public class BuyEnergyAck : IExtensible
	{
		// Token: 0x06005EFD RID: 24317 RVA: 0x001AE854 File Offset: 0x001ACA54
		public BuyEnergyAck()
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

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06005EFE RID: 24318 RVA: 0x001AE8BC File Offset: 0x001ACABC
		// (set) Token: 0x06005EFF RID: 24319 RVA: 0x001AE8C4 File Offset: 0x001ACAC4
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

		// Token: 0x06005F00 RID: 24320 RVA: 0x001AE8D0 File Offset: 0x001ACAD0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x001AE8E0 File Offset: 0x001ACAE0
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

		// Token: 0x06005F02 RID: 24322 RVA: 0x001AE9AC File Offset: 0x001ACBAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BuyEnergyAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004716 RID: 18198
		private int _Result;

		// Token: 0x04004717 RID: 18199
		private IExtension extensionObject;

		// Token: 0x04004718 RID: 18200
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004719 RID: 18201
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400471A RID: 18202
		private LuaFunction m_ctor_hotfix;
	}
}
